using AutoMapper;
using Data.DTO.Respone;
using Data.Models;
using Microsoft.AspNetCore.Mvc;
using Service.TouristFacilitySer;

namespace ATO_API.Controllers
{
    [Route("api/tourist-facility")]
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
        [ProducesResponseType(typeof(List<TouristFacilityDTO_Guest>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> ListTouristFacility()
        {
            try
            {
                List<TouristFacility> response = await _touristFacilityService.GetListTouristFacilities_Admin();
                List<TouristFacilityDTO_Guest> responseResult = _mapper.Map<List<TouristFacilityDTO_Guest>>(response);
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
        [ProducesResponseType(typeof(TouristFacilityDTO_Guest), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetTouristFacility(Guid TouristFacilityId)
        {
            try
            {
                TouristFacility response = await _touristFacilityService.GetTouristFacilities_Guest(TouristFacilityId);
                TouristFacilityDTO_Guest responseResult = _mapper.Map<TouristFacilityDTO_Guest>(response);
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
