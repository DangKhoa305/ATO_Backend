using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO.Respone
{
    public class OCOPProductActivityRespone
    {
        public Guid ActivityId { get; set; }
        public Guid ProductId { get; set; }
        public virtual Activity_OCOPProductActivityRespone? Activity { get; set; }
        public virtual Product_OCOPProductActivityRespone? Product { get; set; }
    }
    public class Activity_OCOPProductActivityRespone
    {
        public Guid ActivityId { get; set; }
        public string ActivityName { get; set; }
    }
    public class Product_OCOPProductActivityRespone
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
    }
}
