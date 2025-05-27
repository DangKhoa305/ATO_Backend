using Data.Models;

namespace Data.DTO.Respone
{
    public class BookingAgriculturalTourRespone
    {
        public Guid BookingId { get; set; }
        public Guid TourId { get; set; }
        public DateTime BookingDate { get; set; }
        public int NumberOfAdults { get; set; }
        public int? NumberOfChildren { get; set; }
        public decimal TotalAmmount { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public StatusBooking StatusBooking { get; set; }
        public virtual UserRespone? Customer { get; set; }
        public virtual AgriculturalTourPackageRespone_Guest? AgriculturalTourPackage { get; set; }
        public virtual ICollection<OrderRespone>? Orders { get; set; }
        public virtual ICollection<VNPayPaymentResponseDTO>? VNPayPaymentResponses { get; set; }
        public CurrentDestinationInfo? CurrentDestination { get; set; }
        public int TotalBookedPeople { get; set; }
        public Guid? GroupId { get; set; }

        public ICollection<BookingTourDestination>? Trackings { get; set; }
    }

    public class CurrentDestinationInfo
    {
        public Guid DestinationId { get; set; }
        public string? DestinationName { get; set; }
        public string? Address { get; set; }
        public int VisitOrder { get; set; }
        public DateTime? ActualStartTime { get; set; }
        public DateTime? ActualEndTime { get; set; }
        public BookingDestinationStatus Status { get; set; }
    }

    public class BookingAccept
    {
        public Guid TourId { get; set; }
        public StatusBooking StatusBooking { get; set; }
    }
}
