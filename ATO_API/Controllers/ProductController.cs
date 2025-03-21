using AutoMapper;
using Azure;
using Data.DTO.Request;
using Data.DTO.Respone;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.BlogSer;
using Service.ProductSer;

namespace ATO_API.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        public ProductController(
            IProductService productService,
            IMapper mapper
        )
        {
            _productService = productService;
            _mapper = mapper;
        }
        [HttpGet("get-products")]
        [ProducesResponseType(typeof(List<ProductDTO_Guest>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetProducts()
        {
            try
            {
                var response = await _productService.GetListProducts_Guest();
                List<ProductDTO_Guest> responseResult = _mapper.Map<List<ProductDTO_Guest>>(response);
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
        [HttpGet("get-product/{productId}")]
        [ProducesResponseType(typeof(ProductDTO_Guest), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetProduct(Guid productId)
        {
            try
            {
                var response = await _productService.GetProduct_Guest(productId);
                ProductDTO_Guest responseResult = _mapper.Map<ProductDTO_Guest>(response);
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
