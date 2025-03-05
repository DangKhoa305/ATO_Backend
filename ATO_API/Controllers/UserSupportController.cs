using ATO_API.Helper;
using AutoMapper;
using Data.DTO.Request;
using Data.DTO.Respone;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Nest;
using Service.AccountSer;
using Service.UserSupportSer;

namespace ATO_API.Controllers
{
    [Route("api/support")]
    [ApiController]
    public class UserSupportController : ControllerBase
    {
        private readonly IUserSupportService _userSupportService;
        private readonly IMapper _mapper;
        public UserSupportController(
            IUserSupportService userSupportService,
            IMapper mapper
            )
        {
            _userSupportService = userSupportService;
            _mapper = mapper;
        }
        [HttpPost("request-support")]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateUserSupport([FromBody] UserSupportRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Dữ liệu yêu cầu không hợp lệ.");
                }
                UserSupport userSupport = _mapper.Map<UserSupport>(request);
                ResponseVM respone = await _userSupportService.RequestUserSupport(userSupport);
                if (respone.Status == false)
                {
                    return BadRequest(new ResponseVM
                    {
                        Status = respone.Status,
                        Message = respone.Message,
                    });
                }
                return Ok(respone);
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

    }
}
