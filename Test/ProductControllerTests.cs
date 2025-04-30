using ATO_API.Controllers;
using AutoMapper;
using Data.DTO.Respone;
using Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Service.ProductSer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [TestClass]
    public class ProductControllerTests
    {
        private Mock<IProductService> _mockProductService;
        private Mock<IMapper> _mockMapper;
        private ProductController _controller;

        [TestInitialize]
        public void Setup()
        {
            _mockProductService = new Mock<IProductService>();
            _mockMapper = new Mock<IMapper>();
            _controller = new ProductController(_mockProductService.Object, _mockMapper.Object);
        }

        [TestMethod]
        public async Task GetProducts_ReturnsOk_WithProductList()
        {
            // Arrange
            var productList = new List<Product>(); // dữ liệu giả từ service
            var productDtoList = new List<ProductDTO_Guest>
            {
                new ProductDTO_Guest { ProductId = Guid.NewGuid(), ProductName = "Vải thiều loại 1" },
                new ProductDTO_Guest { ProductId = Guid.NewGuid(), ProductName = "Vải thiều loại 2" }
            };

            _mockProductService.Setup(s => s.GetListProducts_Guest())
                .ReturnsAsync(productList);

            _mockMapper.Setup(m => m.Map<List<ProductDTO_Guest>>(productList))
                .Returns(productDtoList);

            // Act
            var result = await _controller.GetProducts() as OkObjectResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.StatusCode);
            var data = result.Value as List<ProductDTO_Guest>;
            Assert.IsNotNull(data);
            Assert.AreEqual(2, data.Count);
        }

        [TestMethod]
        public async Task GetProduct_ReturnsOk_WithSingleProduct()
        {
            // Arrange
            var productId = Guid.NewGuid();
            var product = new Product { ProductId = productId, ProductName = "Vải thiều Hải Dương" };
            var productDto = new ProductDTO_Guest { ProductId = productId, ProductName = "Vải thiều Hải Dương" };

            _mockProductService.Setup(s => s.GetProduct_Guest(productId))
                .ReturnsAsync(product);

            _mockMapper.Setup(m => m.Map<ProductDTO_Guest>(product))
                .Returns(productDto);

            // Act
            var result = await _controller.GetProduct(productId) as OkObjectResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.StatusCode);
            var data = result.Value as ProductDTO_Guest;
            Assert.IsNotNull(data);
            Assert.AreEqual(productId, data.ProductId);
        }

        [TestMethod]
        public async Task GetProducts_Returns500_OnException()
        {
            // Arrange
            _mockProductService.Setup(s => s.GetListProducts_Guest())
                .ThrowsAsync(new Exception("Lỗi server"));

            // Act
            var result = await _controller.GetProducts() as ObjectResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(500, result.StatusCode);
            var response = result.Value as ResponseVM;
            Assert.IsFalse(response.Status);
            Assert.AreEqual("Lỗi server", response.Message);
        }

        [TestMethod]
        public async Task GetProduct_Returns500_OnException()
        {
            // Arrange
            var productId = Guid.NewGuid();
            _mockProductService.Setup(s => s.GetProduct_Guest(productId))
                .ThrowsAsync(new Exception("Lỗi khi lấy sản phẩm"));

            // Act
            var result = await _controller.GetProduct(productId) as ObjectResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(500, result.StatusCode);
            var response = result.Value as ResponseVM;
            Assert.IsFalse(response.Status);
            Assert.AreEqual("Lỗi khi lấy sản phẩm", response.Message);
        }
    }
}
