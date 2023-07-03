using Fooddeliveryapp.Data;
using Fooddeliveryapp1.DTO;
using Fooddeliveryapp1.Models;
using Fooddeliveryapp1.Repository.Interface;


namespace Fooddeliveryapp1.Repository.Implementation
{

    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}

