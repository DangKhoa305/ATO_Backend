using AutoMapper;
using Azure;
using Data.DTO.Request;
using Data.DTO.Respone;
using Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nest;
using Service.BlogSer;
using Service.ProductSer;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Model;

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
                List<ProductDTO_Guest> newResult = new();

                foreach (var item in responseResult)
                {
                    var ocops = await _productService.GetListOCOPSellsByProductId_AFTO(item.ProductId, false);
                    var variations = _mapper.Map<List<OCOPSellDTO>>(ocops
                            .Where(x => x.ActiveStatus == true))
                        .Where(x => x.SellVolume > 0)
                          .OrderBy(x => x.ExpiryDate);
                    foreach (var variation in variations)
                    {
                        newResult.Add(new ProductDTO_Guest()
                        {
                            Additional = item.Additional,
                            AddressManufacturer = item.AddressManufacturer,
                            Age = item.Age,
                            Certifications = item.Certifications,
                            Description = item.Description,
                            ExpirationDate = variation.ExpiryDate ?? DateTime.Now,
                            Imgs = item.Imgs,
                            Ingredient = item.Ingredient,
                            Manufacturer = item.Manufacturer,
                            NutritionType = item.NutritionType,
                            Origin = item.Origin,
                            Price = variation.SalePrice,
                            ProductCategory = item.ProductCategory,
                            ProductId = item.ProductId,
                            ProductName = item.ProductName,
                            SellVolume = item.SellVolume,
                            TouristFacility = item.TouristFacility,
                            TouristFacilityId = item.TouristFacilityId,
                            UnitProduct = item.UnitProduct,
                            Variations = item.Variations,
                            Volume = item.Volume,
                            OcopId = variation.OCOPSellId
                        });
                    }
                }


                return Ok(newResult);
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
        [HttpGet("get-product/{productId}/{ocopId}")]
        [ProducesResponseType(typeof(ProductDTO_Guest), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseVM), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetProduct(Guid productId, Guid ocopId)
        {
            try
            {
                var product = await _productService.GetProduct_Guest(productId);
                var item = _mapper.Map<ProductDTO_Guest>(product);

                var ocops = await _productService.GetListOCOPSellsByProductId_AFTO(productId);
                var ocop = ocops.Where(x => x.OCOPSellId == ocopId).FirstOrDefault();
                var variation = _mapper.Map<OCOPSellDTO>(ocop);

                return Ok(new ProductDTO_Guest()
                {
                    Additional = item.Additional,
                    AddressManufacturer = item.AddressManufacturer,
                    Age = item.Age,
                    Certifications = item.Certifications,
                    Description = item.Description,
                    ExpirationDate = variation.ExpiryDate ?? DateTime.Now,
                    Imgs = item.Imgs,
                    Ingredient = item.Ingredient,
                    Manufacturer = item.Manufacturer,
                    NutritionType = item.NutritionType,
                    Origin = item.Origin,
                    Price = variation.SalePrice,
                    ProductCategory = item.ProductCategory,
                    ProductId = item.ProductId,
                    ProductName = item.ProductName,
                    SellVolume = variation.SellVolume,
                    TouristFacility = item.TouristFacility,
                    TouristFacilityId = item.TouristFacilityId,
                    UnitProduct = item.UnitProduct,
                    Variations = item.Variations,
                    Volume = item.Volume
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