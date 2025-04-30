using ATO_API.Controllers.Admin;
using AutoMapper;
using Data.DTO.Request;
using Data.DTO.Respone;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Service.AccountSer;
using Service.TourCompanySer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [TestClass]
    public class TourCompanyControllerTests_Admin
    {
        private Mock<ITourCompanyService> _mockTourCompanyService;
        private Mock<IAccountService> _mockAccountService;
        private IMapper _mapper;
        private TourCompanyController _controller;

        [TestInitialize]
        public void Setup()
        {
            _mockTourCompanyService = new Mock<ITourCompanyService>();
            _mockAccountService = new Mock<IAccountService>();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Data.Models.TourCompany, TourCompanyDTO>();
            });
            _mapper = config.CreateMapper();

            _controller = new TourCompanyController(
                _mockTourCompanyService.Object,
                _mockAccountService.Object,
                _mapper);
        }

        [TestMethod]
        public async Task ListTourCompany_ReturnsOk_WhenSuccessful()
        {
            // Arrange
            var mockCompanies = new List<Data.Models.TourCompany>
            {
                new Data.Models.TourCompany { TourCompanyId = Guid.NewGuid(), CompanynName = "Test Company 1" },
                new Data.Models.TourCompany { TourCompanyId = Guid.NewGuid(), CompanynName = "Test Company 2" }
            };

            _mockTourCompanyService.Setup(service => service.GetListTourCompanies_Admin())
                .ReturnsAsync(mockCompanies);

            // Act
            var result = await _controller.ListTourCompany();

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            Assert.AreEqual(200, okResult.StatusCode);

            var response = okResult.Value as List<TourCompanyDTO>;
            Assert.IsNotNull(response);
            Assert.AreEqual(2, response.Count);
        }
        [TestMethod]
        public async Task ListTourCompany_ReturnsInternalServerError_WhenExceptionOccurs()
        {
            // Arrange
            _mockTourCompanyService
                .Setup(service => service.GetListTourCompanies_Admin())
                .ThrowsAsync(new Exception("Database error"));

            // Act
            var result = await _controller.ListTourCompany();

            // Assert
            var statusCodeResult = result as ObjectResult;
            Assert.IsNotNull(statusCodeResult);
            Assert.AreEqual(StatusCodes.Status500InternalServerError, statusCodeResult.StatusCode);
        }
        [TestMethod]
        public async Task GetTourCompany_ReturnsOk_WhenCompanyExists()
        {
            // Arrange
            var tourCompanyId = Guid.NewGuid();
            var mockCompany = new Data.Models.TourCompany
            {
                TourCompanyId = tourCompanyId,
                CompanynName = "Test Company",
                // Add other necessary properties
            };

            _mockTourCompanyService.Setup(service => service.GetTourCompany_Admin(tourCompanyId))
                .ReturnsAsync(mockCompany);

            // Act
            var result = await _controller.GetTourCompany(tourCompanyId);

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            Assert.AreEqual(200, okResult.StatusCode);

            var response = okResult.Value as TourCompanyDTO;
            Assert.IsNotNull(response);
            // Add assertions for mapped properties
        }

        [TestMethod]
        public async Task GetTourCompany_ReturnsInternalServerError_WhenExceptionOccurs()
        {
            // Arrange
            var tourCompanyId = Guid.NewGuid();
            _mockTourCompanyService.Setup(service => service.GetTourCompany_Admin(tourCompanyId))
                .ThrowsAsync(new Exception("Test error message"));

            // Act
            var result = await _controller.GetTourCompany(tourCompanyId);

            // Assert
            var statusCodeResult = result as ObjectResult;
            Assert.IsNotNull(statusCodeResult);
            Assert.AreEqual(500, statusCodeResult.StatusCode);

            var response = statusCodeResult.Value as ResponseVM;
            Assert.IsNotNull(response);
            Assert.IsFalse(response.Status);
            Assert.AreEqual("Test error message", response.Message);
        }
        [TestMethod]
        public async Task CreateTourCompany_ReturnsCreated_WhenValidRequest()
        {
            // Arrange
            var request = new CreateTourCompanyRequest
            {
                CompanynName = "Test Company",
                UserId = Guid.NewGuid()
                // Add other required properties
            };

            var mappedCompany = new Data.Models.TourCompany
            {
                TourCompanyId = Guid.NewGuid(),
                CompanynName = request.CompanynName,
                UserId = request.UserId,
                CreateDate = DateTime.UtcNow
            };

            _mockTourCompanyService.Setup(s => s.AddTourCompanyAsync(It.IsAny<Data.Models.TourCompany>()))
                .Returns(Task.CompletedTask);

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CreateTourCompanyRequest, Data.Models.TourCompany>();
                cfg.CreateMap<Data.Models.TourCompany, TourCompanyDTO>();
            });
            var mapper = config.CreateMapper();
            _controller = new TourCompanyController(_mockTourCompanyService.Object, _mockAccountService.Object, mapper);

            // Act
            var result = await _controller.CreateTourCompany(request);

            // Assert
            var createdResult = result as CreatedAtActionResult;
            Assert.IsNotNull(createdResult);
            Assert.AreEqual(201, createdResult.StatusCode);
            Assert.AreEqual("GetTourCompany", createdResult.ActionName);
        }

        [TestMethod]
        public async Task CreateTourCompany_ReturnsBadRequest_WhenCompanyNameIsEmpty()
        {
            // Arrange
            var request = new CreateTourCompanyRequest
            {
                CompanynName = "",
                UserId = Guid.NewGuid()
            };

            // Act
            var result = await _controller.CreateTourCompany(request);

            // Assert
            var badRequestResult = result as BadRequestObjectResult;
            Assert.IsNotNull(badRequestResult);
            Assert.AreEqual(400, badRequestResult.StatusCode);

            var response = badRequestResult.Value as ResponseVM;
            Assert.IsNotNull(response);
            Assert.IsFalse(response.Status);
            Assert.AreEqual("Tên công ty không được để trống.", response.Message);
        }

        [TestMethod]
        public async Task CreateTourCompany_ReturnsBadRequest_WhenUserIdIsEmpty()
        {
            // Arrange
            var request = new CreateTourCompanyRequest
            {
                CompanynName = "Test Company",
                UserId = Guid.Empty
            };

            // Act
            var result = await _controller.CreateTourCompany(request);

            // Assert
            var badRequestResult = result as BadRequestObjectResult;
            Assert.IsNotNull(badRequestResult);
            Assert.AreEqual(400, badRequestResult.StatusCode);

            var response = badRequestResult.Value as ResponseVM;
            Assert.IsNotNull(response);
            Assert.IsFalse(response.Status);
            Assert.AreEqual("Quản lý công ty không được để trống!", response.Message);
        }

        [TestMethod]
        public async Task CreateTourCompany_ReturnsInternalServerError_WhenExceptionOccurs()
        {
            // Arrange
            var request = new CreateTourCompanyRequest
            {
                CompanynName = "Test Company",
                UserId = Guid.NewGuid()
            };

            _mockTourCompanyService.Setup(s => s.AddTourCompanyAsync(It.IsAny<Data.Models.TourCompany>()))
                .ThrowsAsync(new Exception("Test error message"));

            // Act
            var result = await _controller.CreateTourCompany(request);

            // Assert
            var statusCodeResult = result as ObjectResult;
            Assert.IsNotNull(statusCodeResult);
            Assert.AreEqual(500, statusCodeResult.StatusCode);
        }
        [TestMethod]
        public async Task UpdateTourCompany_ReturnsOk_WhenValidRequest()
        {
            // Arrange
            var tourCompanyId = Guid.NewGuid();
            var request = new UpdateTourCompanyRequest
            {
                TourCompanyId = tourCompanyId,
                CompanynName = "Updated Company",
                UserId = Guid.NewGuid()
            };

            var existingCompany = new Data.Models.TourCompany
            {
                TourCompanyId = tourCompanyId,
                CompanynName = "Old Name"
            };

            _mockTourCompanyService.Setup(s => s.GetTourCompany_Admin(tourCompanyId))
                .ReturnsAsync(existingCompany);

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<UpdateTourCompanyRequest, Data.Models.TourCompany>();
                cfg.CreateMap<Data.Models.TourCompany, TourCompanyDTO>();
            });
            var mapper = config.CreateMapper();
            _controller = new TourCompanyController(_mockTourCompanyService.Object, _mockAccountService.Object, mapper);

            // Act
            var result = await _controller.UpdateTourCompany(request);

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            var response = okResult.Value as TourCompanyDTO;
            Assert.IsNotNull(response);
        }

        [TestMethod]
        public async Task UpdateTourCompany_ReturnsBadRequest_WhenCompanyIdIsEmpty()
        {
            // Arrange
            var request = new UpdateTourCompanyRequest
            {
                TourCompanyId = Guid.Empty,
                CompanynName = "Test Company",
                UserId = Guid.NewGuid()
            };

            // Act
            var result = await _controller.UpdateTourCompany(request);

            // Assert
            var badRequestResult = result as BadRequestObjectResult;
            Assert.IsNotNull(badRequestResult);
            var response = badRequestResult.Value as ResponseVM;
            Assert.IsNotNull(response);
            Assert.IsFalse(response.Status);
            Assert.AreEqual("Tour Company Id không hợp lệ.", response.Message);
        }

        [TestMethod]
        public async Task UpdateTourCompany_ReturnsBadRequest_WhenCompanyNameIsEmpty()
        {
            // Arrange
            var request = new UpdateTourCompanyRequest
            {
                TourCompanyId = Guid.NewGuid(),
                CompanynName = "",
                UserId = Guid.NewGuid()
            };

            // Act
            var result = await _controller.UpdateTourCompany(request);

            // Assert
            var badRequestResult = result as BadRequestObjectResult;
            Assert.IsNotNull(badRequestResult);
            var response = badRequestResult.Value as ResponseVM;
            Assert.IsNotNull(response);
            Assert.IsFalse(response.Status);
            Assert.AreEqual("Tên công ty không được để trống.", response.Message);
        }

        [TestMethod]
        public async Task UpdateTourCompany_ReturnsBadRequest_WhenUserIdIsEmpty()
        {
            // Arrange
            var request = new UpdateTourCompanyRequest
            {
                TourCompanyId = Guid.NewGuid(),
                CompanynName = "Test Company",
                UserId = Guid.Empty
            };

            // Act
            var result = await _controller.UpdateTourCompany(request);

            // Assert
            var badRequestResult = result as BadRequestObjectResult;
            Assert.IsNotNull(badRequestResult);
            var response = badRequestResult.Value as ResponseVM;
            Assert.IsNotNull(response);
            Assert.IsFalse(response.Status);
            Assert.AreEqual("Quản lý công ty không được để trống!", response.Message);
        }

        [TestMethod]
        public async Task UpdateTourCompany_ReturnsNotFound_WhenCompanyDoesNotExist()
        {
            // Arrange
            var request = new UpdateTourCompanyRequest
            {
                TourCompanyId = Guid.NewGuid(),
                CompanynName = "Test Company",
                UserId = Guid.NewGuid()
            };

            _mockTourCompanyService.Setup(s => s.GetTourCompany_Admin(request.TourCompanyId))
                .ReturnsAsync((Data.Models.TourCompany)null);

            // Act
            var result = await _controller.UpdateTourCompany(request);

            // Assert
            var notFoundResult = result as NotFoundObjectResult;
            Assert.IsNotNull(notFoundResult);
            var response = notFoundResult.Value as ResponseVM;
            Assert.IsNotNull(response);
            Assert.IsFalse(response.Status);
            Assert.AreEqual("Không tìm thấy Tour Company.", response.Message);
        }

        [TestMethod]
        public async Task UpdateTourCompany_ReturnsInternalServerError_WhenExceptionOccurs()
        {
            // Arrange
            var request = new UpdateTourCompanyRequest
            {
                TourCompanyId = Guid.NewGuid(),
                CompanynName = "Test Company",
                UserId = Guid.NewGuid()
            };

            _mockTourCompanyService.Setup(s => s.GetTourCompany_Admin(request.TourCompanyId))
                .ThrowsAsync(new Exception("Test error message"));

            // Act
            var result = await _controller.UpdateTourCompany(request);

            // Assert
            var statusCodeResult = result as ObjectResult;
            Assert.IsNotNull(statusCodeResult);
            Assert.AreEqual(500, statusCodeResult.StatusCode);
            var response = statusCodeResult.Value as ResponseVM;
            Assert.IsNotNull(response);
            Assert.IsFalse(response.Status);
            Assert.AreEqual("Test error message", response.Message);
        }
        [TestMethod]
        public async Task GetUnassignedTourCompanies_ReturnsOk_WhenSuccessful()
        {
            // Arrange
            var mockUnassignedCompanies = new List<Data.Models.Account>
            {
               new Data.Models.Account
                {
                    Id = Guid.NewGuid(),
                    Fullname = "Test User 1",
                    Email = "test1@example.com",
                    isAccountActive = true
                },
                new Data.Models.Account
                {
                    Id = Guid.NewGuid(),
                    Fullname = "Test User 2",
                    Email = "test2@example.com",
                    isAccountActive = true
                }
            };

            _mockAccountService.Setup(service => service.GetUnassignedTourCompaniesAsync())
                .ReturnsAsync(mockUnassignedCompanies);

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Data.Models.Account, UserUnassignedTourCompany>();
            });
            var mapper = config.CreateMapper();
            _controller = new TourCompanyController(_mockTourCompanyService.Object, _mockAccountService.Object, mapper);

            // Act
            var result = await _controller.GetUnassignedTourCompanies();

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            Assert.AreEqual(200, okResult.StatusCode);

            var response = okResult.Value as IEnumerable<UserUnassignedTourCompany>;
            Assert.IsNotNull(response);
            Assert.AreEqual(2, response.Count());
        }

        [TestMethod]
        public async Task GetUnassignedTourCompanies_ReturnsInternalServerError_WhenExceptionOccurs()
        {
            // Arrange
            _mockAccountService.Setup(service => service.GetUnassignedTourCompaniesAsync())
                .ThrowsAsync(new Exception("Test error message"));

            // Act
            var result = await _controller.GetUnassignedTourCompanies();

            // Assert
            var statusCodeResult = result as ObjectResult;
            Assert.IsNotNull(statusCodeResult);
            Assert.AreEqual(500, statusCodeResult.StatusCode);

            var response = statusCodeResult.Value as ResponseVM;
            Assert.IsNotNull(response);
            Assert.IsFalse(response.Status);
            Assert.AreEqual("Test error message", response.Message);
        }
    }
}
