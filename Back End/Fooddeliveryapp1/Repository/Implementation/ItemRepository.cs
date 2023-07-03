using Fooddeliveryapp.Data;
using Fooddeliveryapp1.Models;
using Fooddeliveryapp1.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Fooddeliveryapp1.Repository.Implementation
{

    public class ItemRepository : Repository<Item>, IItemRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public ItemRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
       
    }
}