using Data.Models;
using Microsoft.EntityFrameworkCore;
using Service.Repository;

namespace Service.BookingTourDestinationSer;

public class BookingTourDestinationService(
    IRepository<BookingTourDestination> bookingDestinationRepo) : IBookingTourDestinationService
{
    private readonly IRepository<BookingTourDestination> _bookingDestinationRepo = bookingDestinationRepo;

    public async Task<BookingTourDestination> GetByIdAsync(Guid id)
    {
        return await _bookingDestinationRepo.GetByIdAsync(id);
    }

    public async Task<List<BookingTourDestination>> GetByTourDestinationIdAsync(Guid tourDestinationId)
    {
        return await _bookingDestinationRepo.Query()
            .Where(x => x.TourDestinationId == tourDestinationId)
            .ToListAsync();
    }

    public async Task<bool> CreateAsync(BookingTourDestination bookingDestination)
    {
        var existing = await _bookingDestinationRepo.Query()
           .Where(x => x.TourDestinationId == bookingDestination.TourDestinationId).FirstOrDefaultAsync();
        if (existing == null)
        {
            bookingDestination.BookingDestinationId = Guid.NewGuid();
            await _bookingDestinationRepo.AddAsync(bookingDestination);

            return true;
        }

        existing.Status = BookingDestinationStatus.Completed;
        existing.ActualEndTime = bookingDestination.ActualEndTime;
        await _bookingDestinationRepo.UpdateAsync(existing);
        return true;
    }

    public async Task<bool> UpdateAsync(Guid id, BookingTourDestination bookingDestination)
    {
        var existing = await _bookingDestinationRepo.GetByIdAsync(id);
        if (existing == null) return false;

        existing.TourDestinationId = bookingDestination.TourDestinationId;
        existing.ActualStartTime = bookingDestination.ActualStartTime;
        existing.ActualEndTime = bookingDestination.ActualEndTime;
        existing.Notes = bookingDestination.Notes;
        existing.Status = bookingDestination.Status;

        await _bookingDestinationRepo.UpdateAsync(existing);
        return true;
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        var existing = await _bookingDestinationRepo.GetByIdAsync(id);
        if (existing == null) return false;

        await _bookingDestinationRepo.DeleteAsync(existing);
        return true;
    }

    public async Task<List<BookingTourDestination>> GetAllByTour(Guid tourId)
    {
        return await _bookingDestinationRepo.Query()
            .Where(x => x.TourId == tourId).ToListAsync();

    }


}