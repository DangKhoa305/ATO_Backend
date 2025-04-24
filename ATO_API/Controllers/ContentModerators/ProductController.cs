using AutoMapper;
using Data.DTO.Request;
using Data.DTO.Respone;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.ProductSer;

namespace ATO_API.Controllers.ContentModerators
{
    [Route("api/content-moderators/product")]
    [ApiController]
    [Authorize(Roles = "ContentModerators")]
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
        [HttpPut("approvel-certification/{CertificationId}")]
        [ProducesResponseType(typeof(object), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> ApprovelCertification(Guid CertificationId, [FromBody] ApprovelCertificationDTO updateCertificationDTO)

        {
            try
            {
                Certification responseResult = _mapper.Map<Certification>(updateCertificationDTO);
                bool result = await _productService.ApprovelCertification_CM(CertificationId, responseResult);
                if (result)
                {
                    return Ok(new ResponseVM
                    {
                        Status = true,
                        Message = "Cập nhật thành công!",
                    });
                }
                return StatusCode(400, new ResponseVM
                {
                    Status = false,
                    Message = "Cập nhật không thành công!",
                });
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
        [HttpGet("get-certifications")]
        [ProducesResponseType(typeof(List<CertificationRespone_CM>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetCertification()
        {
            try
            {
                var response = await _productService.GetListCertifications_CM();
                List<CertificationRespone_CM> responseResult = _mapper.Map<List<CertificationRespone_CM>>(response);
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
        [HttpGet("get-certification/{CertificationId}")]
        [ProducesResponseType(typeof(CertificationRespone_CM), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetCertification(Guid CertificationId)
        {
            try
            {
                var response = await _productService.GetCertification_CM(CertificationId);
                CertificationRespone_CM responseResult = _mapper.Map<CertificationRespone_CM>(response);
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
        [HttpGet("get-products")]
        [ProducesResponseType(typeof(List<ProductDTO_CM>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetProducts()
        {
            try
            {
                var response = await _productService.GetListProducts_CM();
                List<ProductDTO_CM> responseResult = _mapper.Map<List<ProductDTO_CM>>(response);
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
        [ProducesResponseType(typeof(ProductDTO_CM), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetProduct(Guid productId)
        {
            try
            {
                var response = await _productService.GetProduct_CM(productId);
                ProductDTO_CM responseResult = _mapper.Map<ProductDTO_CM>(response);
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
        [HttpPut("approvel-products/{ProductId}")]
        [ProducesResponseType(typeof(object), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> ApprovelProduct(Guid ProductId, [FromBody] ApprovelProductDTO approvelProductDTO)

        {
            try
            {
                Product responseResult = _mapper.Map<Product>(approvelProductDTO);
                bool result = await _productService.ApprovelProduct_CM(ProductId, responseResult);
                if (result)
                {
                    return Ok(new ResponseVM
                    {
                        Status = true,
                        Message = "Cập nhật thành công!",
                    });
                }
                return StatusCode(400, new ResponseVM
                {
                    Status = false,
                    Message = "Cập nhật không thành công!",
                });
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
