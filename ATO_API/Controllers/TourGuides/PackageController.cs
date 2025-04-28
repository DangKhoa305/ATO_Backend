
using AutoMapper;
using Data.DTO.Respone;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.AgriculturalTourPackageSer;
using Service.BookingTourDestinationSer;

namespace ATO_API.Controllers.TourCompany
{

    [Route("api/tour-guide/tour")]
    [ApiController]
    [Authorize(Roles = "TourGuides")]
    public class PackageController : ControllerBase
    {
        private readonly IAgriculturalTourPackageService _agriculturalTourPackageService;
        private readonly IMapper _mapper;
        private readonly IBookingTourDestinationService _service;

        public PackageController(
             IMapper mapper,
             IAgriculturalTourPackageService agriculturalTourPackageService,
             IBookingTourDestinationService service
        )
        {
            _mapper = mapper;
            _service = service;
            _agriculturalTourPackageService = agriculturalTourPackageService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAgriculturalTourPackages()
        {
            try
            {
                var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                var response = await _agriculturalTourPackageService.GetAllByTourGuideAsync(Guid.Parse(userId!));
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
        [HttpGet("{TourId}")]
        public async Task<IActionResult> GetAsync(Guid TourId)
        {
            try
            {
                var response = await _agriculturalTourPackageService.GetAgriculturalTourPackage(TourId);
                var responseResult = _mapper.Map<AgriculturalTourPackageRespone>(response);

                responseResult.Trackings = await _service.GetAllByTour(responseResult.TourId);
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

