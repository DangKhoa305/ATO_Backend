using Data.Models;

namespace Data.DTO.Response
{
    public class TourGuidePackageResponse
    {
        public Guid TourId { get; set; }
        public string TourName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public decimal PriceOfAdults { get; set; }
        public decimal PriceOfChildren { get; set; }
        public int Slot { get; set; }
        public int TotalBookedPeople { get; set; }
        public List<TourDestinationResponse> Destinations { get; set; }
        public List<BookedTourResponse> BookedTours { get; set; }
    }

    public class TourDestinationResponse
    {
        public Guid DestinationId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int VisitOrder { get; set; }
        public string Type { get; set; } // "Activity" or "Accommodation"
        public DateTime? ExpectedStartTime { get; set; }
        public DateTime? ExpectedEndTime { get; set; }
    }

    public class BookedTourResponse
    {
        public Guid BookingId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public int NumberOfAdults { get; set; }
        public int NumberOfChildren { get; set; }
        public int TotalPeople => NumberOfAdults + NumberOfChildren;
        public DateTime BookingDate { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public StatusBooking StatusBooking { get; set; }
    }
}