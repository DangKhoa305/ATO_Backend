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
        public int NumberOfAdults { get; set; }
        public int? NumberOfChildren { get; set; }
    }
}
