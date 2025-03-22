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
using Service.DriverSer;
using Service.TourGuideSer;
using System.Text.RegularExpressions;

namespace ATO_API.Controllers.TourCompany
{
    [Route("api/tour-company/driver")]
    [ApiController]
    [Authorize(Roles = "TourismCompanies")]
    public class DriverController : ControllerBase
    {
        private readonly UserManager<Account> _userManager;
        private readonly RoleManager<IdentityRole<Guid>> _roleManager;
        private readonly IAccountService _accountService;
        private readonly IDriverService _driverService;
        private readonly IMapper _mapper;

        public DriverController(UserManager<Account> userManager,
            RoleManager<IdentityRole<Guid>> roleManager,
            IAccountService accountService,
             IMapper mapper,
             IDriverService driverService
            )
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _accountService = accountService;
            _mapper = mapper;
            _driverService = driverService;
        }
        [HttpGet("get-list-drivers")]
        [ProducesResponseType(typeof(List<DriverRespone>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetDrivers()
        {
            try
            {
                var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                var response = await _driverService.ListDriver(Guid.Parse(userId));
                var responseResult = _mapper.Map<List<DriverRespone>>(response);


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
        [HttpGet("get-driver/{DriverId}")]
        [ProducesResponseType(typeof(DriverRespone), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetDriver(Guid DriverId)
        {
            try
            {
                var response = await _driverService.GetDriver(DriverId);
                var responseResult = _mapper.Map<DriverRespone>(response);
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
        [HttpPost("add-driver")]
        [ProducesResponseType(typeof(DriverRequest), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> AddDriver([FromBody] DriverRequest DriverRequest)
        {
            try
            {
                var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                var responseResult = _mapper.Map<Driver>(DriverRequest);
                var response = await _driverService.AddDriver(responseResult, Guid.Parse(userId));
                return Ok(DriverRequest);
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
        [HttpPut("update-driver/{DriverId}")]
        [ProducesResponseType(typeof(DriverRequest), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateDriver(Guid DriverId, [FromBody] DriverRequest DriverRequest)
        {
            try
            {
                var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                var responseResult = _mapper.Map<Driver>(DriverRequest);
                var response = await _driverService.UpdateDriver(DriverId, responseResult);
                return Ok(DriverRequest);
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
