using AutoMapper;
using Data.DTO.Request;
using Data.DTO.Respone;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.AccountSer;
using Service.TourCompanySer;
using Service.TouristFacilitySer;
using Service.UserSupportSer;

namespace ATO_API.Controllers
{
    [Route("api/tour-company")]
    [ApiController]
    public class TourCompanyController : ControllerBase
    {
        private readonly ITourCompanyService _tourCompanyService;
        private readonly IMapper _mapper;

        public TourCompanyController(
            ITourCompanyService tourCompanyService,
            IMapper mapper
            )
        {
            _tourCompanyService = tourCompanyService;
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

    }
}
