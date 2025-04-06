using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO.Respone
{
    public class ShippingOrderResponse
    {
        public string OrderCode { get; set; }
        public string Status { get; set; }
        public decimal ShippingFee { get; set; }
        public DateTime ExpectedDeliveryTime { get; set; }
        public string TrackingUrl { get; set; }

        // Shipping information
        public string FromAddress { get; set; }
        public string ToAddress { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverPhone { get; set; }

        // Package information
        public decimal Weight { get; set; }
        public string Note { get; set; }

        // Error handling
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
