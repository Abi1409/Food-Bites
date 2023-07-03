using Fooddeliveryapp1.Models;

namespace Fooddeliveryapp1.Repository.Interface
{
    public interface ILoginRepository
    {
        Task<User> GetByEmailAsync(string email);
    }
}
