using InventoryManager.Application.DTO;
using InventoryManager.Domain.Entity;

namespace InventoryManager.Application.Interface
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetAllAsync();
        Task<ProductDto> GetByIdAsync(int id);
        Task<Product> CreateAsync(ProductDto productDto);
        Task<bool> UpdateAsync(int id, ProductDto productDto);
        Task<bool> DeleteAsync(int id);
    }
}
