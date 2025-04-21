using Data.DTO.Request;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Service.Repository;

namespace Service.BookingTourDestinationSer
{
    public class BookingTourDestinationService : IBookingTourDestinationService
    {
        private readonly IRepository<BookingTourDestination> _bookingDestinationRepo;
        private readonly IRepository<BookingAgriculturalTour> _bookingRepo;
        private readonly IRepository<TourGuide> _tourGuideRepo;

        public BookingTourDestinationService(
            IRepository<BookingTourDestination> bookingDestinationRepo,
            IRepository<BookingAgriculturalTour> bookingRepo,
            IRepository<TourGuide> tourGuideRepo)
        {
            _bookingDestinationRepo = bookingDestinationRepo;
            _bookingRepo = bookingRepo;
            _tourGuideRepo = tourGuideRepo;
        }

        public async Task<List<BookingTourDestination>> GetBookingDestinations(Guid bookingId)
        {
            return await _bookingDestinationRepo.Query()
                .Where(x => x.BookingId == bookingId)
                .Include(x => x.TourDestination)
                .OrderBy(x => x.TourDestination!.VisitOrder)
                .ToListAsync();
        }

        public async Task<BookingTourDestination?> GetBookingDestination(Guid bookingDestinationId)
        {
            return await _bookingDestinationRepo.Query()
                .Include(x => x.TourDestination)
                .FirstOrDefaultAsync(x => x.BookingDestinationId == bookingDestinationId);
        }

        public async Task<bool> UpdateBookingDestination(Guid bookingDestinationId, UpdateBookingDestinationRequest request, Guid tourGuideId)
        {
            var destination = await _bookingDestinationRepo.Query()
                .Include(x => x.Booking)
                .ThenInclude(x => x.AgriculturalTourPackage)
                .ThenInclude(x => x.TourGuides)
                .FirstOrDefaultAsync(x => x.BookingDestinationId == bookingDestinationId);

            if (destination == null) return false;

            // Verify if the tour guide is assigned to this tour
            var isAssignedGuide = destination.Booking?.AgriculturalTourPackage?.TourGuides?
                .Any(g => g.GuideId == tourGuideId);
            if (isAssignedGuide == false) return false;

            destination.ActualStartTime = request.ActualStartTime;
            destination.ActualEndTime = request.ActualEndTime;
            destination.Notes = request.Notes;
            destination.Status = request.Status;
            destination.UpdateDate = DateTime.UtcNow;

            await _bookingDestinationRepo.UpdateAsync(destination);
            return true;
        }

        public async Task<bool> InitializeBookingDestinations(Guid bookingId)
        {
            var booking = await _bookingRepo.Query()
                .Include(x => x.AgriculturalTourPackage)
                .ThenInclude(x => x.TourDestinations)
                .FirstOrDefaultAsync(x => x.BookingId == bookingId);

            if (booking == null) return false;

            var destinations = booking.AgriculturalTourPackage?.TourDestinations?
                .Select(td => new BookingTourDestination
                {
                    BookingDestinationId = Guid.NewGuid(),
                    BookingId = bookingId,
                    TourDestinationId = td.TourDestinationId,
                    Status = BookingDestinationStatus.Pending,
                    CreateDate = DateTime.UtcNow
                });

            if (destinations == null) return false;

            await _bookingDestinationRepo.RealAddRangeAsync(destinations);
            return true;
        }
    }
}