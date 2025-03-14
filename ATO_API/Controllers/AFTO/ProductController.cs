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

namespace ATO_API.Controllers.AFTO
{
    [Route("api/afto/product")]
    [ApiController]
    [Authorize(Roles = "AgriculturalTourismFacilityOwners")]
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
        [ProducesResponseType(typeof(List<ProductDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetProducts()
        {
            try
            {
                // user
                var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                // list products in afto
                var response = await _productService.GetListProducts_AFTO(Guid.Parse(userId));
                List<ProductDTO> responseResult = _mapper.Map<List<ProductDTO>>(response);
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
        [ProducesResponseType(typeof(ProductDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetProduct(Guid productId)
        {
            try
            {
                var response = await _productService.GetProduct_AFTO(productId);
                ProductDTO responseResult = _mapper.Map<ProductDTO>(response);
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
        [HttpPost("create-product")]
        [ProducesResponseType(typeof(object), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateProduct([FromBody] CreateProductDTO newProduct)
        {
            try
            {
                var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                Product responseResult = _mapper.Map<Product>(newProduct);
                bool result = await _productService.CreateProduct_AFTO(responseResult, Guid.Parse(userId));
                if (result)
                {
                    return Ok(new ResponseVM
                    {
                        Status = true,
                        Message = "Tạo mới thành công!",
                    });
                }
                return StatusCode(400, new ResponseVM
                {
                    Status = false,
                    Message = "Tạo mới sản phẩm không thành công!",
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
        [HttpPut("update-product/{ProductId}")]
        [ProducesResponseType(typeof(object), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateProduct(Guid ProductId, [FromBody] UpdateProductDTO updatedProduct)
        {
            try
            {
                Product responseResult = _mapper.Map<Product>(updatedProduct);
                bool result = await _productService.UpdateProduct_AFTO(ProductId, responseResult);
                if (result)
                {
                    return Ok(new ResponseVM
                    {
                        Status = true,
                        Message = "Cập nhật sản phẩm thành công!",
                    });
                }
                return StatusCode(400, new ResponseVM
                {
                    Status = false,
                    Message = "Cập nhật sản phẩm không thành công!",
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
        [HttpGet("get-ocop-sells")]
        [ProducesResponseType(typeof(List<OCOPSellDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetOCOPSells()
        {
            try
            {
                // user
                var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                // list OCOPSell in afto
                var response = await _productService.GetListOCOPSells_AFTO(Guid.Parse(userId));
                List<OCOPSellDTO> responseResult = _mapper.Map<List<OCOPSellDTO>>(response);
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
        [HttpGet("get-ocop-sell/{OCOPSellId}")]
        [ProducesResponseType(typeof(OCOPSellDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetOCOPSell(Guid OCOPSellId)
        {
            try
            {
                var response = await _productService.GetOCOPSell_AFTO(OCOPSellId);
                OCOPSellDTO responseResult = _mapper.Map<OCOPSellDTO>(response);
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
        [HttpPost("create-ocop-sell")]
        [ProducesResponseType(typeof(object), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateOCOPSell([FromBody] CreateOCOPSellDTO newOCOPSellDTO)
        {
            try
            {
                OCOPSell responseResult = _mapper.Map<OCOPSell>(newOCOPSellDTO);
                bool result = await _productService.CreateOCOPSell_AFTO(responseResult);
                if (result)
                {
                    return Ok(new ResponseVM
                    {
                        Status = true,
                        Message = "Tạo mới thành công!",
                    });
                }
                return StatusCode(400, new ResponseVM
                {
                    Status = false,
                    Message = "Tạo mới không thành công!",
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
        [HttpPut("update-ocop-sell/{OCOPSellId}")]
        [ProducesResponseType(typeof(object), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateOCOPSell(Guid OCOPSellId, [FromBody] UpdateOCOPSellDTO updateOCOPSellDTO)
        {
            try
            {
                OCOPSell responseResult = _mapper.Map<OCOPSell>(updateOCOPSellDTO);
                bool result = await _productService.UpdateOCOPSell_AFTO(OCOPSellId, responseResult);
                if (result)
                {
                    return Ok(new ResponseVM
                    {
                        Status = true,
                        Message = "Cập nhật sản phẩm thành công!",
                    });
                }
                return StatusCode(400, new ResponseVM
                {
                    Status = false,
                    Message = "Cập nhật sản phẩm không thành công!",
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
        [HttpGet("get-ocop-sells-by-productid/{ProductId}")]
        [ProducesResponseType(typeof(List<OCOPSellDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetOCOPSellsByProductId(Guid ProductId)
        {
            try
            {
                var response = await _productService.GetListOCOPSellsByProductId_AFTO(ProductId);
                List<OCOPSellDTO> responseResult = _mapper.Map<List<OCOPSellDTO>>(response);
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
        [HttpGet("get-certification-by-productid/{ProductId}")]
        [ProducesResponseType(typeof(List<CertificationRespone>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetCertificationByProductId(Guid ProductId)
        {
            try
            {
                var response = await _productService.GetListCertificationsByProductId_AFTO(ProductId);
                List<CertificationRespone> responseResult = _mapper.Map<List<CertificationRespone>>(response);
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
        [ProducesResponseType(typeof(CertificationRespone), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetCertification(Guid CertificationId)
        {
            try
            {
                var response = await _productService.GetCertification_AFTO(CertificationId);
                CertificationRespone responseResult = _mapper.Map<CertificationRespone>(response);
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
        [HttpPost("create-certification")]
        [ProducesResponseType(typeof(object), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateCertification([FromBody] CreateCertificationDTO createCertificationDTO)
        {
            try
            {
                var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                Certification responseResult = _mapper.Map<Certification>(createCertificationDTO);
                bool result = await _productService.CreateCertification_AFTO(responseResult, Guid.Parse(userId));
                if (result)
                {
                    return Ok(new ResponseVM
                    {
                        Status = true,
                        Message = "Tạo mới thành công!",
                    });
                }
                return StatusCode(400, new ResponseVM
                {
                    Status = false,
                    Message = "Tạo mới không thành công!",
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
        [HttpPut("update-certification/{CertificationId}")]
        [ProducesResponseType(typeof(object), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateCertification(Guid CertificationId, [FromBody] UpdateCertificationDTO updateCertificationDTO)
        {
            try
            {
                Certification responseResult = _mapper.Map<Certification>(updateCertificationDTO);
                bool result = await _productService.UpdateCertification_AFTO(CertificationId, responseResult);
                if (result)
                {
                    return Ok(new ResponseVM
                    {
                        Status = true,
                        Message = "Cập nhật chứng nhận thành công!",
                    });
                }
                return StatusCode(400, new ResponseVM
                {
                    Status = false,
                    Message = "Cập nhật chứng nhận không thành công!",
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
