using AutoMapper;
using Data.DTO.Respone;
using Data.Models;
using Microsoft.AspNetCore.Mvc;
using Service.FacilityCertificationSer;
using Service.ProductSer;
using Service.TouristFacilitySer;

namespace ATO_API.Controllers
{
    [Route("api/tourist-facility")]
    [ApiController]
    public class TouristFacilityController : ControllerBase
    {
        private readonly ITouristFacilityService _touristFacilityService;
        private readonly IFacilityCertificationService _certificationService;
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        public TouristFacilityController(
            ITouristFacilityService touristFacilityService,
            IFacilityCertificationService certificationService,
            IProductService productService,
            IMapper mapper
            )
        {
            _touristFacilityService = touristFacilityService;
            _certificationService = certificationService;
            _productService = productService;
            _mapper = mapper;
        }
        [HttpGet]
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
        [HttpGet("{TouristFacilityId}")]
        [ProducesResponseType(typeof(TouristFacilityDTO_Guest), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetTouristFacility(Guid TouristFacilityId)
        {
            try
            {
                var response = await _touristFacilityService.GetTouristFacilities_Guest(TouristFacilityId);
                var responseResult = _mapper.Map<TouristFacilityDTO_Guest>(response);


                responseResult.Certifications = await _certificationService.GetAllByFacilityAsync(TouristFacilityId);
                var rawProducts = await _productService.GetListProducts_Guest();
                var products = _mapper.Map<List<ProductDTO_Guest>>(
                    rawProducts.Where(x => x.TouristFacilityId == TouristFacilityId).ToList());

                responseResult.Products = products;

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
