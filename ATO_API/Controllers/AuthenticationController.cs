using ATO_API.Helper;
using AutoMapper;
using Data.DTO.Request;
using Data.DTO.Respone;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Service.AccountSer;
using System.Text.RegularExpressions;

namespace ATO_API.Controllers;

[Route("api/auth")]
[ApiController]
public class AuthenticationController(UserManager<Account> userManager,
    RoleManager<IdentityRole<Guid>> roleManager,
    IConfiguration configuration,
    IAccountService accountService,
    IMemoryCache cache,
    TokenHelper tokenHelper,
    IMapper mapper
        ) : ControllerBase
{
    private readonly UserManager<Account> _userManager = userManager;
    private readonly RoleManager<IdentityRole<Guid>> _roleManager = roleManager;
    private readonly IConfiguration _configuration = configuration;
    private readonly IAccountService _accountService = accountService;
    private readonly IMemoryCache _cache = cache;
    private readonly TokenHelper _tokenHelper = tokenHelper;
    private readonly IMapper _mapper = mapper;

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

    [HttpPost("sign-up")]
    [ProducesResponseType(typeof(ResponseLogin), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> SignUp([FromBody] CreateAccountRequest request)
    {
        try
        {

            if (!IsValidEmail(request.Email!))
            {
                return BadRequest(new ResponseVM
                {
                    Status = false,
                    Message = "Email không hợp lệ. Vui lòng nhập đúng định dạng."
                });
            }

            if (!IsValidPhoneNumber(request.PhoneNumber!))
            {
                return BadRequest(new ResponseVM
                {
                    Status = false,
                    Message = "Số điện thoại không hợp lệ. Vui lòng nhập đúng định dạng."
                });
            }
            var existingEmail = await _userManager.FindByEmailAsync(request.Email!);

            if (existingEmail != null)
            {
                return BadRequest(new ResponseVM
                {
                    Status = false,
                    Message = "Email đã tồn tại trong hệ thống."
                });
            }

            var existingPhone = await _accountService.GetAccountByPhoneNumberAsync(request.PhoneNumber!);
            if (existingPhone != null)
            {
                return BadRequest(new ResponseVM
                {
                    Status = false,
                    Message = "Số điện thoại đã tồn tại trong hệ thống."
                });
            }
            var existingUsername = await _userManager.FindByNameAsync(request.UserName);
            if (existingUsername != null)
            {
                return BadRequest(new ResponseVM
                {
                    Status = false,
                    Message = "User name đã tồn tại trong hệ thống."
                });
            }

            var newAccount = _mapper.Map<Account>(request);
            newAccount.Id = Guid.NewGuid();
            newAccount.isAccountActive = true;
            newAccount.PasswordHash = new PasswordHasher<Account>().HashPassword(null, request.Password!);
            newAccount.SecurityStamp = Guid.NewGuid().ToString();
            await _accountService.AddAccountAsync(newAccount);

            // add role for account
            var roleName = await _roleManager.Roles
                .Where(r => r.Id == request.Role)
                .Select(r => r.Name)
                .FirstOrDefaultAsync();

            if (!string.IsNullOrEmpty(roleName))
                await _userManager.AddToRoleAsync(newAccount, roleName);

            return Ok(new ResponseModel(true, "Tạo tài khoản thành công"));
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            return StatusCode(500, new ResponseVM { Status = false, Message = ex.ToString() });
        }
    }

    private bool IsValidEmail(string email)
    {
        var emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase);
        return emailRegex.IsMatch(email);
    }
    private bool IsValidPhoneNumber(string phoneNumber)
    {
        var phoneRegex = new Regex(@"^(?:\+84|0)[1-9]\d{8,9}$");
        return phoneRegex.IsMatch(phoneNumber);
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
