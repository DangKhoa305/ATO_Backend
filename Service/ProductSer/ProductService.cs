using Data.Models;
using Microsoft.EntityFrameworkCore;
using Service.Repository;
using System.Collections.Frozen;

namespace Service.ProductSer
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _productRepository;
        private readonly IRepository<TouristFacility> _touristFacilityRepository;
        private readonly IRepository<OCOPSell> _OCOPSellRepository;
        private readonly IRepository<Certification> _certificationRepository;
        public ProductService(
            IRepository<Product> productRepository,
            IRepository<TouristFacility> touristFacilityRepository,
            IRepository<OCOPSell> OCOPSellRepository,
            IRepository<Certification> certificationRepository
            )
        {
            _productRepository = productRepository;
            _touristFacilityRepository = touristFacilityRepository;
            _OCOPSellRepository = OCOPSellRepository;
            _certificationRepository = certificationRepository;
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
        public async Task<List<OCOPSell>> GetListOCOPSellsByProductId_AFTO(Guid ProductId, bool? showAll = true)
        {
            try
            {
                if (showAll == true)
                {
                    return await _OCOPSellRepository.Query()
                   .Include(x => x.Product)
                   .Where(x => x.ProductId == ProductId)
                   .ToListAsync();
                }
                else
                {
                    return await _OCOPSellRepository.Query()
                     .Include(x => x.Product)
                     .Where(x => x.SellVolume > 0)
                     .Where(x => x.ExpiryDate > DateTime.Now)
                     .Where(x => x.ProductId == ProductId)
                     .Where(x => x.ActiveStatus == true)
                     .ToListAsync();
                }
            }
            catch (Exception ex)
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
                    .OrderByDescending(x => x.CreateDate)
                    .ToListAsync();
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }

        public async Task<bool> AnyOcopAsync(OCOPSell newOCOPSell)
            => await _OCOPSellRepository.Query()
                .Where(x => x.SellVolume == newOCOPSell.SellVolume)
                .Where(x => x.SalePrice == newOCOPSell.SalePrice)
                .Where(x => x.ManufacturingDate == newOCOPSell.ManufacturingDate)
                .Where(x => x.ExpiryDate == newOCOPSell.ExpiryDate)
                .Where(x => x.ProductId == newOCOPSell.ProductId)
                .AnyAsync();

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


        public async Task<bool> UpdateStatusAsync(Guid OCOPSellId, StatusActive status)
        {
            try
            {
                var existingOCOPSell = await _OCOPSellRepository.Query()
                    .SingleOrDefaultAsync(x => x.OCOPSellId == OCOPSellId);

                if (existingOCOPSell == null)
                {
                    throw new Exception("Không tìm thấy sản phẩm bán ra!");
                }

                existingOCOPSell.ActiveStatus = status == StatusActive.active;

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
                existingProduct.StatusApproval = StatusApproval.Update;
                existingProduct.ProductCategory = updatedProduct.ProductCategory;
                await _productRepository.UpdateAsync(existingProduct);

                return true;
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }

        public async Task<List<Certification>> GetListCertificationsByProductId_AFTO(Guid productId)
        {
            try
            {
                return await _certificationRepository.Query()
                    .Where(x => x.ProductId == productId)
                    .ToListAsync();
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }
        public async Task<Certification> GetCertification_AFTO(Guid CertificationId)
        {
            try
            {
                return await _certificationRepository.Query()
                    .FirstOrDefaultAsync(x => x.CertificationId == CertificationId);
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }
        public async Task<bool> CreateCertification_AFTO(Certification certification, Guid UserId)
        {
            try
            {
                TouristFacility TouristFacility = await _touristFacilityRepository.Query()
                    .SingleOrDefaultAsync(x => x.UserId == UserId);
                certification.CertificationId = Guid.NewGuid();
                certification.TouristFacilityId = TouristFacility.TouristFacilityId;
                certification.CreateDate = DateTime.UtcNow;
                certification.StatusApproval = StatusApproval.Processing;
                await _certificationRepository.AddAsync(certification);

                return true;
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }
        public async Task<bool> UpdateCertification_AFTO(Guid CertificationId, Certification certification)
        {
            try
            {
                Certification existingCertification = await _certificationRepository.Query()
                    .SingleOrDefaultAsync(x => x.CertificationId == CertificationId);

                if (existingCertification == null)
                {
                    throw new Exception("Không tìm thấy chứng nhận!");
                }

                existingCertification.ProductId = certification.ProductId;
                existingCertification.CertificationName = certification.CertificationName;
                existingCertification.IssueDate = certification.IssueDate;
                existingCertification.ExpiryDate = certification.ExpiryDate;
                existingCertification.CertificationDetails = certification.CertificationDetails;
                existingCertification.IssuingOrganization = certification.IssuingOrganization;
                existingCertification.UpdateDate = DateTime.UtcNow;
                existingCertification.StatusApproval = StatusApproval.Update;
                existingCertification.Imgs = certification.Imgs;
                await _certificationRepository.UpdateAsync(existingCertification);

                return true;
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }
        public async Task<bool> ApprovelCertification_CM(Guid CertificationId, Certification certification)
        {
            try
            {
                Certification existingCertification = await _certificationRepository.Query()
                    .SingleOrDefaultAsync(x => x.CertificationId == CertificationId);

                if (existingCertification == null)
                {
                    throw new Exception("Không tìm thấy chứng nhận!");
                }

                existingCertification.StatusApproval = certification.StatusApproval;
                existingCertification.ReplyRequest = certification.ReplyRequest;
                existingCertification.UpdateDate = DateTime.UtcNow;

                await _certificationRepository.UpdateAsync(existingCertification);

                return true;
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }
        public async Task<List<Certification>> GetListCertifications_CM()
        {
            try
            {
                return await _certificationRepository.Query()
                    .Include(x => x.Product)
                    .Include(x => x.TouristFacility)
                    .OrderByDescending(x => x.CreateDate)
                    .ToListAsync();
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }
        public async Task<Certification> GetCertification_CM(Guid CertificationId)
        {
            try
            {
                return await _certificationRepository.Query()
                    .Include(x => x.Product)
                    .Include(x => x.TouristFacility)
                    .FirstOrDefaultAsync(x => x.CertificationId == CertificationId);
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }
        public async Task<List<Product>> GetListProducts_CM()
        {
            try
            {
                return await _productRepository.Query()
                    .Include(x => x.Certifications)
                    .Include(x => x.TouristFacility)
                    .ToListAsync();
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }
        public async Task<Product> GetProduct_CM(Guid ProductId)
        {
            try
            {
                return await _productRepository.Query()
                    .Include(x => x.Certifications)
                    .Include(x => x.TouristFacility)
                    .SingleOrDefaultAsync(x => x.ProductId == ProductId);
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }
        public async Task<bool> ApprovelProduct_CM(Guid ProductId, Product updatedProduct)
        {
            try
            {
                Product existingProduct = await _productRepository.Query()
                    .SingleOrDefaultAsync(x => x.ProductId == ProductId);

                if (existingProduct == null)
                {
                    throw new Exception("Không tìm thấy sản phẩm!");
                }

                existingProduct.StatusApproval = updatedProduct.StatusApproval;
                existingProduct.ReplyRequest = updatedProduct.ReplyRequest;
                existingProduct.UpdateDate = DateTime.UtcNow;

                await _productRepository.UpdateAsync(existingProduct);

                return true;
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }
        public async Task<List<Product>> GetListProducts_Guest()
        {
            try
            {
                return await _productRepository.Query()
                    .Include(x => x.TouristFacility)
                    .Include(b => b.Certifications)
                    .Include(b => b.OCOPSells)
                    .Where(x => x.OCOPSells.Where(p => p.ActiveStatus == true && p.ExpiryDate > DateTime.UtcNow).Any())
                    .Where(x => x.Certifications.Where(a => a.StatusApproval == StatusApproval.Approved).Any())
                    .ToListAsync();
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }
        public async Task<Product> GetProduct_Guest(Guid ProductId)
        {
            try
            {
                return await _productRepository.Query()
                    .Include(x => x.TouristFacility)
                     .Include(b => b.Certifications.Where(a => a.ProductId == ProductId && a.StatusApproval == StatusApproval.Approved))
                    .Include(x => x.OCOPSells.Where(p => p.ExpiryDate == null || p.ExpiryDate > DateTime.UtcNow))
                    .Where(x => x.OCOPSells.Any())
                    .Where(x => x.Certifications.Any())
                    .SingleOrDefaultAsync(x => x.ProductId == ProductId);
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }
    }
}
