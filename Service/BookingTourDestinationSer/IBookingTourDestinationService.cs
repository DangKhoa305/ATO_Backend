

using Data.Models;

namespace Service.BookingTourDestinationSer;

public interface IBookingTourDestinationService
{
    Task<BookingTourDestination> GetByIdAsync(Guid id);
    Task<List<BookingTourDestination>> GetAllByTour(Guid tourId);
    Task<List<BookingTourDestination>> GetByTourDestinationIdAsync(Guid tourDestinationId);
    Task<bool> CreateAsync(BookingTourDestination bookingDestination);
    Task<bool> UpdateAsync(Guid id, BookingTourDestination bookingDestination);
    Task<bool> DeleteAsync(Guid id);
}