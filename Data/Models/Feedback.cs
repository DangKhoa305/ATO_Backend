using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Feedback
    {
        public Guid FeedbackId { get; set; }
        public Guid UserId { get; set; }
        public Guid? ProductId { get; set; }
        public Guid? TourId { get; set; }
        public string Content { get; set; }
        public List<string>? Imgs { get; set; }
        public int Rating { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public virtual Account? Account { get; set; }
        public virtual Product? Product { get; set; }
        public virtual AgriculturalTourPackage? AgriculturalTourPackage { get; set; }
    }
}
