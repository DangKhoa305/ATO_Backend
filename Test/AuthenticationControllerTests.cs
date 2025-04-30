using ATO_API.Controllers;
using ATO_API.Helper;
using AutoMapper;
using Data.DTO.Request;
using Data.DTO.Respone;
using Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Nest;
using Service.AccountSer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [TestClass]
    public class AuthenticationControllerTests
    {
        private Mock<UserManager<Account>> _mockUserManager;
        private Mock<RoleManager<IdentityRole<Guid>>> _mockRoleManager;
        private Mock<IConfiguration> _mockConfiguration;
        private Mock<IAccountService> _mockAccountService;
        private Mock<IMemoryCache> _mockCache;
        private Mock<TokenHelper> _mockTokenHelper;
        private Mock<IMapper> _mockMapper;
        private AuthenticationController _controller;

        [TestInitialize]
        public void Setup()
        {
            _mockUserManager = MockUserManager<Account>();
            _mockRoleManager = MockRoleManager();
            _mockConfiguration = new Mock<IConfiguration>();
            _mockAccountService = new Mock<IAccountService>();
            _mockCache = new Mock<IMemoryCache>();
            _mockTokenHelper = new Mock<TokenHelper>(_mockConfiguration.Object);
            _mockMapper = new Mock<IMapper>();

            _controller = new AuthenticationController(
                _mockUserManager.Object,
                _mockRoleManager.Object,
                _mockConfiguration.Object,
                _mockAccountService.Object,
                _mockCache.Object,
                _mockTokenHelper.Object,
                _mockMapper.Object
            );
        }

        // Mock UserManager helper
        private static Mock<UserManager<T>> MockUserManager<T>() where T : class
        {
            var store = new Mock<IUserStore<T>>();
            return new Mock<UserManager<T>>(store.Object, null, null, null, null, null, null, null, null);
        }

        // Mock RoleManager helper
        private static Mock<RoleManager<IdentityRole<Guid>>> MockRoleManager()
        {
            var store = new Mock<IRoleStore<IdentityRole<Guid>>>();
            return new Mock<RoleManager<IdentityRole<Guid>>>(store.Object, null, null, null, null);
        }
        [TestMethod]
        public async Task Login_ReturnsBadRequest_WhenInvalidCredentials()
        {
            // Arrange
            var loginDto = new LoginDTO { Username = "wronguser", Password = "WrongPass" };
            var expectedResponse = new ResponseLogin
            {
                ErrorMessage = "Tên đăng nhập hoặc mật khẩu không đúng!"
            };

            _mockAccountService
                .Setup(x => x.LoginAsync(It.IsAny<LoginDTO>()))
                .ReturnsAsync(expectedResponse);

            // Act
            var result = await _controller.Login(loginDto) as BadRequestObjectResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(400, result.StatusCode);
            var data = result.Value as ResponseVM;
            Assert.IsFalse(data.Status);
            Assert.AreEqual("Tên đăng nhập hoặc mật khẩu không đúng!", data.Message);
        }


        [TestMethod]
        public async Task Login_ReturnsInternalServerError_OnException()
        {
            // Arrange
            var loginDto = new LoginDTO { Username = "error", Password = "error" };

            _mockAccountService
                .Setup(x => x.LoginAsync(It.IsAny<LoginDTO>()))
                .ThrowsAsync(new Exception("Unexpected error"));

            // Act
            var result = await _controller.Login(loginDto) as ObjectResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(500, result.StatusCode);
            var data = result.Value as ResponseVM;
            Assert.IsFalse(data.Status);
            Assert.AreEqual("Đã sảy ra lỗi, vui lòng thử lại sau!", data.Message);
        }
        [TestMethod]
        public async Task SignUp_ReturnsSuccess_WhenValidRequest()
        {
            // Arrange
            var request = new CreateAccountRequest
            {
                Email = "test@example.com",
                PhoneNumber = "0912345678",
                UserName = "newuser",
                Password = "Test@123",
                Role = Guid.NewGuid()
            };

            var account = new Account { Email = request.Email };

            _mockAccountService.Setup(x => x.AnyAccountByEmailAsync(request.Email)).ReturnsAsync(false);
            _mockAccountService.Setup(x => x.AnyAccountByPhoneAsync(request.PhoneNumber)).ReturnsAsync(false);
            _mockAccountService.Setup(x => x.AnyAccountByUsernameAsync(request.UserName)).ReturnsAsync(false);
            _mockMapper.Setup(x => x.Map<Account>(request)).Returns(account);
            _mockAccountService.Setup(x => x.AddAccountAsync(It.IsAny<Account>())).Returns(Task.CompletedTask);

            var identityRole = new IdentityRole<Guid> { Id = request.Role, Name = "User" };
            var roles = new List<IdentityRole<Guid>> { identityRole }.AsQueryable();

            var roleDbSet = new Mock<Microsoft.EntityFrameworkCore.DbSet<IdentityRole<Guid>>>();
            roleDbSet.As<IQueryable<IdentityRole<Guid>>>().Setup(m => m.Provider).Returns(roles.Provider);
            roleDbSet.As<IQueryable<IdentityRole<Guid>>>().Setup(m => m.Expression).Returns(roles.Expression);
            roleDbSet.As<IQueryable<IdentityRole<Guid>>>().Setup(m => m.ElementType).Returns(roles.ElementType);
            roleDbSet.As<IQueryable<IdentityRole<Guid>>>().Setup(m => m.GetEnumerator()).Returns(roles.GetEnumerator());

            _mockRoleManager.Setup(r => r.Roles).Returns(roleDbSet.Object);
            _mockUserManager.Setup(x => x.AddToRoleAsync(It.IsAny<Account>(), "User")).ReturnsAsync(IdentityResult.Success);

            // Act
            var result = await _controller.SignUp(request) as OkObjectResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.StatusCode);
        }

        [TestMethod]
        public async Task SignUp_ReturnsError_WhenEmailIsInvalid()
        {
            // Arrange
            var request = new CreateAccountRequest
            {
                Email = "invalidemail",
                PhoneNumber = "0912345678",
                UserName = "user123",
                Password = "Test@123",
                Role = Guid.NewGuid()
            };

            // Act
            var result = await _controller.SignUp(request) as OkObjectResult;

            // Assert
            Assert.IsNotNull(result);
            var response = result.Value as ResponseModel;
            Assert.AreEqual("Email không hợp lệ. Vui lòng nhập đúng định dạng.", response.Message);
        }
        [TestMethod]
        public async Task SignUp_ReturnsError_WhenPhoneNumberIsInvalid()
        {
            // Arrange
            var request = new CreateAccountRequest
            {
                Email = "test@example.com",
                PhoneNumber = "abc123", 
                UserName = "user123",
                Password = "Test@123",
                Role = Guid.NewGuid()
            };

            // Act
            var result = await _controller.SignUp(request) as OkObjectResult;

            // Assert
            Assert.IsNotNull(result);
            var response = result.Value as ResponseModel;
            Assert.AreEqual("Số điện thoại không hợp lệ. Vui lòng nhập đúng định dạng.", response.Message);
        }
        [TestMethod]
        public async Task SignUp_ReturnsError_WhenEmailAlreadyExists()
        {
            // Arrange
            var request = new CreateAccountRequest
            {
                Email = "test@example.com",
                PhoneNumber = "0912345678",
                UserName = "user123",
                Password = "Test@123",
                Role = Guid.NewGuid()
            };

            _mockAccountService.Setup(x => x.AnyAccountByEmailAsync(request.Email)).ReturnsAsync(true);

            // Act
            var result = await _controller.SignUp(request) as OkObjectResult;

            // Assert
            Assert.IsNotNull(result);
            var response = result.Value as ResponseModel;
            Assert.AreEqual("Email đã tồn tại trong hệ thống.", response.Message);
        }
        [TestMethod]
        public async Task SignUp_ReturnsError_WhenPhoneNumberAlreadyExists()
        {
            // Arrange
            var request = new CreateAccountRequest
            {
                Email = "test@example.com",
                PhoneNumber = "0912345678",
                UserName = "user123",
                Password = "Test@123",
                Role = Guid.NewGuid()
            };

            _mockAccountService.Setup(x => x.AnyAccountByEmailAsync(request.Email)).ReturnsAsync(false);
            _mockAccountService.Setup(x => x.AnyAccountByPhoneAsync(request.PhoneNumber)).ReturnsAsync(true);

            // Act
            var result = await _controller.SignUp(request) as OkObjectResult;

            // Assert
            Assert.IsNotNull(result);
            var response = result.Value as ResponseModel;
            Assert.AreEqual("Số điện thoại đã tồn tại trong hệ thống.", response.Message);
        }
        [TestMethod]
        public async Task SignUp_ReturnsError_WhenUsernameAlreadyExists()
        {
            // Arrange
            var request = new CreateAccountRequest
            {
                Email = "test@example.com",
                PhoneNumber = "0912345678",
                UserName = "user123",
                Password = "Test@123",
                Role = Guid.NewGuid()
            };

            _mockAccountService.Setup(x => x.AnyAccountByEmailAsync(request.Email)).ReturnsAsync(false);
            _mockAccountService.Setup(x => x.AnyAccountByPhoneAsync(request.PhoneNumber)).ReturnsAsync(false);
            _mockAccountService.Setup(x => x.AnyAccountByUsernameAsync(request.UserName)).ReturnsAsync(true);

            // Act
            var result = await _controller.SignUp(request) as OkObjectResult;

            // Assert
            Assert.IsNotNull(result);
            var response = result.Value as ResponseModel;
            Assert.AreEqual("User name đã tồn tại trong hệ thống.", response.Message);
        }
        [TestMethod]
        public async Task ForgotPasswordSendOTP_ReturnsOk_WhenSuccess()
        {
            // Arrange
            var model = new ForgotPassword_Request_DTO
            {
                username = "test@example.com"
            };

            var response = new ResponseVM_Email
            {
                Status = true,
                Message = "OTP đã được gửi thành công.",
                toEmail = "test@example.com"
            };

            _mockAccountService.Setup(x => x.ForgotPasswordSendOTPAsync(model.username)).ReturnsAsync(response);

            // Act
            var result = await _controller.ForgotPasswordSendOTP(model) as OkObjectResult;

            // Assert
            Assert.IsNotNull(result);
            var responseModel = result.Value as ResponseVM_Email;
            Assert.AreEqual(200, result.StatusCode);
            Assert.IsTrue(responseModel!.Status);
            Assert.AreEqual("OTP đã được gửi thành công.", responseModel.Message);
            Assert.AreEqual("test@example.com", responseModel.toEmail);
        }
        [TestMethod]
        public async Task ForgotPasswordSendOTP_ReturnsBadRequest_WhenEmailNotFound()
        {
            // Arrange
            var model = new ForgotPassword_Request_DTO
            {
                username = "notfound@example.com"
            };

            var response = new ResponseVM_Email
            {
                Status = false,
                Message = "Email không tồn tại trong hệ thống.",
                toEmail = "notfound@example.com"
            };

            _mockAccountService.Setup(x => x.ForgotPasswordSendOTPAsync(model.username)).ReturnsAsync(response);

            // Act
            var result = await _controller.ForgotPasswordSendOTP(model) as BadRequestObjectResult;

            // Assert
            Assert.IsNotNull(result);
            var responseModel = result.Value as ResponseVM_Email;
            Assert.AreEqual(400, result.StatusCode);
            Assert.IsFalse(responseModel!.Status);
            Assert.AreEqual("Email không tồn tại trong hệ thống.", responseModel.Message);
            Assert.AreEqual("notfound@example.com", responseModel.toEmail);
        }
        [TestMethod]
        public async Task ForgotPasswordSendOTP_ReturnsInternalServerError_WhenExceptionOccurs()
        {
            // Arrange
            var model = new ForgotPassword_Request_DTO
            {
                username = "test@example.com"
            };

            _mockAccountService.Setup(x => x.ForgotPasswordSendOTPAsync(model.username)).ThrowsAsync(new Exception("Some internal error"));

            // Act
            var result = await _controller.ForgotPasswordSendOTP(model) as ObjectResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(500, result.StatusCode);
            var responseModel = result.Value as ResponseVM;
            Assert.IsFalse(responseModel!.Status);
            Assert.AreEqual("Đã sảy ra lỗi, vui lòng thử lại sau!", responseModel.Message);
        }
        [TestMethod]
        public async Task ForgotPassword_ReturnsOk_WhenPasswordChangeIsSuccessful()
        {
            // Arrange
            var model = new ForgotPassword_DTO
            {
                username = "testuser@example.com",
                NewPassword = "NewPassword@123"
            };

            var resultFromService = new ResponseVM
            {
                Status = true,
                Message = "Password changed successfully"
            };

            // Setup the mock service to return success
            _mockAccountService.Setup(x => x.ForgotPasswordAsync(It.IsAny<ForgotPassword_DTO>()))
                               .ReturnsAsync(resultFromService);

            // Act
            var result = await _controller.ForgotPassword(model) as OkObjectResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.StatusCode);
            var response = result.Value as ResponseVM;
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Status);
            Assert.AreEqual("Password changed successfully", response.Message);
        }

        [TestMethod]
        public async Task ForgotPassword_ReturnsBadRequest_WhenPasswordChangeFails()
        {
            // Arrange
            var model = new ForgotPassword_DTO
            {
                username = "testuser@example.com",
                NewPassword = "NewPassword@123"
            };

            var resultFromService = new ResponseVM
            {
                Status = false,
                Message = "Password change failed"
            };

            // Setup the mock service to return failure
            _mockAccountService.Setup(x => x.ForgotPasswordAsync(It.IsAny<ForgotPassword_DTO>()))
                               .ReturnsAsync(resultFromService);

            // Act
            var result = await _controller.ForgotPassword(model) as BadRequestObjectResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(400, result.StatusCode);
            var response = result.Value as ResponseVM;
            Assert.IsNotNull(response);
            Assert.IsFalse(response.Status);
            Assert.AreEqual("Password change failed", response.Message);
        }

        [TestMethod]
        public async Task ForgotPassword_ReturnsInternalServerError_WhenExceptionIsThrown()
        {
            // Arrange
            var model = new ForgotPassword_DTO
            {
                username = "testuser@example.com",
                NewPassword = "NewPassword@123"
            };

            // Setup the mock service to throw an exception
            _mockAccountService.Setup(x => x.ForgotPasswordAsync(It.IsAny<ForgotPassword_DTO>()))
                               .ThrowsAsync(new Exception("Something went wrong"));

            // Act
            var result = await _controller.ForgotPassword(model) as ObjectResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(500, result.StatusCode);
            var response = result.Value as ResponseVM;
            Assert.IsNotNull(response);
            Assert.IsFalse(response.Status);
            Assert.AreEqual("Đã sảy ra lỗi, vui lòng thử lại sau!", response.Message);
        }
    }
}
