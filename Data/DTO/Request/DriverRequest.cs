using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO.Request
{
    public class DriverRequest
    {
        public string DriverName { get; set; }
        public string PhoneNumber { get; set; }
        public VehicleType VehicleType { get; set; }
        public List<string>? Imgs { get; set; }
    }
}
