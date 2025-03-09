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
    }
}
