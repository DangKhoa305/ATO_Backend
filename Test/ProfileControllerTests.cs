using ATO_API.Controllers;
using AutoMapper;
using Data.DTO.Request;
using Data.DTO.Respone;
using Data.DTO.Response;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Service.AccountSer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [TestClass]
    public class ProfileControllerTests
    {
        private Mock<IAccountService> _mockAccountService;
        private Mock<IMapper> _mockMapper;
        private ProfileController _controller;
        private readonly Guid _testUserId = Guid.NewGuid();

        [TestInitialize]
        public void Setup()
        {
            _mockAccountService = new Mock<IAccountService>();
            _mockMapper = new Mock<IMapper>();
            _controller = new ProfileController(_mockAccountService.Object, _mockMapper.Object);

            var user = new ClaimsPrincipal(new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.NameIdentifier, _testUserId.ToString())
            }, "mock"));

            _controller.ControllerContext = new ControllerContext
            {
                HttpContext = new DefaultHttpContext { User = user }
            };
        }

        [TestMethod]
        public async Task GetProfile_ReturnsOk_WhenUserExists()
        {
            // Arrange
            var account = new Account { Id = _testUserId, Fullname = "Test User" };
            var profile = new ProfileResponse { FullName = "Test User" };

            _mockAccountService.Setup(s => s.GetAccountByIdAsync(_testUserId)).ReturnsAsync(account);
            _mockMapper.Setup(m => m.Map<ProfileResponse>(account)).Returns(profile);

            // Act
            var result = await _controller.GetProfile() as OkObjectResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.StatusCode);
            Assert.IsInstanceOfType(result.Value, typeof(ProfileResponse));
        }

        [TestMethod]
        public async Task GetProfile_ReturnsNotFound_WhenUserIsNull()
        {
            _mockAccountService.Setup(s => s.GetAccountByIdAsync(_testUserId)).ReturnsAsync((Account)null);

            var result = await _controller.GetProfile() as NotFoundObjectResult;

            Assert.IsNotNull(result);
            Assert.AreEqual(404, result.StatusCode);
            var response = result.Value as ResponseVM;
            Assert.IsFalse(response.Status);
            Assert.AreEqual("User not found", response.Message);
        }

        [TestMethod]
        public async Task UpdateProfile_ReturnsOk_WhenUpdateIsSuccessful()
        {
            // Arrange
            var request = new UpdateProfileRequest
            {
                FullName = "Updated Name",
                PhoneNumber = "0123456789",
                AvatarURL = "avatar.jpg",
                Dob = new DateTime(2000, 1, 1)
            };

            var account = new Account { Id = _testUserId };
            var profile = new ProfileResponse { FullName = "Updated Name" };

            _mockAccountService.Setup(s => s.GetAccountByIdAsync(_testUserId)).ReturnsAsync(account);
            _mockAccountService.Setup(s => s.UpdateAccountAsync(account)).Returns(Task.CompletedTask);
            _mockMapper.Setup(m => m.Map<ProfileResponse>(account)).Returns(profile);

            // Act
            var result = await _controller.UpdateProfile(request) as OkObjectResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.StatusCode);
            Assert.IsInstanceOfType(result.Value, typeof(ProfileResponse));
        }

        [TestMethod]
        public async Task UpdateProfile_ReturnsNotFound_WhenUserIsNull()
        {
            _mockAccountService.Setup(s => s.GetAccountByIdAsync(_testUserId)).ReturnsAsync((Account)null);

            var result = await _controller.UpdateProfile(new UpdateProfileRequest()) as NotFoundObjectResult;

            Assert.IsNotNull(result);
            Assert.AreEqual(404, result.StatusCode);
            var response = result.Value as ResponseVM;
            Assert.IsFalse(response.Status);
            Assert.AreEqual("User not found", response.Message);
        }

        [TestMethod]
        public async Task ChangePassword_ReturnsOk_WhenSuccess()
        {
            // Arrange
            var model = new ChangePasswordModel("oldPassword", "newPassword");

            var expectedResponse = new ResponseModel(true, "Đổi mật khẩu thành công");

            _mockAccountService
                .Setup(s => s.ChangePassword(_testUserId.ToString(), model.CurrentPassword, model.NewPassword))
                .ReturnsAsync(expectedResponse);

            // Act
            var result = await _controller.ChangePassword(model) as OkObjectResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.StatusCode);
            var response = result.Value as ResponseModel;
            Assert.IsTrue(response.Status);
            Assert.AreEqual("Đổi mật khẩu thành công", response.Message);
        }

    }
}
