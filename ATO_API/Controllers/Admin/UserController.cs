using AutoMapper;
using Data.DTO.Request;
using Data.DTO.Respone;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Service.AccountSer;
using Service.DashboardSer;
using Service.TourCompanySer;
using System.Text.RegularExpressions;

namespace ATO_API.Controllers.Admin
{
    [Route("api/admin/user")]
    [Authorize]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserManager<Account> _userManager;
        private readonly RoleManager<IdentityRole<Guid>> _roleManager;
        private readonly IConfiguration _configuration;
        private readonly IAccountService _accountService;
        private readonly IMapper _mapper;
        private readonly ITourCompanyService _tourCompanyService;
        private readonly IDashboardService _dashboardService;

        public UserController(UserManager<Account> userManager,
            RoleManager<IdentityRole<Guid>> roleManager,
            IConfiguration configuration,
            IAccountService accountService,
             IMapper mapper,
             ITourCompanyService tourCompanyService,
             IDashboardService dashboardService
            )
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
            _accountService = accountService;
            _mapper = mapper;
            _tourCompanyService = tourCompanyService;
            _dashboardService = dashboardService;
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
                newAccount.PasswordHash = new PasswordHasher<Account>().HashPassword(null, "A123@123a");
                newAccount.SecurityStamp = Guid.NewGuid().ToString();
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


        [HttpPost("create-tour-guide")]
        [ProducesResponseType(typeof(UserRespone), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateTourGuide([FromBody] CreateAccountRequest request)
        {
            try
            {

                var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                var companyId = await _dashboardService.GetCompanyIdFromUserIdAsync(Guid.Parse(userId!));

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
                newAccount.PasswordHash = new PasswordHasher<Account>().HashPassword(null, "A123@123a");
                newAccount.SecurityStamp = Guid.NewGuid().ToString();
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

                var guide = new TourGuide
                {
                    GuideId = Guid.NewGuid(),
                    TourCompanyId = companyId ?? Guid.Empty,
                    UserId = newAccount.Id,
                    Bio = "Expert in eco-tourism with 5 years of experience.",
                    Languages = "English, French",
                    ExpertiseArea = "Eco-farming, fruit orchards",
                    Rating = 4.8,
                    CreateDate = DateTime.UtcNow,
                    UpdateDate = null
                };

                await _tourCompanyService.AddTourGuide(guide);
                return CreatedAtAction(nameof(GetUsers), new { id = newAccount.Id }, response);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return StatusCode(500, new ResponseVM { Status = false, Message = ex.ToString() });
            }
        }


        [HttpPut("update-account")]
        [ProducesResponseType(typeof(UserRespone), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateAccount([FromBody] UpdateAccountRequest request)
        {
            try
            {
                // Kiểm tra định dạng email
                if (!IsValidEmail(request.Email))
                {
                    return BadRequest(new ResponseVM
                    {
                        Status = false,
                        Message = "Email không hợp lệ. Vui lòng nhập đúng định dạng."
                    });
                }

                // Kiểm tra định dạng số điện thoại
                if (!IsValidPhoneNumber(request.PhoneNumber))
                {
                    return BadRequest(new ResponseVM
                    {
                        Status = false,
                        Message = "Số điện thoại không hợp lệ. Vui lòng nhập đúng định dạng."
                    });
                }

                // Lấy tài khoản theo Id
                var account = await _accountService.GetAccountByIdAsync(request.Id);
                if (account == null)
                {
                    return NotFound(new ResponseVM
                    {
                        Status = false,
                        Message = "Không tìm thấy tài khoản."
                    });
                }

                // Nếu email thay đổi, kiểm tra email mới có bị trùng với tài khoản khác không
                if (!account.Email.Equals(request.Email, StringComparison.OrdinalIgnoreCase))
                {
                    var existingEmail = await _userManager.FindByEmailAsync(request.Email);
                    if (existingEmail != null && existingEmail.Id != account.Id)
                    {
                        return BadRequest(new ResponseVM
                        {
                            Status = false,
                            Message = "Email đã tồn tại trong hệ thống."
                        });
                    }
                }

                // Nếu số điện thoại thay đổi, kiểm tra xem số mới có bị trùng không
                if (account.PhoneNumber?.Equals(request.PhoneNumber, StringComparison.OrdinalIgnoreCase) == false)
                {
                    var existingPhone = await _accountService.GetAccountByPhoneNumberAsync(request.PhoneNumber);
                    if (existingPhone != null && existingPhone.Id != account.Id)
                    {
                        return BadRequest(new ResponseVM
                        {
                            Status = false,
                            Message = "Số điện thoại đã tồn tại trong hệ thống."
                        });
                    }
                }
                // Nếu username thay đổi, kiểm tra xem username mới có bị trùng không
                if (!account.UserName.Equals(request.UserName, StringComparison.OrdinalIgnoreCase))
                {
                    var existingUsername = await _userManager.FindByNameAsync(request.UserName);
                    if (existingUsername != null && existingUsername.Id != account.Id)
                    {
                        return BadRequest(new ResponseVM
                        {
                            Status = false,
                            Message = "User name đã tồn tại trong hệ thống."
                        });
                    }
                }
                account.Email = request.Email;
                account.PhoneNumber = request.PhoneNumber;
                account.Fullname = request.Fullname;
                account.AvatarURL = request.AvatarURL;
                account.UserName = request.UserName;
                account.Dob = request.Dob;
                account.Gender = request.Gender;
                account.isAccountActive = request.isAccountActive;
                // Nếu có thay đổi vai trò, cập nhật lại
                if (request.Role != Guid.Empty)
                {
                    // Loại bỏ vai trò hiện tại
                    var currentRoles = await _userManager.GetRolesAsync(account);
                    if (currentRoles.Any())
                    {
                        await _userManager.RemoveFromRolesAsync(account, currentRoles);
                    }

                    // Lấy tên vai trò theo Id được cung cấp
                    var roleName = await _roleManager.Roles
                        .Where(r => r.Id == request.Role)
                        .Select(r => r.Name)
                        .FirstOrDefaultAsync();

                    if (!string.IsNullOrEmpty(roleName))
                    {
                        await _userManager.AddToRoleAsync(account, roleName);
                    }
                }

                // Lưu thay đổi vào hệ thống
                await _accountService.UpdateAccountAsync(account);

                var response = _mapper.Map<UserRespone>(account);
                response.RoleName = (await _userManager.GetRolesAsync(account)).SingleOrDefault();

                return Ok(response);
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
