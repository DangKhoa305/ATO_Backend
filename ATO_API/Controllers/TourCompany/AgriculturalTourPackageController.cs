using AutoMapper;
using Data.DTO.Request;
using Data.DTO.Respone;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.AccommodationSer;
using Service.AgriculturalTourPackageSer;

namespace ATO_API.Controllers.TourCompany
{
    [Route("api/tour-company/agricultural-tour-package")]
    [ApiController]
    [Authorize(Roles = "TourismCompanies")]
    public class AgriculturalTourPackageController : ControllerBase
    {
        private readonly IAgriculturalTourPackageService _agriculturalTourPackageService;
        private readonly IMapper _mapper;

        public AgriculturalTourPackageController(
             IMapper mapper,
             IAgriculturalTourPackageService agriculturalTourPackageService
        )
        {
            _mapper = mapper;
            _agriculturalTourPackageService = agriculturalTourPackageService;
        }
        [HttpGet("get-list-agricultural-tour-packages")]
        [ProducesResponseType(typeof(List<AgriculturalTourPackageRespone>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAgriculturalTourPackages()
        {
            try
            {
                var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                var response = await _agriculturalTourPackageService.GetListAgriculturalTourPackages(Guid.Parse(userId));
                var responseResult = _mapper.Map<List<AgriculturalTourPackageRespone>>(response);


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
        [HttpGet("get-agricultural-tour-package/{TourId}")]
        [ProducesResponseType(typeof(AgriculturalTourPackageRespone), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAgriculturalTourPackage(Guid TourId)
        {
            try
            {
                var response = await _agriculturalTourPackageService.GetAgriculturalTourPackage(TourId);
                var responseResult = _mapper.Map<AgriculturalTourPackageRespone>(response);
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
        [HttpPost("add-agricultural-tour-package")]
        [ProducesResponseType(typeof(AgriculturalTourPackageRequest), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> AddAgriculturalTourPackage([FromBody] AgriculturalTourPackageRequest AgriculturalTourPackageRequest)
        {
            try
            {
                var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                var responseResult = _mapper.Map<AgriculturalTourPackage>(AgriculturalTourPackageRequest);
                var response = await _agriculturalTourPackageService.CreateAgriculturalTourPackage(responseResult, Guid.Parse(userId));
                return Ok(AgriculturalTourPackageRequest);
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
        [HttpPut("update-agricultural-tour-package/{TourId}")]
        [ProducesResponseType(typeof(TourGuideRespone), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateAgriculturalTourPackage(Guid TourId, [FromBody] AgriculturalTourPackageRequest AgriculturalTourPackageRequest)
        {
            try
            {
                var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                var responseResult = _mapper.Map<AgriculturalTourPackage>(AgriculturalTourPackageRequest);
                var response = await _agriculturalTourPackageService.UpdateAgriculturalTourPackage(TourId, responseResult);
                return Ok(AgriculturalTourPackageRequest);
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
        [HttpGet("get-tour-destination/{TourDestinationId}")]
        [ProducesResponseType(typeof(AgriculturalTourPackage_TourDestination_Respone), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetTourDestination(Guid TourDestinationId)
        {
            try
            {
                var response = await _agriculturalTourPackageService.GetTourDestination(TourDestinationId);
                var responseResult = _mapper.Map<AgriculturalTourPackage_TourDestination_Respone>(response);
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
        [HttpPost("add-tour-destination/{TourId}")]
        [ProducesResponseType(typeof(TourDestinationRequest), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> AddTourDestination([FromBody] TourDestinationRequest TourDestinationRequest, Guid TourId)
        {
            try
            {
                var responseResult = _mapper.Map<TourDestination>(TourDestinationRequest);
                var response = await _agriculturalTourPackageService.CreateTourDestination(responseResult, TourId);
                return Ok(TourDestinationRequest);
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
        [HttpPut("update-tour-destination/{TourDestinationId}")]
        [ProducesResponseType(typeof(TourDestinationRequest), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateTourDestination(Guid TourDestinationId, [FromBody] TourDestinationRequest TourDestinationRequest)
        {
            try
            {
                var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                var responseResult = _mapper.Map<TourDestination>(TourDestinationRequest);
                var response = await _agriculturalTourPackageService.UpdateTourDestination(TourDestinationId, responseResult);
                return Ok(TourDestinationRequest);
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
