using ATO_API.Controllers;
using AutoMapper;
using Data.DTO.Respone;
using Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Service.FacilityCertificationSer;
using Service.ProductSer;
using Service.TouristFacilitySer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [TestClass]
    public class TouristFacilityControllerTests
    {
        private Mock<ITouristFacilityService> _mockFacilityService;
        private Mock<IFacilityCertificationService> _mockCertificationService;
        private Mock<IProductService> _mockProductService;
        private IMapper _mapper;
        private TouristFacilityController _controller;

        [TestInitialize]
        public void Setup()
        {
            _mockFacilityService = new Mock<ITouristFacilityService>();
            _mockCertificationService = new Mock<IFacilityCertificationService>();
            _mockProductService = new Mock<IProductService>();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TouristFacility, TouristFacilityDTO_Guest>();
                cfg.CreateMap<Product, ProductDTO_Guest>();
            });
            _mapper = config.CreateMapper();

            _controller = new TouristFacilityController(
                _mockFacilityService.Object,
                _mockCertificationService.Object,
                _mockProductService.Object,
                _mapper);
        }

        [TestMethod]
        public async Task ListTouristFacility_ReturnsOkResult_WithMappedDTOs()
        {
            // Arrange
            var mockFacilities = new List<TouristFacility>
        {
            new TouristFacility { TouristFacilityId = Guid.NewGuid(), TouristFacilityName = "Facility A" },
            new TouristFacility { TouristFacilityId = Guid.NewGuid(), TouristFacilityName = "Facility B" }
        };

            _mockFacilityService.Setup(s => s.GetListTouristFacilities_Admin())
                .ReturnsAsync(mockFacilities);

            // Act
            var result = await _controller.ListTouristFacility();

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            Assert.AreEqual(200, okResult.StatusCode);
            var dtoList = okResult.Value as List<TouristFacilityDTO_Guest>;
            Assert.IsNotNull(dtoList);
            Assert.AreEqual(mockFacilities.Count, dtoList.Count);
        }
        [TestMethod]
        public async Task ListTouristFacility_ReturnsInternalServerError_WhenExceptionThrown()
        {
            // Arrange
            _mockFacilityService.Setup(s => s.GetListTouristFacilities_Admin())
                .ThrowsAsync(new Exception("Something went wrong"));

            // Act
            var result = await _controller.ListTouristFacility();

            // Assert
            var statusCodeResult = result as ObjectResult;
            Assert.IsNotNull(statusCodeResult);
            Assert.AreEqual(500, statusCodeResult.StatusCode);

            var response = result as ObjectResult;
            var responseVM = response.Value as ResponseVM;
            Assert.IsNotNull(responseVM);
            Assert.IsFalse(responseVM.Status);
            Assert.AreEqual("Something went wrong", responseVM.Message);  
        }
        [TestMethod]
        public async Task GetTouristFacility_ReturnsOk_WhenSuccessful()
        {
            // Arrange
            var touristFacilityId = Guid.NewGuid();
            var facility = new TouristFacility {};
            _mockFacilityService.Setup(s => s.GetTouristFacilities_Guest(touristFacilityId))
                .ReturnsAsync(facility);

            var products = new List<Product> {};
            _mockProductService.Setup(s => s.GetListProducts_Guest())
                .ReturnsAsync(products);

            // Act
            var result = await _controller.GetTouristFacility(touristFacilityId);

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            Assert.AreEqual(200, okResult.StatusCode);
        }
        [TestMethod]
        public async Task GetTouristFacility_ReturnsInternalServerError_WhenExceptionThrown()
        {
            // Arrange
            var touristFacilityId = Guid.NewGuid();
            _mockFacilityService.Setup(s => s.GetTouristFacilities_Guest(touristFacilityId))
                .ThrowsAsync(new Exception("An error occurred while fetching the tourist facility"));

            // Act
            var result = await _controller.GetTouristFacility(touristFacilityId);

            // Assert
            var statusCodeResult = result as ObjectResult;
            Assert.IsNotNull(statusCodeResult);
            Assert.AreEqual(500, statusCodeResult.StatusCode);

            var response = result as ObjectResult;
            var responseVM = response.Value as ResponseVM;
            Assert.IsNotNull(responseVM);
            Assert.IsFalse(responseVM.Status);
            Assert.AreEqual("An error occurred while fetching the tourist facility", responseVM.Message);
        }

    }
}
