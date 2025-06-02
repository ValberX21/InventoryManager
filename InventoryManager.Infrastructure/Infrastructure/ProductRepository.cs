using InventoryManager.Application.Interface;
using InventoryManager.Domain.Entity;
using InventoryManager.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;

namespace InventoryManager.Infrastructure.Infrastructure
{
    public class ProductRepository : IProductRepository
    {

        private readonly ApplicationDbContext _dbContext;

        public ProductRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(Product product)
        {
            _dbContext.Product.Add(product);
            await _dbContext.SaveChangesAsync();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Product?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
