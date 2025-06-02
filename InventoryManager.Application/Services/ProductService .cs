using InventoryManager.Application.DTO;
using InventoryManager.Application.Interface;
using InventoryManager.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Product> CreateAsync(ProductDto productDto)
        {
            if (productDto.Quantity <= 0) throw new Exception("Quantity need be more than 0");

            var map = new Product
            {
                Name = productDto.Name,
                Price = productDto.Price,
                Quantity = productDto.Quantity
            };

            await _productRepository.AddAsync(map);

            return new Product
            {
                Id =  map.Id,
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
