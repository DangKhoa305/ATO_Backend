using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO.Request
{
    public class OCOPProductActivityRequest
    {
        public Guid ActivityId { get; set; }
        public Guid ProductId { get; set; }
    }
}
