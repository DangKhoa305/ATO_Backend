using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO.Respone
{
    public class AccommodationRespone
    {
        public Guid AccommodationId { get; set; }
        public string AccommodationName { get; set; }
        public string? AccommodationDescription { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public int? Star { get; set; }
        public List<string>? Imgs { get; set; }
    }
}
