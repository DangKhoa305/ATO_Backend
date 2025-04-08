using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO.Respone
{
    public class BookingAgriculturalTourRespone
    {
        public Guid BookingId { get; set; }
        public Guid TourId { get; set; }
        public DateTime BookingDate { get; set; }
        public int NumberOfPeople { get; set; }
        public decimal TotalAmmount { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public StatusBooking StatusBooking { get; set; }
        public virtual AgriculturalTourPackageRespone_Guest? AgriculturalTourPackage { get; set; }
        public virtual ICollection<OrderRespone>? Orders { get; set; }
        public virtual ICollection<VNPayPaymentResponseDTO>? VNPayPaymentResponses { get; set; }
    }
}
