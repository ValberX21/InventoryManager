using InventoryManager.Application.Interface;
using InventoryManager.Domain.Entity;
using InventoryManager.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace InventoryManager.Infrastructure.Infrastructure
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public UserRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<User> AddAsync(User user)
        {
            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();
            return user;
        }

        public async Task<User?> GetByEmailAsync(string email)
        {           
            return await _dbContext.Users.FirstOrDefaultAsync(x => x.Email == email);
        }
    }
}
