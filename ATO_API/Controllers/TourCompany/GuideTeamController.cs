using AutoMapper;
using Data.DTO.Request;
using Data.DTO.Respone;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Service.AccountSer;
using Service.TourGuideSer;
using System.Text.RegularExpressions;

namespace ATO_API.Controllers.TourCompany
{
    [Route("api/tour-company/guideteams")]
    [ApiController]
    [Authorize(Roles = "TourismCompanies")]
    public class GuideTeamController : ControllerBase
    {
        private readonly UserManager<Account> _userManager;
        private readonly RoleManager<IdentityRole<Guid>> _roleManager;
        private readonly IAccountService _accountService;
        private readonly ITourGuideService _tourGuideService;
        private readonly IMapper _mapper;

        public GuideTeamController(UserManager<Account> userManager,
            RoleManager<IdentityRole<Guid>> roleManager,
            IAccountService accountService,
             IMapper mapper,
             ITourGuideService tourGuideService
            )
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _accountService = accountService;
            _mapper = mapper;
            _tourGuideService = tourGuideService;
        }
        [HttpGet("get-list-guide-teams")]
        [ProducesResponseType(typeof(List<TourGuideRespone>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetGuideTeams()
        {
            try
            {
                var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                var response = await _tourGuideService.GetTourGuidesAsync(Guid.Parse(userId));
                var responseResult = _mapper.Map<List<TourGuideRespone>>(response);


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

        [HttpGet("available/{packageId}")]
        [ProducesResponseType(typeof(List<TourGuideRespone>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Available(Guid packageId)
        {
            try
            {
                var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                var response = await _tourGuideService.GetTourGuidesAsync(Guid.Parse(userId));
                var busyGuides = await _tourGuideService.GetBusyTourGuide(packageId);
                var responseResult = _mapper.Map<List<TourGuideRespone>>(response);

                responseResult.ForEach(x =>
                {
                    if (busyGuides.Keys.Contains(x.GuideId))
                    {
                        x.IsAvailable = false;
                        x.Message = busyGuides.GetValueOrDefault(x.GuideId);
                    }
                    else
                    {
                        x.IsAvailable = true;
                    }
                });

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

        [HttpGet("get-guide-team/{GuideId}")]
        [ProducesResponseType(typeof(TourGuideRespone), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetGuideTeam(Guid GuideId)
        {
            try
            {
                var response = await _tourGuideService.GetTourGuideByIdAsync(GuideId);
                var responseResult = _mapper.Map<TourGuideRespone>(response);
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
        [HttpPost("request-guide-team")]
        [ProducesResponseType(typeof(TourGuideRespone), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateAccount([FromBody] TourGuideRequest request)
        {
            try
            {
                var roleId = Guid.Parse("870DD1EC-C340-41EE-9088-0F3612F510CD");
                if (!IsValidEmail(request.Account.Email))
                {
                    return BadRequest(new ResponseVM
                    {
                        Status = false,
                        Message = "Email không hợp lệ. Vui lòng nhập đúng định dạng."
                    });
                }

                if (!IsValidPhoneNumber(request.Account.PhoneNumber))
                {
                    return BadRequest(new ResponseVM
                    {
                        Status = false,
                        Message = "Số điện thoại không hợp lệ. Vui lòng nhập đúng định dạng."
                    });
                }
                var existingEmail = await _userManager.FindByEmailAsync(request.Account.Email);

                if (existingEmail != null)
                {
                    return BadRequest(new ResponseVM
                    {
                        Status = false,
                        Message = "Email đã tồn tại trong hệ thống."
                    });
                }

                var existingPhone = await _accountService.GetAccountByPhoneNumberAsync(request.Account.PhoneNumber);
                if (existingPhone != null)
                {
                    return BadRequest(new ResponseVM
                    {
                        Status = false,
                        Message = "Số điện thoại đã tồn tại trong hệ thống."
                    });
                }
                var existingUsername = await _userManager.FindByNameAsync(request.Account.UserName);
                if (existingUsername != null)
                {
                    return BadRequest(new ResponseVM
                    {
                        Status = false,
                        Message = "User name đã tồn tại trong hệ thống."
                    });
                }

                var newAccount = _mapper.Map<Account>(request.Account);
                newAccount.Id = Guid.NewGuid();
                newAccount.isAccountActive = true;
                newAccount.PasswordHash = new PasswordHasher<Account>().HashPassword(null, "A123@123a");
                newAccount.SecurityStamp = Guid.NewGuid().ToString();

                await _accountService.AddAccountAsync(newAccount);
                // add role for account
                var roleName = await _roleManager.Roles
                    .Where(r => r.Id == roleId)
                    .Select(r => r.Name)
                    .FirstOrDefaultAsync();

                if (!string.IsNullOrEmpty(roleName))
                {
                    await _userManager.AddToRoleAsync(newAccount, roleName);
                }
                var response = _mapper.Map<UserRespone>(newAccount);
                response.RoleName = (await _userManager.GetRolesAsync(newAccount)).SingleOrDefault();
                // Create new tour guide

                var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                TourGuide tourGuide = new TourGuide()
                {
                    GuideId = Guid.NewGuid(),
                    UserId = newAccount.Id,
                    Bio = request.Bio,
                    Languages = request.Languages,
                    ExpertiseArea = request.ExpertiseArea,
                    Rating = request.Rating,
                    CreateDate = DateTime.Now,
                };
                await _tourGuideService.AddTourGuideAsync(tourGuide, Guid.Parse(userId));
                return Ok(request);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return StatusCode(500, new ResponseVM { Status = false, Message = ex.ToString() });
            }
        }
        [HttpPut("update-guide-team/{GuideId}")]
        [ProducesResponseType(typeof(TourGuideRespone), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateTourCompany(Guid GuideId, [FromBody] TourGuideRequest request)
        {
            try
            {

                var existingGuideTeam = await _tourGuideService.GetTourGuideByIdAsync(GuideId);
                if (existingGuideTeam == null)
                {
                    return NotFound(new ResponseVM
                    {
                        Status = false,
                        Message = "Không tìm thấy hướng dẫn viên."
                    });
                }

                existingGuideTeam.UpdateDate = DateTime.UtcNow;
                existingGuideTeam.Bio = request.Bio;
                existingGuideTeam.Languages = request.Languages;
                existingGuideTeam.ExpertiseArea = request.ExpertiseArea;
                existingGuideTeam.Rating = request.Rating;

                var existingAccount = await _accountService.GetAccountByIdAsync(existingGuideTeam.UserId);
                if (existingAccount == null)
                {
                    return NotFound(new ResponseVM
                    {
                        Status = false,
                        Message = "Không tìm thấy tài khoản hướng dẫn viên."
                    });
                }
                // Kiểm tra định dạng email
                if (!IsValidEmail(request.Account.Email))
                {
                    return BadRequest(new ResponseVM
                    {
                        Status = false,
                        Message = "Email không hợp lệ. Vui lòng nhập đúng định dạng."
                    });
                }

                // Kiểm tra định dạng số điện thoại
                if (!IsValidPhoneNumber(request.Account.PhoneNumber))
                {
                    return BadRequest(new ResponseVM
                    {
                        Status = false,
                        Message = "Số điện thoại không hợp lệ. Vui lòng nhập đúng định dạng."
                    });
                }

                if (!existingAccount.Email.Equals(request.Account.Email, StringComparison.OrdinalIgnoreCase))
                {
                    var existingEmail = await _userManager.FindByEmailAsync(request.Account.Email);
                    if (existingEmail != null && existingEmail.Id != existingAccount.Id)
                    {
                        return BadRequest(new ResponseVM
                        {
                            Status = false,
                            Message = "Email đã tồn tại trong hệ thống."
                        });
                    }
                }

                // Nếu số điện thoại thay đổi, kiểm tra xem số mới có bị trùng không
                if (!existingAccount.PhoneNumber.Equals(request.Account.PhoneNumber, StringComparison.OrdinalIgnoreCase))
                {
                    var existingPhone = await _accountService.GetAccountByPhoneNumberAsync(request.Account.PhoneNumber);
                    if (existingPhone != null && existingPhone.Id != existingAccount.Id)
                    {
                        return BadRequest(new ResponseVM
                        {
                            Status = false,
                            Message = "Số điện thoại đã tồn tại trong hệ thống."
                        });
                    }
                }
                // Nếu username thay đổi, kiểm tra xem username mới có bị trùng không
                if (!existingAccount.UserName.Equals(request.Account.UserName, StringComparison.OrdinalIgnoreCase))
                {
                    var existingUsername = await _userManager.FindByNameAsync(request.Account.UserName);
                    if (existingUsername != null && existingUsername.Id != existingAccount.Id)
                    {
                        return BadRequest(new ResponseVM
                        {
                            Status = false,
                            Message = "User name đã tồn tại trong hệ thống."
                        });
                    }
                }
                existingAccount.Email = request.Account.Email;
                existingAccount.PhoneNumber = request.Account.PhoneNumber;
                existingAccount.Fullname = request.Account.Fullname;
                existingAccount.AvatarURL = request.Account.AvatarURL;
                existingAccount.UserName = request.Account.UserName;
                existingAccount.Dob = request.Account.Dob;
                existingAccount.Gender = request.Account.Gender;

                // Lưu thay đổi vào hệ thống
                await _accountService.UpdateAccountAsync(existingAccount);
                await _tourGuideService.UpdateTourGuideAsync(existingGuideTeam);
                var response = _mapper.Map<TourGuideRespone>(existingGuideTeam);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseVM
                {
                    Status = false,
                    Message = ex.Message
                });
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
