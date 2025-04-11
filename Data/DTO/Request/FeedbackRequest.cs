using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO.Request
{
    public class FeedbackRequest
    {
        public Guid? ProductId { get; set; }
        public Guid? TourId { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }
    }
}
