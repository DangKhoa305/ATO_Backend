using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO.Respone
{
    public class OCOPSellDTO
    {
        public Guid OCOPSellId { get; set; }
        public double SellVolume { get; set; }
        public double SalePrice { get; set; }
        public DateTime? ManufacturingDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        //FK
        public Guid ProductId { get; set; }
        public virtual ProductDTO? Product { get; set; }
    }
    public class CreateOCOPSellDTO
    {
        public double SellVolume { get; set; }
        public double SalePrice { get; set; }
        public DateTime? ManufacturingDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        //FK
        public Guid ProductId { get; set; }
    }
    public class UpdateOCOPSellDTO
    {
        public double SellVolume { get; set; }
        public double SalePrice { get; set; }
        public DateTime? ManufacturingDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public Guid ProductId { get; set; }
    }
}
