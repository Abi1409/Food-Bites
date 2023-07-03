using AutoMapper;
using Fooddeliveryapp.Data;
using Fooddeliveryapp1.DTO;
using Fooddeliveryapp1.Models;
using Fooddeliveryapp1.Repository.Interface;
using IdentityModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using FluentValidation.Results;

namespace Fooddeliveryapp1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private ApplicationDbContext context;
        private readonly IConfiguration configuration;
        private readonly IMapper mapper;
        private readonly IUserRepository userRepository;
        private readonly ILoginRepository _loginRepository;


        public AuthController(ApplicationDbContext context, IConfiguration configuration, IMapper mapper, 
                                    IUserRepository userRepository , ILoginRepository loginRepository1)
        {
            this.context = context;
            this.configuration = configuration;
            this.mapper = mapper;
            this.userRepository = userRepository;
            _loginRepository = loginRepository1;
          

        }
        [Route("login")]
        [HttpPost]
        public IActionResult Login(AddAuthUserLoginDTO loginModel)
        {

            var user = context.Users.Include(x => x.Roles).SingleOrDefault(x => x.Email == loginModel.Email);

            if (user is null)
                return Unauthorized("Invalid Username or Password!");

            string hashedPassword = HashPassword(loginModel.Password);
            if (BCrypt.Net.BCrypt.Verify(loginModel.Password, user.Password))
            {

                var token = Jwt.GenerateToken(new Dictionary<string, string> {
                { ClaimTypes.Role, user.Roles.RoleName  },
                { "RoleId", user.Roles.RoleId.ToString() },
                {JwtClaimTypes.PreferredUserName, user.UserName },
                { JwtClaimTypes.Id, user.UserId.ToString() },
                { JwtClaimTypes.Email, user.Email}
            }, configuration["JWT:Key"]);

                

                return Ok(new AddAuthResponseDTO { token = token, UserName = user.UserName,RoleId = user.RoleId, UserId = user.UserId }); ;
            }
            else
            {
                return Unauthorized("Invalid Username or Password");
            }
        }
        [Route("Registration")]
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddUserRequestDTO addUserRequestDTO)
        {
           
                    // Check if a user with the same email already exists
                    var existingUser = await _loginRepository.GetByEmailAsync(addUserRequestDTO.Email);
                    if (existingUser != null)
                    {
                        // Return an error response indicating that the email is already registered
                        return BadRequest("Email is already registered.");
                    }
                    //Map DTO to Domain Model           
                    var userEntity = mapper.Map<User>(addUserRequestDTO);
                    userEntity.Password = HashPassword(addUserRequestDTO.Password);

                    await userRepository.AddAsync(userEntity);
                    // var users = mapper.Map<UserDTO>(userEntity);

                    return Ok("Registration Successful");
                }
            

        
        private string HashPassword(string password)
        {
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
            return hashedPassword;
        }

    }
}
