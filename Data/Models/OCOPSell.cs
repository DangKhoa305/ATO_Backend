using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class OCOPSell
    {
        public Guid OCOPSellId { get; set; }
        public double SellVolume { get; set; }
        public DateTime? ManufacturingDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        //FK
        public Guid ProductId { get; set; }
        public virtual Product? Product { get; set; }
    }
    
}
