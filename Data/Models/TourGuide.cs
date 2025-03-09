using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class TourGuide
    {
        public Guid GuideId { get; set; }
        public Guid TourCompanyId { get; set; }
        public Guid UserId { get; set; }
        public string? Bio { get; set; }
        public string? Languages { get; set; }
        public string? ExpertiseArea { get; set; }
        public double Rating { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public virtual Account? Account { get; set; }
        public virtual TourCompany? TourCompany { get; set; }
    }
}
