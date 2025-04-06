using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO.Respone
{
    public class ShippingTrackingResponse
    {
        public string OrderCode { get; set; }
        public string Status { get; set; }
        public string CurrentLocation { get; set; }
        public DateTime EstimatedDeliveryTime { get; set; }
        public List<ShippingTrackingDetail> TrackingDetails { get; set; }
    }
    public class ShippingTrackingDetail
    {
        public DateTime Timestamp { get; set; }
        public string Location { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
    }
}
