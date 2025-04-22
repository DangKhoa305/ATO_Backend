using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class ShipAddress
    {
        public Guid ShipAddressId { get; set; }
        public bool DefaultAddress { get; set; }
        public string ToName { get; set; }
        public string ToAddress { get; set; }
        public string ToPhone { get; set; }

        // Province
        public int ToProvinceId { get; set; }
        public string ToProvinceName { get; set; }

        // Ward
        public string ToWardCode { get; set; }
        public string ToWardName { get; set; }

        // District
        public int ToDistrictId { get; set; }
        public string ToDistrictName { get; set; }

        public Guid AccountId { get; set; }
        public virtual Account? Account { get; set; }
    }
}
