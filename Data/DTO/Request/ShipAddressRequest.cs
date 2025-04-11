using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO.Respone
{
    public class ShipAddressRequest
    {
        public Guid ShipAddressId { get; set; }
        public bool DefaultAddress { get; set; }
        public string ToName { get; set; }
        public string ToPhone { get; set; }
        public string ToWardCode { get; set; }
        public int ToDistrictId { get; set; }
    }
}
