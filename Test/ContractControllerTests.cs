using ATO_API.Controllers;
using AutoMapper;
using Data.DTO.Request;
using Data.DTO.Respone;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Service.ContractSer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [TestClass]
    public class ContractControllerTests
    {
        private Mock<IContractService> _contractServiceMock;
        private Mock<IMapper> _mapperMock;
        private ContractController _controller;

        [TestInitialize]
        public void TestInitialize()
        {
            _contractServiceMock = new Mock<IContractService>();
            _mapperMock = new Mock<IMapper>();
            _controller = new ContractController(_contractServiceMock.Object, _mapperMock.Object);
        }

        [TestMethod]
        public async Task GetAllAsync_ReturnsOk_WithValidData()
        {
            // Arrange
            var userId = Guid.NewGuid();
            var mockResponse = new List<Contract>
            {
                new Contract {
                    ContractId = Guid.NewGuid(),
                    ContractContent = "Contract Content 1",
                    DiscountRate = 10,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddMonths(6),
                    SignedDate = null,
                    Status = false,
                    TourCompanyId = userId,
                    SigningStatus = SigningStatus.New
                },
                new Contract {
                    ContractId = Guid.NewGuid(),
                    ContractContent = "Contract Content 2",
                    DiscountRate = 15,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddMonths(12),
                    SignedDate = DateTime.Now,
                    Status = true,
                    TourCompanyId = userId,
                    SigningStatus = SigningStatus.Signed
                }
            };

            _contractServiceMock.Setup(service => service.ListContractTourCompany(It.IsAny<Guid>()))
            .ReturnsAsync(mockResponse);

            // Set user claims for testing
            var claims = new List<System.Security.Claims.Claim>
        {
            new System.Security.Claims.Claim(System.Security.Claims.ClaimTypes.NameIdentifier, userId.ToString())
        };
            var identity = new System.Security.Claims.ClaimsIdentity(claims);
            var principal = new System.Security.Claims.ClaimsPrincipal(identity);
            _controller.ControllerContext = new ControllerContext
            {
                HttpContext = new DefaultHttpContext { User = principal }
            };

            // Act
            var result = await _controller.GetAllAsync();

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
        }
        [TestMethod]
        public async Task GetAllAsync_ReturnsInternalServerError_WhenExceptionOccurs()
        {
            // Arrange
            _contractServiceMock.Setup(service => service.ListContract())
                .ThrowsAsync(new Exception("Test error message"));

            // Act
            var result = await _controller.GetAllAsync();

            // Assert
            var objectResult = result as ObjectResult;
            Assert.IsNotNull(objectResult);
            Assert.AreEqual(500, objectResult.StatusCode);

            var response = objectResult.Value as ResponseVM;
            Assert.IsNotNull(response);
            Assert.IsFalse(response.Status);
            Assert.AreEqual("Test error message", response.Message);
        }
        [TestMethod]
        public async Task GetFacilityContractAsync_ReturnsOk_WithValidData()
        {
            // Arrange
            var userId = Guid.NewGuid();
            var mockResponse = new List<Contract>
            {
                new Contract {
                    ContractId = Guid.NewGuid(),
                    ContractContent = "Facility Contract 1",
                    DiscountRate = 10,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddMonths(6),
                    TouristFacilityId = userId,
                    SigningStatus = SigningStatus.New
                },
                new Contract {
                    ContractId = Guid.NewGuid(),
                    ContractContent = "Facility Contract 2",
                    DiscountRate = 15,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddMonths(12),
                    TouristFacilityId = userId,
                    SigningStatus = SigningStatus.Signed
                }
            };

            _contractServiceMock.Setup(service => service.ListContractFacility(userId))
                .ReturnsAsync(mockResponse);

            // Set user claims
            var claims = new List<System.Security.Claims.Claim>
            {
                new System.Security.Claims.Claim(System.Security.Claims.ClaimTypes.NameIdentifier, userId.ToString())
            };
            var identity = new System.Security.Claims.ClaimsIdentity(claims);
            var principal = new System.Security.Claims.ClaimsPrincipal(identity);
            _controller.ControllerContext = new ControllerContext
            {
                HttpContext = new DefaultHttpContext { User = principal }
            };

            // Act
            var result = await _controller.GetFacilityContractAsync();

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            var returnValue = okResult.Value as List<Contract>;
            Assert.IsNotNull(returnValue);
            Assert.AreEqual(2, returnValue.Count);
        }

        [TestMethod]
        public async Task GetFacilityContractAsync_ReturnsInternalServerError_WhenExceptionOccurs()
        {
            // Arrange
            var userId = Guid.NewGuid();
            _contractServiceMock.Setup(service => service.ListContractFacility(It.IsAny<Guid>()))
                .ThrowsAsync(new Exception("Test error message"));

            // Set user claims
            var claims = new List<System.Security.Claims.Claim>
            {
                new System.Security.Claims.Claim(System.Security.Claims.ClaimTypes.NameIdentifier, userId.ToString())
            };
            var identity = new System.Security.Claims.ClaimsIdentity(claims);
            var principal = new System.Security.Claims.ClaimsPrincipal(identity);
            _controller.ControllerContext = new ControllerContext
            {
                HttpContext = new DefaultHttpContext { User = principal }
            };

            // Act
            var result = await _controller.GetFacilityContractAsync();

            // Assert
            var objectResult = result as ObjectResult;
            Assert.IsNotNull(objectResult);
            Assert.AreEqual(500, objectResult.StatusCode);

            var response = objectResult.Value as ResponseVM;
            Assert.IsNotNull(response);
            Assert.IsFalse(response.Status);
            Assert.AreEqual("Test error message", response.Message);
        }
        [TestMethod]
        public async Task GetCompanyContractAsync_ReturnsOk_WithValidData()
        {
            // Arrange
            var userId = Guid.NewGuid();
            var mockResponse = new List<Contract>
            {
                new Contract {
                    ContractId = Guid.NewGuid(),
                    ContractContent = "Company Contract 1",
                    DiscountRate = 10,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddMonths(6),
                    TourCompanyId = userId,
                    SigningStatus = SigningStatus.New
                },
                new Contract {
                    ContractId = Guid.NewGuid(),
                    ContractContent = "Company Contract 2",
                    DiscountRate = 15,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddMonths(12),
                    TourCompanyId = userId,
                    SigningStatus = SigningStatus.Signed
                }
            };

            _contractServiceMock.Setup(service => service.ListContractTourCompany(userId))
                .ReturnsAsync(mockResponse);

            // Set user claims
            var claims = new List<System.Security.Claims.Claim>
            {
                new System.Security.Claims.Claim(System.Security.Claims.ClaimTypes.NameIdentifier, userId.ToString())
            };
            var identity = new System.Security.Claims.ClaimsIdentity(claims);
            var principal = new System.Security.Claims.ClaimsPrincipal(identity);
            _controller.ControllerContext = new ControllerContext
            {
                HttpContext = new DefaultHttpContext { User = principal }
            };

            // Act
            var result = await _controller.GetCompanyContractAsync();

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            var returnValue = okResult.Value as List<Contract>;
            Assert.IsNotNull(returnValue);
            Assert.AreEqual(2, returnValue.Count);
        }

        [TestMethod]
        public async Task GetCompanyContractAsync_ReturnsInternalServerError_WhenExceptionOccurs()
        {
            // Arrange
            var userId = Guid.NewGuid();
            _contractServiceMock.Setup(service => service.ListContractTourCompany(It.IsAny<Guid>()))
                .ThrowsAsync(new Exception("Test error message"));

            // Set user claims
            var claims = new List<System.Security.Claims.Claim>
            {
                new System.Security.Claims.Claim(System.Security.Claims.ClaimTypes.NameIdentifier, userId.ToString())
            };
            var identity = new System.Security.Claims.ClaimsIdentity(claims);
            var principal = new System.Security.Claims.ClaimsPrincipal(identity);
            _controller.ControllerContext = new ControllerContext
            {
                HttpContext = new DefaultHttpContext { User = principal }
            };

            // Act
            var result = await _controller.GetCompanyContractAsync();

            // Assert
            var objectResult = result as ObjectResult;
            Assert.IsNotNull(objectResult);
            Assert.AreEqual(500, objectResult.StatusCode);

            var response = objectResult.Value as ResponseVM;
            Assert.IsNotNull(response);
            Assert.IsFalse(response.Status);
            Assert.AreEqual("Test error message", response.Message);
        }
        [TestMethod]
        public async Task GetAsync_ReturnsOk_WithValidId()
        {
            // Arrange
            var contractId = Guid.NewGuid();
            var mockContract = new Contract
            {
                ContractId = contractId,
                ContractContent = "Test Contract",
                DiscountRate = 10,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddMonths(6),
                SignedDate = null,
                Status = false,
                SigningStatus = SigningStatus.New
            };

            _contractServiceMock.Setup(service => service.GetContract(contractId))
                .ReturnsAsync(mockContract);

            // Act
            var result = await _controller.GetAsync(contractId);

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            var returnValue = okResult.Value as Contract;
            Assert.IsNotNull(returnValue);
            Assert.AreEqual(contractId, returnValue.ContractId);
        }

        [TestMethod]
        public async Task GetAsync_ReturnsInternalServerError_WhenExceptionOccurs()
        {
            // Arrange
            var contractId = Guid.NewGuid();
            _contractServiceMock.Setup(service => service.GetContract(contractId))
                .ThrowsAsync(new Exception("Test error message"));

            // Act
            var result = await _controller.GetAsync(contractId);

            // Assert
            var objectResult = result as ObjectResult;
            Assert.IsNotNull(objectResult);
            Assert.AreEqual(500, objectResult.StatusCode);

            var response = objectResult.Value as ResponseVM;
            Assert.IsNotNull(response);
            Assert.IsFalse(response.Status);
            Assert.AreEqual("Test error message", response.Message);
        }
        [TestMethod]
        public async Task AddContract_ReturnsOk_WithValidRequest()
        {
            // Arrange
            var request = new CreateContractRequest
            {
                ContractContent = "New Contract Content",
                DiscountRate = 10,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddMonths(6),
                TourCompanyId = Guid.NewGuid()
            };

            var mappedContract = new Contract
            {
                ContractId = Guid.NewGuid(),
                ContractContent = request.ContractContent,
                DiscountRate = request.DiscountRate,
                StartDate = request.StartDate,
                EndDate = request.EndDate,
                TourCompanyId = request.TourCompanyId,
                SigningStatus = SigningStatus.New
            };

            _mapperMock.Setup(m => m.Map<Contract>(request))
                .Returns(mappedContract);

            _contractServiceMock.Setup(s => s.AddContract(It.IsAny<Contract>()))
                .ReturnsAsync(true);

            // Act
            var result = await _controller.AddContract(request);

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            var returnValue = okResult.Value;
            Assert.IsNotNull(returnValue);
        }

        [TestMethod]
        public async Task AddContract_ReturnsInternalServerError_WhenExceptionOccurs()
        {
            // Arrange
            var request = new CreateContractRequest
            {
                ContractContent = "New Contract Content",
                DiscountRate = 10
            };

            _mapperMock.Setup(m => m.Map<Contract>(request))
                .Throws(new Exception("Test error message"));

            // Act
            var result = await _controller.AddContract(request);

            // Assert
            var objectResult = result as ObjectResult;
            Assert.IsNotNull(objectResult);
            Assert.AreEqual(500, objectResult.StatusCode);

            var response = objectResult.Value as ResponseVM;
            Assert.IsNotNull(response);
            Assert.IsFalse(response.Status);
            Assert.AreEqual("Test error message", response.Message);
        }
        [TestMethod]
        public async Task UpdateContract_ReturnsOk_WithValidRequest()
        {
            // Arrange
            var contractId = Guid.NewGuid();
            var userId = Guid.NewGuid();
            var request = new UpdateContractRequest
            {
                ContractContent = "Updated Contract Content",
                DiscountRate = 15,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddMonths(12)
            };

            var mappedContract = new Contract
            {
                ContractId = contractId,
                ContractContent = request.ContractContent,
                DiscountRate = request.DiscountRate,
                StartDate = request.StartDate,
                EndDate = request.EndDate
            };

            _mapperMock.Setup(m => m.Map<Contract>(request))
                .Returns(mappedContract);

            _contractServiceMock.Setup(s => s.UpdateContract(contractId, It.IsAny<Contract>()))
                .ReturnsAsync(true);

            // Set user claims
            var claims = new List<System.Security.Claims.Claim>
            {
                new System.Security.Claims.Claim(System.Security.Claims.ClaimTypes.NameIdentifier, userId.ToString())
            };
            var identity = new System.Security.Claims.ClaimsIdentity(claims);
            var principal = new System.Security.Claims.ClaimsPrincipal(identity);
            _controller.ControllerContext = new ControllerContext
            {
                HttpContext = new DefaultHttpContext { User = principal }
            };

            // Act
            var result = await _controller.UpdateContract(contractId, request);

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
        }

        [TestMethod]
        public async Task UpdateContract_ReturnsError_WhenExceptionOccurs()
        {
            // Arrange
            var contractId = Guid.NewGuid();
            var userId = Guid.NewGuid();
            var request = new UpdateContractRequest
            {
                ContractContent = "Updated Contract Content",
                DiscountRate = 15
            };

            _mapperMock.Setup(m => m.Map<Contract>(request))
                .Throws(new Exception("Test error message"));

            // Set user claims
            var claims = new List<System.Security.Claims.Claim>
            {
                new System.Security.Claims.Claim(System.Security.Claims.ClaimTypes.NameIdentifier, userId.ToString())
            };
            var identity = new System.Security.Claims.ClaimsIdentity(claims);
            var principal = new System.Security.Claims.ClaimsPrincipal(identity);
            _controller.ControllerContext = new ControllerContext
            {
                HttpContext = new DefaultHttpContext { User = principal }
            };

            // Act
            var result = await _controller.UpdateContract(contractId, request);

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            var response = okResult.Value as ResponseVM;
            Assert.IsNotNull(response);
            Assert.IsFalse(response.Status);
            Assert.AreEqual("Test error message", response.Message);
        }
        [TestMethod]
        public async Task SendOTP_ReturnsSuccess_WhenOTPSentSuccessfully()
        {
            // Arrange
            var contractId = Guid.NewGuid();
            _contractServiceMock.Setup(s => s.SendOTPAsync(contractId))
                .ReturnsAsync(true);

            // Act
            var result = await _controller.SendOTP(contractId);

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            var response = okResult.Value as ResponseVM;
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Status);
            Assert.AreEqual("Đã gửi mã OTP thành công", response.Message);
        }

        [TestMethod]
        public async Task SendOTP_ReturnsFailure_WhenOTPSendingFails()
        {
            // Arrange
            var contractId = Guid.NewGuid();
            _contractServiceMock.Setup(s => s.SendOTPAsync(contractId))
                .ReturnsAsync(false);

            // Act
            var result = await _controller.SendOTP(contractId);

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            var response = okResult.Value as ResponseVM;
            Assert.IsNotNull(response);
            Assert.IsFalse(response.Status);
            Assert.AreEqual("Không thể gửi mã OTP", response.Message);
        }

        [TestMethod]
        public async Task SendOTP_ReturnsError_WhenExceptionOccurs()
        {
            // Arrange
            var contractId = Guid.NewGuid();
            _contractServiceMock.Setup(s => s.SendOTPAsync(contractId))
                .ThrowsAsync(new Exception("Test error message"));

            // Act
            var result = await _controller.SendOTP(contractId);

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            var response = okResult.Value as ResponseVM;
            Assert.IsNotNull(response);
            Assert.IsFalse(response.Status);
            Assert.AreEqual("Test error message", response.Message);
        }
        [TestMethod]
        public async Task VerifyOtp_ReturnsSuccess_WhenOTPVerificationSucceeds()
        {
            // Arrange
            var contractId = Guid.NewGuid();
            var otpCode = "123456";
            _contractServiceMock.Setup(s => s.VerifyOtpAsync(contractId, otpCode))
                .ReturnsAsync(true);

            // Act
            var result = await _controller.VerifyOtp(contractId, otpCode);

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            var response = okResult.Value as ResponseVM;
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Status);
            Assert.AreEqual("Xác thực mã OTP thành công", response.Message);
        }

        [TestMethod]
        public async Task VerifyOtp_ReturnsFailure_WhenOTPVerificationFails()
        {
            // Arrange
            var contractId = Guid.NewGuid();
            var otpCode = "123456";
            _contractServiceMock.Setup(s => s.VerifyOtpAsync(contractId, otpCode))
                .ReturnsAsync(false);

            // Act
            var result = await _controller.VerifyOtp(contractId, otpCode);

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            var response = okResult.Value as ResponseVM;
            Assert.IsNotNull(response);
            Assert.IsFalse(response.Status);
            Assert.AreEqual("Mã OTP không chính xác", response.Message);
        }

        [TestMethod]
        public async Task VerifyOtp_ReturnsError_WhenExceptionOccurs()
        {
            // Arrange
            var contractId = Guid.NewGuid();
            var otpCode = "123456";
            _contractServiceMock.Setup(s => s.VerifyOtpAsync(contractId, otpCode))
                .ThrowsAsync(new Exception("Test error message"));

            // Act
            var result = await _controller.VerifyOtp(contractId, otpCode);

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            var response = okResult.Value as ResponseVM;
            Assert.IsNotNull(response);
            Assert.IsFalse(response.Status);
            Assert.AreEqual("Test error message", response.Message);
        }
        [TestMethod]
        public async Task SignContract_ReturnsOk_WhenSigningSucceeds()
        {
            // Arrange
            var contractId = Guid.NewGuid();
            _contractServiceMock.Setup(s => s.SignContractAsync(contractId))
                .ReturnsAsync(true);

            // Act
            var result = await _controller.SignContract(contractId);

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            var response = okResult.Value as ResponseVM;
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Status);
            Assert.AreEqual("Ký hợp đồng thành công", response.Message);
        }

        [TestMethod]
        public async Task SignContract_ReturnsBadRequest_WhenSigningFails()
        {
            // Arrange
            var contractId = Guid.NewGuid();
            _contractServiceMock.Setup(s => s.SignContractAsync(contractId))
                .ReturnsAsync(false);

            // Act
            var result = await _controller.SignContract(contractId);

            // Assert
            var badRequestResult = result as BadRequestObjectResult;
            Assert.IsNotNull(badRequestResult);
            var response = badRequestResult.Value as ResponseVM;
            Assert.IsNotNull(response);
            Assert.IsFalse(response.Status);
            Assert.AreEqual("Không thể ký hợp đồng", response.Message);
        }

        [TestMethod]
        public async Task SignContract_ReturnsInternalServerError_WhenExceptionOccurs()
        {
            // Arrange
            var contractId = Guid.NewGuid();
            _contractServiceMock.Setup(s => s.SignContractAsync(contractId))
                .ThrowsAsync(new Exception("Test error message"));

            // Act
            var result = await _controller.SignContract(contractId);

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
        public async Task ExtendContract_ReturnsSuccess_WhenExtensionSucceeds()
        {
            // Arrange
            var contractId = Guid.NewGuid();
            var months = 6;
            _contractServiceMock.Setup(s => s.ExtendContractAsync(contractId, months))
                .ReturnsAsync(true);

            // Act
            var result = await _controller.ExtendContract(contractId, months);

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            var response = okResult.Value as ResponseVM;
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Status);
            Assert.AreEqual("Yêu cầu gia hạn hợp đồng thành công", response.Message);
        }

        [TestMethod]
        public async Task ExtendContract_ReturnsFailure_WhenExtensionFails()
        {
            // Arrange
            var contractId = Guid.NewGuid();
            var months = 6;
            _contractServiceMock.Setup(s => s.ExtendContractAsync(contractId, months))
                .ReturnsAsync(false);

            // Act
            var result = await _controller.ExtendContract(contractId, months);

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            var response = okResult.Value as ResponseVM;
            Assert.IsNotNull(response);
            Assert.IsFalse(response.Status);
            Assert.AreEqual("Yêu cầu gia hạn hợp đồng thất bại", response.Message);
        }

        [TestMethod]
        public async Task ExtendContract_ReturnsError_WhenExceptionOccurs()
        {
            // Arrange
            var contractId = Guid.NewGuid();
            var months = 6;
            _contractServiceMock.Setup(s => s.ExtendContractAsync(contractId, months))
                .ThrowsAsync(new Exception("Test error message"));

            // Act
            var result = await _controller.ExtendContract(contractId, months);

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            var response = okResult.Value as ResponseVM;
            Assert.IsNotNull(response);
            Assert.IsFalse(response.Status);
            Assert.AreEqual("Test error message", response.Message);
        }
        [TestMethod]
        public async Task RejectContract_ReturnsSuccess_WhenRejectionSucceeds()
        {
            // Arrange
            var contractId = Guid.NewGuid();
            _contractServiceMock.Setup(s => s.RejectContractAsync(contractId))
                .ReturnsAsync(true);

            // Act
            var result = await _controller.RejectContract(contractId);

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            var response = okResult.Value as ResponseVM;
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Status);
            Assert.AreEqual("Ký hợp đồng thành công", response.Message);
        }

        [TestMethod]
        public async Task RejectContract_ReturnsFailure_WhenRejectionFails()
        {
            // Arrange
            var contractId = Guid.NewGuid();
            _contractServiceMock.Setup(s => s.RejectContractAsync(contractId))
                .ReturnsAsync(false);

            // Act
            var result = await _controller.RejectContract(contractId);

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            var response = okResult.Value as ResponseVM;
            Assert.IsNotNull(response);
            Assert.IsFalse(response.Status);
            Assert.AreEqual("Không thể ký hợp đồng", response.Message);
        }

        [TestMethod]
        public async Task RejectContract_ReturnsError_WhenExceptionOccurs()
        {
            // Arrange
            var contractId = Guid.NewGuid();
            _contractServiceMock.Setup(s => s.RejectContractAsync(contractId))
                .ThrowsAsync(new Exception("Test error message"));

            // Act
            var result = await _controller.RejectContract(contractId);

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            var response = okResult.Value as ResponseVM;
            Assert.IsNotNull(response);
            Assert.IsFalse(response.Status);
            Assert.AreEqual("Test error message", response.Message);
        }
        [TestMethod]
        public async Task ApproveContract_ReturnsSuccess_WhenApprovalSucceeds()
        {
            // Arrange
            var contractId = Guid.NewGuid();
            _contractServiceMock.Setup(s => s.ApproveExtendContract(contractId))
                .ReturnsAsync(true);

            // Act
            var result = await _controller.ApproveContract(contractId);

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            var response = okResult.Value as ResponseVM;
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Status);
            Assert.AreEqual("Xác nhận hạn hợp đồng thành công", response.Message);
        }

        [TestMethod]
        public async Task ApproveContract_ReturnsFailure_WhenApprovalFails()
        {
            // Arrange
            var contractId = Guid.NewGuid();
            _contractServiceMock.Setup(s => s.ApproveExtendContract(contractId))
                .ReturnsAsync(false);

            // Act
            var result = await _controller.ApproveContract(contractId);

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            var response = okResult.Value as ResponseVM;
            Assert.IsNotNull(response);
            Assert.IsFalse(response.Status);
            Assert.AreEqual("Xác nhận gia hạn hợp đồng thất bại", response.Message);
        }

        [TestMethod]
        public async Task ApproveContract_ReturnsError_WhenExceptionOccurs()
        {
            // Arrange
            var contractId = Guid.NewGuid();
            _contractServiceMock.Setup(s => s.ApproveExtendContract(contractId))
                .ThrowsAsync(new Exception("Test error message"));

            // Act
            var result = await _controller.ApproveContract(contractId);

            // Assert
            var okResult = result as OkObjectResult;
            Assert.IsNotNull(okResult);
            var response = okResult.Value as ResponseVM;
            Assert.IsNotNull(response);
            Assert.IsFalse(response.Status);
            Assert.AreEqual("Test error message", response.Message);
        }
    }
}
