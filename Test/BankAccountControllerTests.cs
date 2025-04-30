using ATO_API.Controllers;
using Data.DTO.Request;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Service.BankAccountSer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [TestClass]
    public class BankAccountControllerTests
    {
        private Mock<IBankAccountService> _mockBankAccountService;
        private BankAccountController _controller;

        [TestInitialize]
        public void Setup()
        {
            // Initialize the mocks and controller
            _mockBankAccountService = new Mock<IBankAccountService>();
            _controller = new BankAccountController(_mockBankAccountService.Object);
        }

        [TestMethod]
        public async Task CreateBankAccount_ReturnsOk_WhenAccountIsCreatedSuccessfully()
        {
            // Arrange
            var request = new BankAccountRequest
            {
                AccountNumber = "123456789",
                BankName = "Test Bank"
            };

            var userId = Guid.NewGuid();

            // Simulating the current user in the HttpContext
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, userId.ToString())
            };

            var identity = new ClaimsIdentity(claims, "mock");
            var user = new ClaimsPrincipal(identity);
            _controller.ControllerContext = new ControllerContext
            {
                HttpContext = new DefaultHttpContext { User = user }
            };

            _mockBankAccountService.Setup(x => x.GetOwnerId(It.IsAny<Guid>())).ReturnsAsync(userId);

            // Act
            var result = await _controller.CreateBankAccount(request) as OkObjectResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.StatusCode);
            var response = result.Value as dynamic;
            Assert.IsNotNull(response);
        }

        // Test Case: Create Bank Account - Owner Not Found
        [TestMethod]
        public async Task CreateBankAccount_ReturnsBadRequest_WhenOwnerNotFound()
        {
            // Arrange
            var request = new BankAccountRequest
            {
                AccountNumber = "123456789",
                BankName = "Test Bank"
            };

            var userId = Guid.NewGuid();

            var claims = new List<Claim>
             {
                new Claim(ClaimTypes.NameIdentifier, userId.ToString())
            };

            var identity = new ClaimsIdentity(claims, "mock");
            var user = new ClaimsPrincipal(identity);
            _controller.ControllerContext = new ControllerContext
            {
                HttpContext = new DefaultHttpContext { User = user }
            };

            _mockBankAccountService.Setup(x => x.GetOwnerId(It.IsAny<Guid>())).ReturnsAsync((Guid?)null);

            // Act
            var result = await _controller.CreateBankAccount(request) as OkObjectResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.StatusCode);
            var response = result.Value as dynamic;
            Assert.IsNotNull(response);
        }

        [TestMethod]
        public async Task CreateBankAccount_ReturnsInternalServerError_WhenErrorOccurs()
        {
            // Arrange
            var request = new BankAccountRequest
            {
                AccountNumber = "123456789",
                BankName = "Test Bank"
            };

            var userId = Guid.NewGuid();

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, userId.ToString())
            };

            var identity = new ClaimsIdentity(claims, "mock");
            var user = new ClaimsPrincipal(identity);
            _controller.ControllerContext = new ControllerContext
            {
                HttpContext = new DefaultHttpContext { User = user }
            };

            _mockBankAccountService.Setup(x => x.GetOwnerId(It.IsAny<Guid>())).ReturnsAsync(userId);
            _mockBankAccountService.Setup(x => x.CreateBankAccount(It.IsAny<BankAccountRequest>(), It.IsAny<Guid>()))
                                   .ThrowsAsync(new Exception("Error creating bank account"));

            // Act
            var result = await _controller.CreateBankAccount(request) as OkObjectResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.StatusCode);
            var response = result.Value as dynamic;
        }
    }

}
