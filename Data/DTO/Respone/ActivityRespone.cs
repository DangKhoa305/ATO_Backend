using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO.Respone
{
    public class ActivityRespone
    {
        public Guid ActivityId { get; set; }
        public string ActivityName { get; set; }
        public string? Description { get; set; }
        public double DurationInHours { get; set; }
        public string? Location { get; set; }
        public List<string>? Imgs { get; set; }
        public double BreakTimeInMinutes { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public StatusApproval StatusApproval { get; set; }

        public string? ReplyRequest { get; set; }
        public int? MaxCapacity { get; set; }
        public int? CurrentCapacity { get; set; }
        public virtual ICollection<Product_ActivityRespone>? Products { get; set; }
    }
    public class Product_ActivityRespone
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
    }
}
