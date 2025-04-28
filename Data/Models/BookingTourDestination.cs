namespace Data.Models
{
    public class BookingTourDestination
    {
        public Guid BookingDestinationId { get; set; }
        public Guid TourId { get; set; }
        public Guid TourDestinationId { get; set; }
        public DateTime? ActualStartTime { get; set; }
        public DateTime? ActualEndTime { get; set; }
        public string? Notes { get; set; }
        public BookingDestinationStatus Status { get; set; }

        public virtual TourDestination? TourDestination { get; set; }
    }

    public enum BookingDestinationStatus
    {
        Pending = 0,
        InProgress = 1,
        Completed = 2,
        Canceled = 3,
        Skipped = 4
    }
}