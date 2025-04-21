using System;
using System.Collections.Generic;

namespace Data.Models
{
    public class BookingTourDestination
    {
        public Guid BookingDestinationId { get; set; }
        public Guid BookingId { get; set; }
        public Guid TourDestinationId { get; set; }
        public DateTime? ActualStartTime { get; set; }
        public DateTime? ActualEndTime { get; set; }
        public string? Notes { get; set; }
        public BookingDestinationStatus Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        // Navigation properties
        public virtual BookingAgriculturalTour? Booking { get; set; }
        public virtual TourDestination? TourDestination { get; set; }
    }

    public enum BookingDestinationStatus
    {
        Pending,
        InProgress,
        Completed,
        Canceled,
        Skipped
    }
}