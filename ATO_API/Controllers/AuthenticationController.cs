using ATO_API.Helper;
using Azure;
using Data.DTO.Request;
using Data.DTO.Respone;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.IdentityModel.Tokens;
using Service.AccountSer;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ATO_API.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly UserManager<Account> _userManager;
        private readonly RoleManager<IdentityRole<Guid>> _roleManager;
        private readonly IConfiguration _configuration;
        private readonly IAccountService _accountService;
        private readonly IMemoryCache _cache;
        private readonly TokenHelper _tokenHelper;
        public AuthenticationController(UserManager<Account> userManager,
            RoleManager<IdentityRole<Guid>> roleManager,
            IConfiguration configuration,
            IAccountService accountService,
            IMemoryCache cache,
            TokenHelper tokenHelper
            )
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
            _accountService = accountService;
            _cache = cache;
            _tokenHelper = tokenHelper;
        }
        [HttpPost("login")]
        [ProducesResponseType(typeof(ResponseLogin), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Login([FromBody] LoginDTO model)
        {
            try
            {
                var response = await _accountService.LoginAsync(model);

                if (!string.IsNullOrEmpty(response.ErrorMessage))
                {
                    return BadRequest(new ResponseVM
                    {
                        Status = false,
                        Message = response.ErrorMessage
                    });
                }

                return Ok(response);
            }
            catch (Exception)
            {
                return StatusCode(500, new ResponseVM { Status = false, Message = "Đã sảy ra lỗi, vui lòng thử lại sau!" });
            }
        }

        [HttpPost("forgot-password/send-otp")]
        [ProducesResponseType(typeof(ResponseVM_Email), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM_Email), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> ForgotPasswordSendOTP([FromBody] ForgotPassword_Request_DTO model)
        {
            try
            {
                var result = await _accountService.ForgotPasswordSendOTPAsync(model.username);
                if (result.Status == false)
                {
                    return BadRequest(new ResponseVM_Email
                    {
                        Status = result.Status,
                        Message = result.Message,
                        toEmail = result.toEmail,
                    });
                }
                return Ok(new ResponseVM_Email()
                {
                    Status = result.Status,
                    Message = result.Message,
                    toEmail = result.toEmail,
                });
            }
            catch (Exception)
            {
                return StatusCode(500, new ResponseVM { Status = false, Message = "Đã sảy ra lỗi, vui lòng thử lại sau!" });
            }
        }
        [HttpPost("forgot-password/verify-OTP")]
        [ProducesResponseType(typeof(object), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<string>> VerifyOtpAsync(string username, string otp)
        {
            try
            {
                if (_cache.TryGetValue(username, out string storedOtp) && storedOtp == otp)
                {
                    _cache.Remove(username);

                    var token = _tokenHelper.GenerateAccessToken(username);

                    return Ok(new { Token = token });
                }

                return StatusCode(401, new ResponseVM
                {
                    Status = false,
                    Message = "Mã xác thực không hợp lệ!",
                });
            }
            catch (Exception)
            {
                return StatusCode(500, new ResponseVM { Status = false, Message = "Đã sảy ra lỗi, vui lòng thử lại sau!" });
            }

        }
        [Authorize]
        [HttpPost("change-password")]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> ForgotPassword([FromBody] ForgotPassword_DTO model)
        {
            try
            {
                var result = await _accountService.ForgotPasswordAsync(model);
                if (result.Status == false)
                {
                    return BadRequest(new ResponseVM
                    {
                        Status = result.Status,
                        Message = result.Message,
                    });
                }
                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(500, new ResponseVM { Status = false, Message = "Đã sảy ra lỗi, vui lòng thử lại sau!" });
            }
        }
    }
}
