using Data.DTO.Request;
using Data.DTO.Respone;
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
    }
}
