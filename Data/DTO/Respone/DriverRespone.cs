using Data.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO.Respone
{
    public class DriverRespone
    {
        public Guid DriverId { get; set; }
        public string DriverName { get; set; }
        public string PhoneNumber { get; set; }
        public bool? IsAvailable { get; set; }
        public string? Message { get; set; }
        public VehicleType VehicleType { get; set; }
        public List<string>? Imgs { get; set; }
    }
}
