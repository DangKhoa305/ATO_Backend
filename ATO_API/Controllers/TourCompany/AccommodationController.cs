using AutoMapper;
using Data.DTO.Request;
using Data.DTO.Respone;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Service.AccommodationSer;
using Service.AccountSer;
using Service.DriverSer;
using Service.TourGuideSer;
using System.Text.RegularExpressions;

namespace ATO_API.Controllers.TourCompany
{
    [Route("api/tour-company/accommodation")]
    [ApiController]
    [Authorize(Roles = "TourismCompanies")]
    public class AccommodationController : ControllerBase
    {
        private readonly UserManager<Account> _userManager;
        private readonly RoleManager<IdentityRole<Guid>> _roleManager;
        private readonly IAccountService _accountService;
        private readonly IAccommodationService _accommodationService;
        private readonly IMapper _mapper;

        public AccommodationController(UserManager<Account> userManager,
            RoleManager<IdentityRole<Guid>> roleManager,
            IAccountService accountService,
             IMapper mapper,
             IAccommodationService accommodationService
            )
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _accountService = accountService;
            _mapper = mapper;
            _accommodationService = accommodationService;
        }
        [HttpGet("get-list-accommodations")]
        [ProducesResponseType(typeof(List<AccommodationRespone>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAccommodations()
        {
            try
            {
                var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                var response = await _accommodationService.ListAccommodations(Guid.Parse(userId));
                var responseResult = _mapper.Map<List<AccommodationRespone>>(response);


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
        [HttpGet("get-accommodation/{AccommodationId}")]
        [ProducesResponseType(typeof(AccommodationRespone), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAccommodation(Guid AccommodationId)
        {
            try
            {
                var response = await _accommodationService.GetAccommodation(AccommodationId);
                var responseResult = _mapper.Map<AccommodationRespone>(response);
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
        [HttpPost("add-accommodation")]
        [ProducesResponseType(typeof(AccommodationRequest), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> AddAccommodation([FromBody] AccommodationRequest AccommodationRequest)
        {
            try
            {
                var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                var responseResult = _mapper.Map<Accommodation>(AccommodationRequest);
                var response = await _accommodationService.AddAccommodation(responseResult, Guid.Parse(userId));
                return Ok(AccommodationRequest);
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
        [HttpPut("update-accommodation/{AccommodationId}")]
        [ProducesResponseType(typeof(TourGuideRespone), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateAccommodation(Guid AccommodationId, [FromBody] AccommodationRequest AccommodationRequest)
        {
            try
            {
                var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                var responseResult = _mapper.Map<Accommodation>(AccommodationRequest);
                var response = await _accommodationService.UpdateAccommodation(AccommodationId, responseResult);
                return Ok(AccommodationRequest);
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
