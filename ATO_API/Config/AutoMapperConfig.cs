using Data.DTO.Request;
using Data.DTO.Respone;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.SystemConfigSer;

namespace ATO_API.Controllers.Admin
{
    [Route("api/admin/config")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class ConfigController : ControllerBase
    {
        private readonly ISystemConfigurationsService _configService;

        public ConfigController(ISystemConfigurationsService configService)
        {
            _configService = configService;
        }

        [HttpPut("update-config-email")]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateEmailConfig([FromBody] UpdateConfigRequest request)
        {
            try
            {
                var isUpdated = await _configService.UpdateEmailAndAppPasswordAsync(request.Email, request.AppPassword);

                if (!isUpdated)
                {
                    return NotFound(new ResponseVM
                    {
                        Status = false,
                        Message = "Email và AppPassword không tìm thấy cấu hình!",
                    });
                }
                return Ok(new ResponseVM
                {
                    Status = true,
                    Message = "Cập nhật cấu hình thành công!",
                });
            }
            catch (Exception)
            {
                return StatusCode(500, new ResponseVM { Status = false, Message = "Đã xảy ra lỗi vui lòng thử lại sau!" });
            }

        }
        [HttpGet("get-config-email")]
        [ProducesResponseType(typeof(EmailConfig), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetEmailConfig()
        {
            try
            {
                var Configs = await _configService.GetEmailAsync();
                return Ok(Configs);
            }
            catch (Exception)
            {
                return StatusCode(500, new ResponseVM { Status = false, Message = "Đã xảy ra lỗi vui lòng thử lại sau!" });
            }

        }
        [HttpGet("get-config-vnpay")]
        [ProducesResponseType(typeof(VNPayConfig), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetVNPayConfig()
        {
            try
            {
                var Configs = await _configService.GetVNPayAsync();
                return Ok(Configs);
            }
            catch (Exception)
            {
                return StatusCode(500, new ResponseVM { Status = false, Message = "Đã xảy ra lỗi vui lòng thử lại sau!" });
            }

        }
        [HttpPut("update-config-vnpay")]
        [ProducesResponseType(typeof(VNPayConfig), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateVNPayConfig([FromBody] UpdateConfigVNPAYRequest request)
        {
            try
            {
                var isUpdated = await _configService.UpdateVNPayConfigAsync(request);

                if (!isUpdated)
                {
                    return NotFound(new ResponseVM
                    {
                        Status = false,
                        Message = "Không tìm thấy cấu hình!",
                    });
                }
                return Ok(new ResponseVM
                {
                    Status = true,
                    Message = "Cập nhật cấu hình thành công!",
                });
            }
            catch (Exception ex)
            {
                //return StatusCode(500, new ResponseVM { Status = false, Message = "Đã xảy ra lỗi vui lòng thử lại sau!" });
                return BadRequest(ex.Message);
            }

        }
    }
}
