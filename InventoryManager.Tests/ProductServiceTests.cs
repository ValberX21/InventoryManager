using InventoryManager.Application.DTO;
using InventoryManager.Application.Interface;
using InventoryManager.Application.Services;
using InventoryManager.Domain.Entity;
using Moq;

namespace InventoryManager.Tests
{
    public class ProductServiceTests
    {
        private Mock<IProductRepository> _mockRep;
        private ProductService _productservice;

        [SetUp]
        public void Setup()
        {
            _mockRep = new Mock<IProductRepository>();
            _productservice = new ProductService(_mockRep.Object,null);
        }

        [Test]
        public async Task CreateProductAsync_ShouldReturnCreatedProduct()
        {

            var newProduct = new ProductDto { Name = "Galaxy A55", Price = 0000.01m, Quantity = 1 };

            var result = await _productservice.CreateAsync(newProduct);

            Assert.AreEqual("Galaxy A55", result.Name);
            Assert.AreEqual(0000.01m, result.Price);
            Assert.AreEqual(1, result.Quantity);
            _mockRep.Verify(repo => repo.AddAsync(It.IsAny<Product>()), Times.Once);
        }

    }
}
