using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO.Request
{
    public class TourismPackageRequest
    {
        public string PackageName { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public double Durations { get; set; }
        public TimeType DurationsType { get; set; }
        public StatusOperating StatusOperating { get; set; }
    }
}
