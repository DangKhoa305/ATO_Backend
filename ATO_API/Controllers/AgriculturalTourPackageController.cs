using AutoMapper;
using Data.DTO.Respone;
using Microsoft.AspNetCore.Mvc;
using Nest;
using Service;
using Service.AgriculturalTourPackageSer;

namespace ATO_API.Controllers
{
    [Route("api/agricultural-tour-package")]
    [ApiController]
    public class AgriculturalTourPackageController : ControllerBase
    {
        private readonly IAgriculturalTourPackageService _agriculturalTourPackageService;
        private readonly IGeneralService _service;
        private readonly IMapper _mapper;

        public AgriculturalTourPackageController(
             IMapper mapper,
             IAgriculturalTourPackageService agriculturalTourPackageService,
             IGeneralService service
        )
        {
            _mapper = mapper;
            _service = service;
            _agriculturalTourPackageService = agriculturalTourPackageService;
        }
        [HttpGet("get-list-agricultural-tour-packages")]
        [ProducesResponseType(typeof(List<AgriculturalTourPackageRespone_Guest>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAgriculturalTourPackages()
        {
            try
            {
                var response = await _agriculturalTourPackageService.GetListAgriculturalTourPackages_Guest();
                var responseResult = _mapper.Map<List<AgriculturalTourPackageRespone_Guest>>(response);

                var result = new List<AgriculturalTourPackageRespone_Guest>();

                foreach (var item in responseResult)
                {
                    item.People = await _agriculturalTourPackageService.GetPeople(item.GroupId ?? Guid.Empty);

                    var isStarted = await _service.IsTourStarted(item.TourId);
                    if (isStarted is false && item.EndTime > DateTime.Now)
                    {
                        result.Add(item);
                    }
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
        [HttpGet("get-agricultural-tour-package/{TourId}")]
        [ProducesResponseType(typeof(AgriculturalTourPackageRespone_Guest), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAgriculturalTourPackage(Guid TourId)
        {
            try
            {
                var response = await _agriculturalTourPackageService.GetAgriculturalTourPackage(TourId);
                var responseResult = _mapper.Map<AgriculturalTourPackageRespone>(response);
                responseResult.People = await _agriculturalTourPackageService.GetPeople(TourId);

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




    }
}
