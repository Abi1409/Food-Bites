using Fooddeliveryapp.Data;
using Fooddeliveryapp1.Models;
using Fooddeliveryapp1.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Fooddeliveryapp1.Repository.Implementation
{
    public class CartRepository : Repository<Cart> ,ICartRepository
    {
        private readonly ApplicationDbContext _context;

        public CartRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Cart>> GetAllorders()
        {
            return await _context.Set<Cart>().Include(x => x.Items).Include(x => x.Users).ThenInclude(x => x.Roles).ToListAsync();
        }

    }
}
