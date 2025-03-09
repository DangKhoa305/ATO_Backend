using ATO_API.Helper;
using AutoMapper;
using Data.DTO.Request;
using Data.DTO.Respone;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.IdentityModel.Tokens;
using Service.AccountSer;
using System.Text.RegularExpressions;

namespace ATO_API.Controllers.Admin
{
    [Route("api/admin/user")]
    [Authorize(Roles = "Admin")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserManager<Account> _userManager;
        private readonly RoleManager<IdentityRole<Guid>> _roleManager;
        private readonly IConfiguration _configuration;
        private readonly IAccountService _accountService;
        private readonly IMapper _mapper;

        public UserController(UserManager<Account> userManager,
            RoleManager<IdentityRole<Guid>> roleManager,
            IConfiguration configuration,
            IAccountService accountService,
             IMapper mapper
            )
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
            _accountService = accountService;
            _mapper = mapper;
        }
        [HttpGet("get-list-users")]
        [ProducesResponseType(typeof(List<UserRespone>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetUsers()
        {
            try
            {
                var response = await _accountService.GetAccountsAsync();
                var responseResult = _mapper.Map<List<UserRespone>>(response);

                foreach (var userResponse in responseResult)
                {
                    var account = response.FirstOrDefault(a => a.Id == userResponse.Id);
                    if (account != null)
                    {
                        userResponse.RoleName = (await _userManager.GetRolesAsync(account)).SingleOrDefault();
                    }
                }

                return Ok(responseResult);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseVM
                {
                    Status = false,
                    Message = ex.Message,
                });
            }
        }
        [HttpGet("get-user/{id}")]
        [ProducesResponseType(typeof(UserRespone), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetUser(Guid id)
        {
            try
            {
                var response = await _accountService.GetAccountByIdAsync(id);
                var responseResult = _mapper.Map<UserRespone>(response);
                if (responseResult != null)
                {
                    responseResult.RoleName = (await _userManager.GetRolesAsync(response)).SingleOrDefault();
                }

                return Ok(responseResult);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseVM
                {
                    Status = false,
                    Message = ex.Message,
                });
            }
        }
        [HttpPost("reset-password/{id}")]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> ResetPassword(Guid id)
        {
            try
            {
                bool result = await _accountService.ResetPasswordAsync(id, "A123@123a");
                if (!result)
                {
                    return BadRequest(new ResponseVM { Status = false, Message = "Đặt lại mật khẩu thất bại!" });
                }

                return Ok(new ResponseVM { Status = true, Message = "Đặt lại mật khẩu thành công!" });
            }
            catch (Exception)
            {
                return StatusCode(500, new ResponseVM { Status = false, Message = "Đã xảy ra lỗi vui lòng thử lại sau!" });
            }
        }

        [HttpPut("inactive-account/{id}")]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> InactiveAccount(Guid id)
        {
            try
            {
                bool result = await _accountService.InactiveAccountAsync(id);
                if (!result)
                {
                    return BadRequest(new ResponseVM { Status = false, Message = "Vô hiệu hóa tài khoản thất bại!" });
                }

                return Ok(new ResponseVM { Status = true, Message = "Tài khoản đã bị vô hiệu hóa!" });
            }
            catch (Exception)
            {
                return StatusCode(500, new ResponseVM { Status = false, Message = "Đã xảy ra lỗi vui lòng thử lại sau!" });
            }
        }
        [HttpPost("create-account")]
        [ProducesResponseType(typeof(UserRespone), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateAccount([FromBody] CreateAccountRequest request)
        {
            try
            {

                if (!IsValidEmail(request.Email))
                {
                    return BadRequest(new ResponseVM
                    {
                        Status = false,
                        Message = "Email không hợp lệ. Vui lòng nhập đúng định dạng."
                    });
                }

                if (!IsValidPhoneNumber(request.PhoneNumber))
                {
                    return BadRequest(new ResponseVM
                    {
                        Status = false,
                        Message = "Số điện thoại không hợp lệ. Vui lòng nhập đúng định dạng."
                    });
                }
                var existingEmail = await _userManager.FindByEmailAsync(request.Email);

                if (existingEmail != null)
                {
                    return BadRequest(new ResponseVM
                    {
                        Status = false,
                        Message = "Email đã tồn tại trong hệ thống."
                    });
                }

                var existingPhone = await _accountService.GetAccountByPhoneNumberAsync(request.PhoneNumber);
                if (existingPhone != null)
                {
                    return BadRequest(new ResponseVM
                    {
                        Status = false,
                        Message = "Số điện thoại đã tồn tại trong hệ thống."
                    });
                }

                var newAccount = _mapper.Map<Account>(request);
                newAccount.Id = Guid.NewGuid();
                newAccount.isAccountActive = true;
                newAccount.PasswordHash = new PasswordHasher<Account>().HashPassword(null, "A123@123a");
                newAccount.SecurityStamp = Guid.NewGuid().ToString();
                //TourismCompanies
                if (request.Role == Guid.Parse("6F8CDFBE-2D8F-4B5E-B767-194CBA66309A"))
                {
                    newAccount.TourCompany.TourCompanyId = Guid.NewGuid();
                    newAccount.TourCompany.UserId = newAccount.Id;
                    newAccount.TourCompany.CreateDate = DateTime.UtcNow;
                }
                //afto
                if (request.Role == Guid.Parse("49E15EF3-2D88-4812-955F-D00859B3F7E3"))
                {
                    newAccount.TouristFacility.TouristFacilityId = Guid.NewGuid();
                    newAccount.TouristFacility.UserId = newAccount.Id;
                    newAccount.TouristFacility.CreateDate = DateTime.UtcNow;
                }
                //TourGuide
                if (request.Role == Guid.Parse("870DD1EC-C340-41EE-9088-0F3612F510CD"))
                {
                    newAccount.TourGuide.GuideId = Guid.NewGuid();
                    newAccount.TourGuide.UserId = newAccount.Id;
                    newAccount.TourGuide.CreateDate = DateTime.UtcNow;
                }
                await _accountService.AddAccountAsync(newAccount);
                // add role for account
                var roleName = await _roleManager.Roles
                    .Where(r => r.Id == request.Role)
                    .Select(r => r.Name)
                    .FirstOrDefaultAsync();

                if (!string.IsNullOrEmpty(roleName))
                {
                    await _userManager.AddToRoleAsync(newAccount, roleName);
                }
                var response = _mapper.Map<UserRespone>(newAccount);
                response.RoleName = (await _userManager.GetRolesAsync(newAccount)).SingleOrDefault();

                return CreatedAtAction(nameof(GetUsers), new { id = newAccount.Id }, response);
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

    }
}
