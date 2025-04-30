using ATO_API.Controllers;
using Data.DTO.Response;
using Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Service.AdminBalanceSer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [TestClass]
    public class AdminBalanceController_Test
    {
        private Mock<IAdminBalanceService> _mockBalanceService;
        private AdminBalanceController _controller;

        [TestInitialize]
        public void Setup()
        {
            _mockBalanceService = new Mock<IAdminBalanceService>();
            _controller = new AdminBalanceController(_mockBalanceService.Object);
        }

        [TestMethod]
        public async Task GetBalanceHistory_ReturnsOk_WithData()
        {
            // Arrange
            var mockHistory = new List<AdminBalanceHistoryResponse>
            {
                new AdminBalanceHistoryResponse
                {
                    TransactionId = Guid.NewGuid(),
                    Amount = 1500.00m,
                    Description = "Initial Deposit",
                    TransactionType = TransactionType.Withdrawal,
                    TransactionDate = DateTime.UtcNow,
                    OrderReference = "ORD123",
                    BookingReference = "BOOK456",
                    RunningBalance = 1500.00m
                },
                new AdminBalanceHistoryResponse
                {
                    TransactionId = Guid.NewGuid(),
                    Amount = -200.00m,
                    Description = "Booking Payment",
                    TransactionType = TransactionType.BookingPayment,
                    TransactionDate = DateTime.UtcNow,
                    OrderReference = "ORD124",
                    BookingReference = "BOOK457",
                    RunningBalance = 1300.00m
                }
            };

            _mockBalanceService.Setup(s => s.GetBalanceHistory())
                .Returns(Task.FromResult(mockHistory));

            // Act
            var result = await _controller.GetBalanceHistory();

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            Assert.AreEqual(200, okResult.StatusCode);
        }


        [TestMethod]
        public async Task GetCurrentBalance_ReturnsOk_WithBalance()
        {
            // Arrange
            decimal expectedBalance = 1000.50m;
            _mockBalanceService.Setup(s => s.GetCurrentBalance())
                .ReturnsAsync(expectedBalance);

            // Act
            var result = await _controller.GetCurrentBalance();

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            Assert.AreEqual(200, okResult.StatusCode);

        }
    }
}
