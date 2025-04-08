using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO.Request
{
    public class BookingAgriculturalTourRequest
    {
        public Guid TourId { get; set; }
        public int NumberOfPeople { get; set; }
        public virtual ICollection<OrderRequest>? Orders { get; set; }
    }
}
