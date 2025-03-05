using ATO_API.Helper;
using AutoMapper;
using Data.DTO.Respone;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Service.AccountSer;

namespace ATO_API.Controllers.Admin
{
    [Route("api/user/admin")]
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

    }
}
