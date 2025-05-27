using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class BookingAgriculturalTour
    {
        public Guid BookingId { get; set; }
        public Guid TourId { get; set; }
        public Guid CustomerId { get; set; }
        public DateTime BookingDate { get; set; }
        public int NumberOfAdults { get; set; }
        public int? NumberOfChildren { get; set; }
        public decimal TotalAmmount { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public StatusBooking StatusBooking { get; set; }
        public Guid? GroupId { get; set; }
        public List<Guid>? TourGuidIds { get; set; } = [];
        public List<Guid?>? DriverIds { get; set; } = [];
        public virtual Account? Customer { get; set; }
        public virtual AgriculturalTourPackage? AgriculturalTourPackage { get; set; }
        public virtual ICollection<Order>? Orders { get; set; }
        public virtual ICollection<VNPayPaymentResponse>? VNPayPaymentResponses { get; set; }
        public virtual ICollection<BookingTourDestination>? BookingTourDestinations { get; set; }
    }
    public enum StatusBooking
    {
        Processing = 0,
        Completed = 1,
        Canceled = 2,
        ConfirmBooking = 3,
        InProgress = 4,
    }
}
