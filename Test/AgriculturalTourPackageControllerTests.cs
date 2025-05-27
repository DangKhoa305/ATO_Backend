using ATO_API.Controllers;
using AutoMapper;
using Data.DTO.Respone;
using Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Service;
using Service.AgriculturalTourPackageSer;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Test
{
    [TestClass]
    public class AgriculturalTourPackageControllerTests
    {
            private Mock<IAgriculturalTourPackageService> _mockService;
            private Mock<IGeneralService> _service;
            private Mock<IMapper> _mockMapper;
            private AgriculturalTourPackageController _controller;

            [TestInitialize]
            public void Setup()
            {
                _mockService = new Mock<IAgriculturalTourPackageService>();
                _mockMapper = new Mock<IMapper>();
                _service = new Mock<IGeneralService>();
            _controller = new AgriculturalTourPackageController(_mockMapper.Object, _mockService.Object, _service.Object);
            }

            [TestMethod]
            public async Task GetAgriculturalTourPackages_ReturnsOkResult_WithMappedData()
            {
                // Arrange
                var mockTourId = Guid.NewGuid();

                var fakeEntities = new List<AgriculturalTourPackage>
                {
                    new AgriculturalTourPackage { TourId = mockTourId }
                };

                // Fake mapped DTO from AutoMapper
                var mappedDtos = new List<AgriculturalTourPackageRespone_Guest>
                {
                    new AgriculturalTourPackageRespone_Guest
                    {
                        TourId = mockTourId,
                        PackageName = "Tour Experience",
                        Description = "A nice tour",
                        Slot = 20,
                        PriceOfAdults = 200000,
                        PriceOfChildren = 100000,
                        ChildTicketAge = "Under 12",
                        StartTime = DateTime.Today,
                        EndTime = DateTime.Today.AddDays(1),
                        Durations = 1,
                        DurationsType = TimeType.hour,
                        TourDestinations = new List<AgriculturalTourPackage_TourDestination_Respone>(),
                        TourGuides = new List<AgriculturalTourPackage_TourGuide_Respone>(),
                        People = 0 // Will be updated
                    }
                };

                _mockService.Setup(s => s.GetListAgriculturalTourPackages_Guest())
                    .ReturnsAsync(fakeEntities);

                _mockMapper.Setup(m => m.Map<List<AgriculturalTourPackageRespone_Guest>>(fakeEntities))
                    .Returns(mappedDtos);

                _mockService.Setup(s => s.GetPeople(mockTourId)).ReturnsAsync(15);

                // Act
                var result = await _controller.GetAgriculturalTourPackages();

                // Assert
                var okResult = result as OkObjectResult;
                Assert.IsNotNull(okResult);
                Assert.AreEqual(200, okResult.StatusCode);

                var data = okResult.Value as List<AgriculturalTourPackageRespone_Guest>;
                Assert.IsNotNull(data);
                Assert.AreEqual(1, data.Count);
                Assert.AreEqual(mockTourId, data[0].TourId);
                Assert.AreEqual(15, data[0].People);
                Assert.AreEqual("Tour Experience", data[0].PackageName);
            }
            [TestMethod]
            public async Task GetAgriculturalTourPackages_ReturnsInternalServerError_OnException()
            {
                // Arrange
                var mockTourId = Guid.NewGuid();

                // Fake entities to return from service
                var fakeEntities = new List<AgriculturalTourPackage>
                {
                    new AgriculturalTourPackage { TourId = mockTourId }
                };

                // Mock service to throw an exception
                _mockService.Setup(s => s.GetListAgriculturalTourPackages_Guest())
                    .ThrowsAsync(new Exception("Some internal error"));

                // Act
                var result = await _controller.GetAgriculturalTourPackages();

                // Assert
                var statusCodeResult = result as ObjectResult;
                Assert.IsNotNull(statusCodeResult);
                Assert.AreEqual(500, statusCodeResult.StatusCode);
                var response = statusCodeResult.Value as ResponseVM;
                Assert.IsFalse(response.Status);
                Assert.AreEqual("Some internal error", response.Message);
        }
        [TestMethod]
        public async Task GetAgriculturalTourPackage_ReturnsOkResult_WithValidData()
        {
            // Arrange
            var mockTourId = Guid.NewGuid();

            // Fake entity returned from service
            var fakeEntity = new AgriculturalTourPackage
            {
                TourId = mockTourId,
                PackageName = "Tour Experience",
                Description = "A nice tour",
                Slot = 20,
                PriceOfAdults = 200000,
                PriceOfChildren = 100000,
                ChildTicketAge = "Under 12",
                StartTime = DateTime.Today,
                EndTime = DateTime.Today.AddDays(1),
                Durations = 1,
                DurationsType = TimeType.hour
            };

            // Fake mapped DTO from AutoMapper
            var mappedDto = new AgriculturalTourPackageRespone
            {
                TourId = mockTourId,
                PackageName = "Tour Experience",
                Description = "A nice tour",
                Slot = 20,
                PriceOfAdults = 200000,
                PriceOfChildren = 100000,
                ChildTicketAge = "Under 12",
                StartTime = DateTime.Today,
                EndTime = DateTime.Today.AddDays(1),
                Durations = 1,
                DurationsType = TimeType.hour,
                TourDestinations = new List<AgriculturalTourPackage_TourDestination_Respone>(),
                TourGuides = new List<AgriculturalTourPackage_TourGuide_Respone>()
            };

            _mockService.Setup(s => s.GetAgriculturalTourPackage(mockTourId))
                .ReturnsAsync(fakeEntity);
            _mockMapper.Setup(m => m.Map<AgriculturalTourPackageRespone>(fakeEntity))
                .Returns(mappedDto);

            _mockService.Setup(s => s.GetPeople(mockTourId)).ReturnsAsync(15);

            // Act
            var result = await _controller.GetAgriculturalTourPackage(mockTourId);

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            Assert.AreEqual(200, okResult.StatusCode);

            var data = okResult.Value as AgriculturalTourPackageRespone;
            Assert.IsNotNull(data);
            Assert.AreEqual(mockTourId, data.TourId);
            Assert.AreEqual(15, data.People);
            Assert.AreEqual("Tour Experience", data.PackageName);
        }

        [TestMethod]
        public async Task GetAgriculturalTourPackage_ReturnsInternalServerError_OnException()
        {
            // Arrange
            var mockTourId = Guid.NewGuid();

            // Mock service to throw an exception
            _mockService.Setup(s => s.GetAgriculturalTourPackage(mockTourId))
                .ThrowsAsync(new Exception("Some internal error"));

            // Act
            var result = await _controller.GetAgriculturalTourPackage(mockTourId);

            // Assert
            var statusCodeResult = result as ObjectResult;
            Assert.IsNotNull(statusCodeResult);
            Assert.AreEqual(500, statusCodeResult.StatusCode);
            var response = statusCodeResult.Value as ResponseVM;
            Assert.IsFalse(response.Status);
            Assert.AreEqual("Some internal error", response.Message);
        }
        [TestMethod]
        public async Task GetTourDestination_ReturnsOkResult_WithValidData()
        {
            // Arrange
            var mockTourDestinationId = Guid.NewGuid();

            // Fake service response (returning a valid tour destination)
            var fakeDestination = new TourDestination
            {
                TourDestinationId = mockTourDestinationId,
                Title = "Beautiful Beach",
                Description = "A lovely beach destination",
                CreateDate = DateTime.Now.AddMonths(-1),
                UpdateDate = DateTime.Now,
                StartTime = DateTime.Now.AddDays(5),
                EndTime = DateTime.Now.AddDays(7),
                CheckInDate = DateTime.Now.AddDays(6),
                CheckOutDate = DateTime.Now.AddDays(8),
                VisitOrder = 1,
                TypeActivity = TypeActivity.Destination,
                StatusApproval = StatusApproval.Approved,
            };

            // Fake mapped response (DTO)
            var mappedDestination = new AgriculturalTourPackage_TourDestination_Respone
            {
                TourDestinationId = mockTourDestinationId,
                Title = "Beautiful Beach",
                Description = "A lovely beach destination",
                CreateDate = DateTime.Now.AddMonths(-1),
                UpdateDate = DateTime.Now,
                StartTime = DateTime.Now.AddDays(5),
                EndTime = DateTime.Now.AddDays(7),
                CheckInDate = DateTime.Now.AddDays(6),
                CheckOutDate = DateTime.Now.AddDays(8),
                VisitOrder = 1,
                TypeActivity = TypeActivity.Destination,
                StatusApproval = StatusApproval.Approved,
            };

            _mockService.Setup(s => s.GetTourDestination(mockTourDestinationId)).ReturnsAsync(fakeDestination);
            _mockMapper.Setup(m => m.Map<AgriculturalTourPackage_TourDestination_Respone>(fakeDestination))
                       .Returns(mappedDestination);

            // Act
            var result = await _controller.GetTourDestination(mockTourDestinationId);

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            Assert.AreEqual(200, okResult.StatusCode);

            var responseData = okResult.Value as AgriculturalTourPackage_TourDestination_Respone;
            Assert.IsNotNull(responseData);
        }


        [TestMethod]
        public async Task GetTourDestination_ReturnsInternalServerError_WhenExceptionOccurs()
        {
            // Arrange
            var mockTourDestinationId = Guid.NewGuid();

            // Simulate an exception being thrown by the service
            _mockService.Setup(s => s.GetTourDestination(mockTourDestinationId)).ThrowsAsync(new Exception("An unexpected error occurred"));

            // Act
            var result = await _controller.GetTourDestination(mockTourDestinationId);

            // Assert
            var internalServerErrorResult = result as ObjectResult;
            Assert.IsNotNull(internalServerErrorResult);
            Assert.AreEqual(500, internalServerErrorResult.StatusCode);

            var response = internalServerErrorResult.Value as ResponseVM;
            Assert.IsNotNull(response);
            Assert.AreEqual("An unexpected error occurred", response.Message);
        }
    }
}



