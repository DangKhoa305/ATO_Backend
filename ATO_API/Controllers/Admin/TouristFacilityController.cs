using AutoMapper;
using Data.DTO.Request;
using Data.DTO.Respone;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        private readonly IMapper _mapper;
        public TouristFacilityController(
            ITouristFacilityService touristFacilityService,
            IMapper mapper
            )
        {
            _touristFacilityService = touristFacilityService;
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
    }
}
