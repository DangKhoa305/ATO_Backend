using AutoMapper;
using Data.DTO.Respone;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.AccountSer;
using Service.TourCompanySer;
using Service.TourismPackageSer;

namespace ATO_API.Controllers.AFTO
{
    [Route("api/afto/tourism-package")]
    [ApiController]
    [Authorize(Roles = "AgriculturalTourismFacilityOwners")]
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
        [ProducesResponseType(typeof(List<TourismPackageRespone>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> ListTourCompany()
        {
            try
            {
                var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                List<Data.Models.TourismPackage> response = await _tourismPackageService.GetListTourismPackages(Guid.Parse(userId));
                List<TourismPackageRespone> responseResult = _mapper.Map<List<TourismPackageRespone>>(response);
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
        [ProducesResponseType(typeof(TourismPackageRespone), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetTourCompany(Guid PackageId)
        {
            try
            {
                Data.Models.TourismPackage response = await _tourismPackageService.GetTourismPackage(PackageId);
                TourismPackageRespone responseResult = _mapper.Map<TourismPackageRespone>(response);
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
