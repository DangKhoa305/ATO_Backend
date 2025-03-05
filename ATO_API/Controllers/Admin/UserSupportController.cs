using ATO_API.Helper;
using AutoMapper;
using Azure;
using Data.DTO.Request;
using Data.DTO.Respone;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Nest;
using Service.AccountSer;
using Service.PageResult;
using Service.UserSupportSer;

namespace ATO_API.Controllers.Admin
{
    [Route("api/support/admin")]
    [ApiController]
    [Authorize(Roles = "Admin")]
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
        [HttpGet("list-user-supports")]
        [ProducesResponseType(typeof(List<UserSupport>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> ListUserSupport()
        {
            try
            {
                List<UserSupport> response = await _userSupportService.ListUserSupport();
                List<UserSupportDetails> responseResult = _mapper.Map<List<UserSupportDetails>>(response);
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
        [HttpPut("reply-request-support")]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> ReplyRequestUserSupport([FromBody] ReplyUserSupportRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Dữ liệu yêu cầu không hợp lệ.");
                }

                ResponseVM result = await _userSupportService.ReplyRequestUserSupport(request);
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
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseVM
                {
                    Status = false,
                    Message = ex.Message,
                });
            }
        }
        [HttpGet("request-support-detail/{SupportId}")]
        [ProducesResponseType(typeof(UserSupportDetails), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> RequestUserSupportDetails(Guid SupportId)
        {
            try
            {
                if (SupportId == null)
                {
                    return BadRequest("Dữ liệu yêu cầu không hợp lệ.");
                }

                var result = await _userSupportService.UserSupportDetails(SupportId);
                UserSupportDetails responseResult = _mapper.Map<UserSupportDetails>(result);

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
    }
}
