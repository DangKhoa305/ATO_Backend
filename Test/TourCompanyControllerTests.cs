using ATO_API.Controllers;
using AutoMapper;
using Data.DTO.Respone;
using Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Service.AgriculturalTourPackageSer;
using Service.TourCompanySer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [TestClass]
    public class TourCompanyControllerTests
    {
        private Mock<ITourCompanyService> _mockTourCompanyService;
        private Mock<IAgriculturalTourPackageService> _mockPackageService;
        private Mock<IMapper> _mockMapper;
        private TourCompanyController _controller;

        [TestInitialize]
        public void Setup()
        {
            _mockTourCompanyService = new Mock<ITourCompanyService>();
            _mockPackageService = new Mock<IAgriculturalTourPackageService>();
            _mockMapper = new Mock<IMapper>();

            _controller = new TourCompanyController(
                _mockTourCompanyService.Object,
                _mockPackageService.Object,
                _mockMapper.Object
            );
        }
        [TestMethod]
        public async Task ListTourCompany_ReturnsOk_WithValidData()
        {
            // Arrange
            var companies = new List<TourCompany>
            {
                new TourCompany
                {
                    TourCompanyId = Guid.NewGuid(),
                    CompanynName = "Green Tours",
                    EmailCompany = "green@tours.com",
                    CreateDate = DateTime.Now
                },
                new TourCompany
                {
                    TourCompanyId = Guid.NewGuid(),
                    CompanynName = "Eco Travel",
                    EmailCompany = "eco@travel.com",
                    CreateDate = DateTime.Now
                }
            };

            var companyDTOs = new List<TourCompanyDTO_Guest>
            {
                new TourCompanyDTO_Guest { CompanynName = "Green Tours", EmailCompany = "green@tours.com" },
                new TourCompanyDTO_Guest { CompanynName = "Eco Travel", EmailCompany = "eco@travel.com" }
            };

            _mockTourCompanyService.Setup(s => s.GetListTourCompanies_Admin()).ReturnsAsync(companies);
            _mockMapper.Setup(m => m.Map<List<TourCompanyDTO_Guest>>(companies)).Returns(companyDTOs);

            // Act
            var result = await _controller.ListTourCompany() as OkObjectResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.StatusCode);
            var actual = result.Value as List<TourCompanyDTO_Guest>;
            Assert.AreEqual(2, actual.Count);
            Assert.AreEqual("Green Tours", actual[0].CompanynName);
            Assert.AreEqual("eco@travel.com", actual[1].EmailCompany);
        }
        [TestMethod]
        public async Task ListTourCompany_Returns500_WhenExceptionThrown()
        {
            // Arrange
            _mockTourCompanyService.Setup(s => s.GetListTourCompanies_Admin())
                .ThrowsAsync(new Exception("Unexpected error"));

            // Act
            var result = await _controller.ListTourCompany() as ObjectResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(500, result.StatusCode);
            var response = result.Value as ResponseVM;
            Assert.IsFalse(response.Status);
            Assert.AreEqual("Unexpected error", response.Message);
        }
        [TestMethod]
        public async Task GetTourCompany_ReturnsOk_WithValidData()
        {
            // Arrange
            var companyId = Guid.NewGuid();

            var tourCompany = new TourCompany
            {
                TourCompanyId = companyId,
                CompanynName = "Green Travel",
                EmailCompany = "green@travel.com",
                CreateDate = DateTime.Now
            };

            var tourCompanyDTO = new TourCompanyDTO_Guest
            {
                CompanynName = "Green Travel",
                EmailCompany = "green@travel.com"
            };

            _mockTourCompanyService
                .Setup(s => s.GetTourCompany_Admin(companyId))
                .ReturnsAsync(tourCompany);

            _mockMapper
                .Setup(m => m.Map<TourCompanyDTO_Guest>(tourCompany))
                .Returns(tourCompanyDTO);

            // Act
            var result = await _controller.GetTourCompany(companyId) as OkObjectResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.StatusCode);
            var actual = result.Value as TourCompanyDTO_Guest;
            Assert.IsNotNull(actual);
            Assert.AreEqual("Green Travel", actual.CompanynName);
            Assert.AreEqual("green@travel.com", actual.EmailCompany);
        }
        [TestMethod]
        public async Task GetTourCompany_Returns500_WhenExceptionThrown()
        {
            // Arrange
            var companyId = Guid.NewGuid();

            _mockTourCompanyService
                .Setup(s => s.GetTourCompany_Admin(companyId))
                .ThrowsAsync(new Exception("Unexpected error"));

            // Act
            var result = await _controller.GetTourCompany(companyId) as ObjectResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(500, result.StatusCode);
            var response = result.Value as ResponseVM;
            Assert.IsFalse(response.Status);
            Assert.AreEqual("Unexpected error", response.Message);
        }
        [TestMethod]
        public async Task GetAgriculturalTourPackages_ReturnsOk_WithValidData()
        {
            // Arrange
            var companyId = Guid.NewGuid();

            var tourPackages = new List<AgriculturalTourPackage>
            {
                new AgriculturalTourPackage
                {
                    TourId = Guid.NewGuid(),
                    TourCompanyId = companyId
                },
                new AgriculturalTourPackage
                {
                    TourId = Guid.NewGuid(),
                    TourCompanyId = companyId
                }
            };

            var mappedList = new List<AgriculturalTourPackageRespone_Guest>
            {
                new AgriculturalTourPackageRespone_Guest { TourId = tourPackages[0].TourId },
                new AgriculturalTourPackageRespone_Guest { TourId = tourPackages[1].TourId }
            };

            _mockPackageService
                .Setup(s => s.GetListAgriculturalTourPackages_Guest())
                .ReturnsAsync(tourPackages);

            _mockMapper
                .Setup(m => m.Map<List<AgriculturalTourPackageRespone_Guest>>(It.IsAny<List<AgriculturalTourPackage>>()))
                .Returns(mappedList);

            _mockPackageService
                .Setup(s => s.GetPeople(It.IsAny<Guid>()))
                .ReturnsAsync(10); // Mock People count

            // Act
            var result = await _controller.GetAgriculturalTourPackages(companyId) as OkObjectResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.StatusCode);
            var data = result.Value as List<AgriculturalTourPackageRespone_Guest>;
            Assert.IsNotNull(data);
            Assert.AreEqual(2, data.Count);
            Assert.IsTrue(data.All(d => d.People == 10));
        }
        [TestMethod]
        public async Task GetAgriculturalTourPackages_Returns500_WhenExceptionThrown()
        {
            // Arrange
            var companyId = Guid.NewGuid();

            _mockPackageService
                .Setup(s => s.GetListAgriculturalTourPackages_Guest())
                .ThrowsAsync(new Exception("Something went wrong"));

            // Act
            var result = await _controller.GetAgriculturalTourPackages(companyId) as ObjectResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(500, result.StatusCode);
            var response = result.Value as ResponseVM;
            Assert.IsFalse(response.Status);
            Assert.AreEqual("Something went wrong", response.Message);
        }

    }
}
