using InventoryManager.Application.DTO;
using InventoryManager.Application.Interface;
using InventoryManager.Domain.Entity;
using Microsoft.Extensions.Logging;

namespace InventoryManager.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly ILogger<ProductService> _logger;

        public ProductService(IProductRepository productRepository,
                              ILogger<ProductService> logger)
        {
            _productRepository = productRepository;
            _logger = logger;
        }

        public void DoWork()
        {
            _logger.LogInformation("Starting work...");
        }

        public async Task<Product> CreateAsync(ProductDto productDto)
        {
            _logger.LogInformation("Creating produtct with name: {Name}",
                productDto.Name);

            if (productDto.Quantity <= 0)
            {
                _logger.LogWarning("Product creating failed: Quantity was less or equal zero");
                throw new Exception("Quantity need be more than 0");
            }

            var map = new Product
            {
                Name = productDto.Name,
                Price = productDto.Price,
                Quantity = productDto.Quantity
            };

            await _productRepository.AddAsync(map);
            
             _logger.LogInformation("Product created successfully with ID: {Id}", map.Id);

            return new Product
            {
                Id = map.Id,
                Name = map.Name,
                Price = map.Price,
                Quantity = map.Quantity
            };
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ProductDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(int id, ProductDto productDto)
        {
            throw new NotImplementedException();
        }
    }
}
