using AutoMapper;
using Data.DTO.Respone;
using Microsoft.AspNetCore.Mvc;
using Service.AgriculturalTourPackageSer;
using Service.TourCompanySer;

namespace ATO_API.Controllers
{
    [Route("api/tour-company")]
    [ApiController]
    public class TourCompanyController : ControllerBase
    {
        private readonly ITourCompanyService _tourCompanyService;
        private readonly IAgriculturalTourPackageService _agriculturalTourPackageService;
        private readonly IMapper _mapper;

        public TourCompanyController(
            ITourCompanyService tourCompanyService,
             IAgriculturalTourPackageService agriculturalTourPackageService,
            IMapper mapper
            )
        {
            _tourCompanyService = tourCompanyService;
            _agriculturalTourPackageService = agriculturalTourPackageService;
            _mapper = mapper;
        }
        [HttpGet("list-tour-companies")]
        [ProducesResponseType(typeof(List<TourCompanyDTO_Guest>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> ListTourCompany()
        {
            try
            {
                List<Data.Models.TourCompany> response = await _tourCompanyService.GetListTourCompanies_Admin();
                List<TourCompanyDTO_Guest> responseResult = _mapper.Map<List<TourCompanyDTO_Guest>>(response);
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
        [HttpGet("get-tour-company/{TourCompanyId}")]
        [ProducesResponseType(typeof(TourCompanyDTO_Guest), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetTourCompany(Guid TourCompanyId)
        {
            try
            {
                Data.Models.TourCompany response = await _tourCompanyService.GetTourCompany_Admin(TourCompanyId);
                TourCompanyDTO_Guest responseResult = _mapper.Map<TourCompanyDTO_Guest>(response);
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

        [HttpGet("package/{companyId}")]
        [ProducesResponseType(typeof(List<AgriculturalTourPackageRespone_Guest>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAgriculturalTourPackages(Guid companyId)
        {
            try
            {
                var response = await _agriculturalTourPackageService.GetListAgriculturalTourPackages_Guest();

                response = response.Where(x => x.TourCompanyId == companyId).ToList();
                var responseResult = _mapper.Map<List<AgriculturalTourPackageRespone_Guest>>(response);
                var result = new List<AgriculturalTourPackageRespone_Guest>();

                foreach (var item in responseResult)
                {
                    item.People = await _agriculturalTourPackageService.GetPeople(item.TourId);
                    result.Add(item);
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

    }
}
