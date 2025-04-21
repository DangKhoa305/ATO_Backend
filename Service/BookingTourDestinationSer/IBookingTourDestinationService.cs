using Data.DTO.Request;
using Data.DTO.Respone;
using Data.Models;

namespace Service.BookingTourDestinationSer
{
    public interface IBookingTourDestinationService
    {
        Task<List<BookingTourDestination>> GetBookingDestinations(Guid bookingId);
        Task<BookingTourDestination?> GetBookingDestination(Guid bookingDestinationId);
        Task<bool> UpdateBookingDestination(Guid bookingDestinationId, UpdateBookingDestinationRequest request, Guid tourGuideId);
        Task<bool> InitializeBookingDestinations(Guid bookingId);
        Task<CurrentDestinationInfo?> GetCurrentDestination(Guid bookingId);
    }
}