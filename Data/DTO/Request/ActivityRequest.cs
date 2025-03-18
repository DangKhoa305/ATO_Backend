using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO.Request
{
    public class ActivityRequest
    {
        public string ActivityName { get; set; }
        public string? Description { get; set; }
        public double DurationInHours { get; set; }
        public TimeType DurationInHoursType { get; set; }
        public string? Location { get; set; }
        public List<string>? Imgs { get; set; }
        public double BreakTimeInMinutes { get; set; }
        public TimeType BreakTimeInMinutesType { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Guid? PackageId { get; set; }
    }
}
