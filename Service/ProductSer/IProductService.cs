using Data.DTO.Respone;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.ProductSer
{
    public interface IProductService
    {
        // product
        Task<List<Product>> GetListProducts_AFTO(Guid UserId);
        Task<Product> GetProduct_AFTO(Guid ProductId);
        Task<bool> CreateProduct_AFTO(Product newProduct, Guid UserId);
        Task<bool> UpdateProduct_AFTO(Guid ProductId, Product updatedProduct);
        // sale product
        Task<List<OCOPSell>> GetListOCOPSells_AFTO(Guid UserId);
        Task<OCOPSell> GetOCOPSell_AFTO(Guid OCOPSellId);
        Task<bool> CreateOCOPSell_AFTO(OCOPSell newOCOPSell);
        Task<bool> UpdateOCOPSell_AFTO(Guid OCOPSellId, OCOPSell updatedOCOPSell);
        Task<List<OCOPSell>> GetListOCOPSellsByProductId_AFTO(Guid ProductId);
        Task<List<Certification>> GetListCertificationsByProductId_AFTO(Guid productId);
        Task<Certification> GetCertification_AFTO(Guid CertificationId);
        Task<bool> CreateCertification_AFTO(Certification certification, Guid UserId);
        Task<bool> UpdateCertification_AFTO(Guid CertificationId, Certification certification);
        Task<bool> ApprovelCertification_CM(Guid CertificationId, Certification certification);
        Task<List<Certification>> GetListCertifications_CM();
        Task<Certification> GetCertification_CM(Guid CertificationId);
        Task<List<Product>> GetListProducts_CM();
        Task<Product> GetProduct_CM(Guid ProductId);
        Task<bool> ApprovelProduct_CM(Guid ProductId, Product updatedProduct);
        Task<List<OCOPProductActivity>> GetListOCOPProductActivityByProductId_AFTO(Guid productId);
        Task<bool> CreateOCOPProductActivity_AFTO(OCOPProductActivity responseResult);
        Task<bool> UpdateOCOPProductActivity_AFTO(Guid activityOldId, OCOPProductActivity responseResult);
        Task<List<OCOPProductActivity>> GetListOCOPProductActivityByActivityId_AFTO(Guid activityId);
        Task<List<Product>> GetListProducts_Guest();
        Task<Product> GetProduct_Guest(Guid ProductId);
    }
}
