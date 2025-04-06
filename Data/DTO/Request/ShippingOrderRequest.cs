using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO.Request
{
    public class ShippingOrderRequest
    {
        public string FromAddress { get; set; }
        public string ToAddress { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverPhone { get; set; }
        public decimal Weight { get; set; }
        public string Note { get; set; }
    }
}
