using Fooddeliveryapp1.Models;

namespace Fooddeliveryapp1.Repository.Interface
{
    public interface ICartRepository : IRepository<Cart>
    {

        Task<IEnumerable<Cart>> GetAllorders();
    }
}
