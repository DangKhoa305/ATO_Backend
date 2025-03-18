using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class OCOPProductActivity
    {
        public Guid ActivityId { get; set; }
        public Guid ProductId { get; set; }
        public virtual Activity? Activity { get; set; }
        public virtual Product? Product { get; set; }
    }
}
