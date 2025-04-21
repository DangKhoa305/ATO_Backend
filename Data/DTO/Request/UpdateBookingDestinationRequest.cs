using Data.Models;
using System;

namespace Data.DTO.Request
{
    public class UpdateBookingDestinationRequest
    {
        public DateTime? ActualStartTime { get; set; }
        public DateTime? ActualEndTime { get; set; }
        public string? Notes { get; set; }
        public BookingDestinationStatus Status { get; set; }
    }
}