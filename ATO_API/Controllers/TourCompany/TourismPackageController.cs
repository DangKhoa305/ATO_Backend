using AutoMapper;
using Data.DTO.Request;
using Data.DTO.Respone;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.AccountSer;
using Service.TourCompanySer;
using Service.TourismPackageSer;

namespace ATO_API.Controllers.TourCompany
{
    [Route("api/tour-company/tourism-package")]
    [ApiController]
    [Authorize(Roles = "TourismCompanies")]
    public class TourismPackageController : ControllerBase
    {
        private readonly ITourismPackageService _tourismPackageService;
        private readonly IMapper _mapper;

        public TourismPackageController(
            ITourismPackageService tourismPackageService,
            IMapper mapper
            )
        {
            _tourismPackageService = tourismPackageService;
            _mapper = mapper;
        }
        [HttpGet("list-tourism-package")]
        [ProducesResponseType(typeof(List<TourismPackageRespone_TC>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> ListTouristPackages()
        {
            try
            {
                var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                List<Data.Models.TourismPackage> response = await _tourismPackageService.GetListTourism_TC();
                List<TourismPackageRespone_TC> responseResult = _mapper.Map<List<TourismPackageRespone_TC>>(response);
                responseResult.ForEach(x =>
                {
                    var newActivities = x.Activities?.ToList();

                    newActivities?.ForEach(async x =>
                    {
                        x.MaxCapacity = x.MaxCapacity ?? 1;
                        x.CurrentCapacity = await _tourismPackageService.CountCurrentCapacityAsync(x.ActivityId);
                    });

                    x.Activities = newActivities;
                });

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
        [HttpGet("get-tourism-package/{PackageId}")]
        [ProducesResponseType(typeof(TourismPackageRespone_TC), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetTouristPackage(Guid PackageId)
        {
            try
            {
                Data.Models.TourismPackage response = await _tourismPackageService.GetTourismPackage(PackageId);
                TourismPackageRespone_TC responseResult = _mapper.Map<TourismPackageRespone_TC>(response);
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
        [HttpGet("get-activity/{ActivityId}")]
        [ProducesResponseType(typeof(ActivityRespone_TC), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetActivity(Guid ActivityId)
        {
            try
            {
                Activity response = await _tourismPackageService.GetActivity(ActivityId);
                ActivityRespone_TC responseResult = _mapper.Map<ActivityRespone_TC>(response);
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
