using Data.Models;
using Microsoft.EntityFrameworkCore;
using Service.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.ProductSer
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _productRepository;
        private readonly IRepository<TouristFacility> _touristFacilityRepository;
        private readonly IRepository<OCOPSell> _OCOPSellRepository;
        public ProductService(
            IRepository<Product> productRepository,
            IRepository<TouristFacility> touristFacilityRepository,
            IRepository<OCOPSell> OCOPSellRepository
            )
        {
            _productRepository = productRepository;
            _touristFacilityRepository = touristFacilityRepository;
            _OCOPSellRepository = OCOPSellRepository;
        }

        public async Task<List<OCOPSell>> GetListOCOPSells_AFTO(Guid UserId)
        {
            try
            {
                TouristFacility TouristFacility = await _touristFacilityRepository.Query()
                    .SingleOrDefaultAsync(x => x.UserId == UserId);
                return await _OCOPSellRepository.Query()
                    .Include(x => x.Product)
                    .Where(x => x.Product.TouristFacilityId == TouristFacility.TouristFacilityId)
                    .ToListAsync();
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }
        public async Task<List<OCOPSell>> GetListOCOPSellsByProductId_AFTO(Guid ProductId)
        {
            try
            {
                return await _OCOPSellRepository.Query()
                    .Include(x => x.Product)
                    .Where(x => x.ProductId == ProductId)
                    .ToListAsync();
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }
        public async Task<OCOPSell> GetOCOPSell_AFTO(Guid OCOPSellId)
        {
            try
            {
                return await _OCOPSellRepository.Query()
                    .Include(x => x.Product)
                    .SingleOrDefaultAsync(x => x.OCOPSellId == OCOPSellId);
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }
        public async Task<List<Product>> GetListProducts_AFTO(Guid UserId)
        {
            try
            {
                TouristFacility TouristFacility = await _touristFacilityRepository.Query()
                    .SingleOrDefaultAsync(x => x.UserId == UserId);
                return await _productRepository.Query()
                    .Where(x => x.TouristFacilityId == TouristFacility.TouristFacilityId)
                    .ToListAsync();
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }
        public async Task<Product> GetProduct_AFTO(Guid ProductId)
        {
            try
            {
                return await _productRepository.Query()
                    .SingleOrDefaultAsync(x => x.ProductId == ProductId);
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }
        public async Task<bool> CreateOCOPSell_AFTO(OCOPSell newOCOPSell)
        {
            try
            {
                newOCOPSell.OCOPSellId = Guid.NewGuid();
                newOCOPSell.CreateDate = DateTime.UtcNow;

                await _OCOPSellRepository.AddAsync(newOCOPSell);

                return true;
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }
        public async Task<bool> UpdateOCOPSell_AFTO(Guid OCOPSellId, OCOPSell updatedOCOPSell)
        {
            try
            {
                OCOPSell existingOCOPSell = await _OCOPSellRepository.Query()
                    .SingleOrDefaultAsync(x => x.OCOPSellId == OCOPSellId);

                if (existingOCOPSell == null)
                {
                    throw new Exception("Không tìm thấy sản phẩm bán ra!");
                }

                existingOCOPSell.SellVolume = updatedOCOPSell.SellVolume;
                existingOCOPSell.ManufacturingDate = updatedOCOPSell.ManufacturingDate;
                existingOCOPSell.ExpiryDate = updatedOCOPSell.ExpiryDate;
                existingOCOPSell.UpdateDate = DateTime.UtcNow;
                existingOCOPSell.SalePrice = updatedOCOPSell.SalePrice;

                await _OCOPSellRepository.UpdateAsync(existingOCOPSell);

                return true;
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }
        public async Task<bool> CreateProduct_AFTO(Product newProduct, Guid UserId)
        {
            try
            {
                TouristFacility TouristFacility = await _touristFacilityRepository.Query()
                    .SingleOrDefaultAsync(x => x.UserId == UserId);
                newProduct.ProductId = Guid.NewGuid();
                newProduct.TouristFacilityId = TouristFacility.TouristFacilityId;
                newProduct.CreateDate = DateTime.UtcNow;
                await _productRepository.AddAsync(newProduct);

                return true;
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }
        public async Task<bool> UpdateProduct_AFTO(Guid ProductId, Product updatedProduct)
        {
            try
            {
                Product existingProduct = await _productRepository.Query()
                    .SingleOrDefaultAsync(x => x.ProductId == ProductId);

                if (existingProduct == null)
                {
                    throw new Exception("Không tìm thấy sản phẩm!");
                }

                existingProduct.ProductName = updatedProduct.ProductName;
                existingProduct.Description = updatedProduct.Description;
                existingProduct.Imgs = updatedProduct.Imgs;
                existingProduct.Price = updatedProduct.Price;
                existingProduct.Additional = updatedProduct.Additional;
                existingProduct.NutritionType = updatedProduct.NutritionType;
                existingProduct.Age = updatedProduct.Age;
                existingProduct.Ingredient = updatedProduct.Ingredient;
                existingProduct.Volume = updatedProduct.Volume;
                existingProduct.Origin = updatedProduct.Origin;
                existingProduct.Manufacturer = updatedProduct.Manufacturer;
                existingProduct.AddressManufacturer = updatedProduct.AddressManufacturer;
                existingProduct.UnitProduct = updatedProduct.UnitProduct;
                existingProduct.UpdateDate = DateTime.UtcNow;

                await _productRepository.UpdateAsync(existingProduct);

                return true;
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }

    }
}
