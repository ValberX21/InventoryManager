using InventoryManager.Domain.Entity;

namespace InventoryManager.Application.Interface
{
    public interface IUserRepository
    {
        Task<User?> GetByEmailAsync(string email);
        Task<User> AddAsync(User user);
    }
}
