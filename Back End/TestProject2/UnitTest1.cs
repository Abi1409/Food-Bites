using AutoMapper;
using Fooddeliveryapp.Data;
using Fooddeliveryapp1;
using Fooddeliveryapp1.Controllers;
using Fooddeliveryapp1.DTO;
using Fooddeliveryapp1.Models;
using Fooddeliveryapp1.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Moq;

namespace TestProject2
{
    [TestFixture]
    public class AuthControllerTests
    {
        private AuthController authController;
        private Mock<IUserRepository> userRepositoryMock;
        private IMapper mapperMock;
        private ApplicationDbContext dbContext;
        private Mock<IConfiguration> configurationMock;
        private Mock<ILoginRepository> loginRepositoryMock;



        [SetUp]
        public void Setup()
        {
            userRepositoryMock = new Mock<IUserRepository>();
            loginRepositoryMock = new Mock<ILoginRepository>();
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
               .UseInMemoryDatabase(databaseName: "TestDatabase")
               .Options;



            dbContext = new ApplicationDbContext(options);
            //add sample data
            // dbContext.Users.Add
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingConfig());
            });
            IMapper mapper = mapperConfig.CreateMapper();




            configurationMock = new Mock<IConfiguration>();
            // mockConfiguration.Setup(config => config["JWT:Key"]).Returns("dSgVkYp3s6v9y$B&E)H@MbQeThWmZq4t");



            authController = new AuthController(
            dbContext,
            configurationMock.Object,
            mapper,
            userRepositoryMock.Object,
            loginRepositoryMock.Object
            );
        }



        [Test]
        public void Login_WithInvalidCredentials_ReturnsUnauthorizedResult()
        {
            // Arrange
            var loginModel = new AddAuthUserLoginDTO
            {
                Email = "test@example",
                Password = "incorrect_password"
            };




            // Mock the behavior of IUserRepo.GetByEmailAsync to return the user with correct credentials



            loginRepositoryMock.Setup(u => u.GetByEmailAsync("test@example.com")).ReturnsAsync((User)null);



            // Act
            var result = authController.Login(loginModel) as UnauthorizedObjectResult;



            // Assert
            Assert.IsNotNull(result);
            Assert.That(result.StatusCode, Is.EqualTo(StatusCodes.Status401Unauthorized));
            Assert.That(result.Value, Is.EqualTo("Invalid Username or Password!"));
        }
    }
}