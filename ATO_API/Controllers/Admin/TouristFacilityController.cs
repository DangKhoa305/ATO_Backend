using AutoMapper;
using Data.DTO.Request;
using Data.DTO.Respone;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.AccountSer;
using Service.TouristFacilitySer;
using Service.UserSupportSer;

namespace ATO_API.Controllers.Admin
{
    [Route("api/admin/tourist-facility")]
    [Authorize(Roles = "Admin")]
    [ApiController]
    public class TouristFacilityController : ControllerBase
    {
        private readonly ITouristFacilityService _touristFacilityService;
        private readonly IAccountService _accountService;
        private readonly IMapper _mapper;
        public TouristFacilityController(
            ITouristFacilityService touristFacilityService,
            IAccountService accountService,
            IMapper mapper
            )
        {
            _touristFacilityService = touristFacilityService;
            _accountService = accountService;
            _mapper = mapper;
        }
        [HttpGet("list-tourist-facilities")]
        [ProducesResponseType(typeof(List<TouristFacilityDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> ListTouristFacility()
        {
            try
            {
                List<TouristFacility> response = await _touristFacilityService.GetListTouristFacilities_Admin();
                List<TouristFacilityDTO> responseResult = _mapper.Map<List<TouristFacilityDTO>>(response);
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
        [HttpGet("get-tourist-facility/{TouristFacilityId}")]
        [ProducesResponseType(typeof(TouristFacilityDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetTouristFacility(Guid TouristFacilityId)
        {
            try
            {
                TouristFacility response = await _touristFacilityService.GetTouristFacilities_Admin(TouristFacilityId);
                TouristFacilityDTO responseResult = _mapper.Map<TouristFacilityDTO>(response);
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
        [HttpPost("create-tourist-facility")]
        [ProducesResponseType(typeof(TouristFacilityDTO), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateTouristFacility([FromBody] CreateTouristFacilityRequest request)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(request.TouristFacilityName))
                {
                    return BadRequest(new ResponseVM
                    {
                        Status = false,
                        Message = "Tên đơn vị cung cấp không được để trống."
                    });
                }
                if (request.UserId == Guid.Empty)
                {
                    return BadRequest(new ResponseVM
                    {
                        Status = false,
                        Message = "Quản lý đơn vị cung cấp không được để trống!"
                    });
                }

                var newTourCompany = _mapper.Map<TouristFacility>(request);
                newTourCompany.TouristFacilityId = Guid.NewGuid();
                newTourCompany.CreateDate = DateTime.UtcNow;

                await _touristFacilityService.AddTouristFacilitiesAsync(newTourCompany);

                var response = _mapper.Map<TouristFacilityDTO>(newTourCompany);
                return CreatedAtAction(nameof(GetTouristFacility), new { TouristFacilityId = newTourCompany.TouristFacilityId }, response);
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
        [HttpPut("update-tourist-facility")]
        [ProducesResponseType(typeof(TouristFacilityDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateTouristFacility([FromBody] UpdateTouristFacilityRequest request)
        {
            try
            {
                if (request.TouristFacilityId == Guid.Empty)
                {
                    return BadRequest(new ResponseVM
                    {
                        Status = false,
                        Message = "Id không hợp lệ."
                    });
                }

                if (string.IsNullOrWhiteSpace(request.TouristFacilityName))
                {
                    return BadRequest(new ResponseVM
                    {
                        Status = false,
                        Message = "Tên đơn vị cung cấp không được để trống."
                    });
                }

                if (request.UserId == Guid.Empty)
                {
                    return BadRequest(new ResponseVM
                    {
                        Status = false,
                        Message = "Quản lý đơn vị cung cấp không được để trống!"
                    });
                }

                var existingTouristFacility = await _touristFacilityService.GetTouristFacilities_Admin(request.TouristFacilityId);
                if (existingTouristFacility == null)
                {
                    return NotFound(new ResponseVM
                    {
                        Status = false,
                        Message = "Không tìm thấy đơn vị cung cấp."
                    });
                }

                _mapper.Map(request, existingTouristFacility);
                existingTouristFacility.UpdateTime = DateTime.UtcNow;

                await _touristFacilityService.UpdateTouristFacilitiesAsync(existingTouristFacility);
                var response = _mapper.Map<TouristFacilityDTO>(existingTouristFacility);
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
        [HttpGet("unassigned-tour-facility")]
        [ProducesResponseType(typeof(IEnumerable<UserUnassignedTourCompany>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetUnassignedTouristFacilities()
        {
            try
            {
                var tourCompanies = await _accountService.GetUnassignedTouristFacilitiesAsync();

                var response = _mapper.Map<IEnumerable<UserUnassignedTourCompany>>(tourCompanies);
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
    }
}
