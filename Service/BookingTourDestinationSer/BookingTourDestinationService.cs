using Data.DTO.Request;
using Data.DTO.Respone;
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

        public async Task<CurrentDestinationInfo?> GetCurrentDestination(Guid bookingId)
        {
            var currentDestination = await _bookingDestinationRepo.Query()
                .Include(x => x.TourDestination)
                .ThenInclude(x => x.Activity)
                .Include(x => x.TourDestination)
                .ThenInclude(x => x.Accommodation)
                .Where(x => x.BookingId == bookingId)
                .OrderByDescending(x => x.ActualStartTime)
                .FirstOrDefaultAsync(x => x.Status == BookingDestinationStatus.InProgress)
                ?? await _bookingDestinationRepo.Query()
                    .Include(x => x.TourDestination)
                    .ThenInclude(x => x.Activity)
                    .Include(x => x.TourDestination)
                    .ThenInclude(x => x.Accommodation)
                    .Where(x => x.BookingId == bookingId)
                    .OrderBy(x => x.TourDestination!.VisitOrder)
                    .FirstOrDefaultAsync(x => x.Status == BookingDestinationStatus.Pending);

            if (currentDestination == null) return null;

            return new CurrentDestinationInfo
            {
                DestinationId = currentDestination.TourDestinationId,
                DestinationName = currentDestination.TourDestination?.Activity != null
                    ? currentDestination.TourDestination.Activity.ActivityName
                    : currentDestination.TourDestination!.Accommodation?.AccommodationName,
                Address = currentDestination.TourDestination.Activity != null
                    ? currentDestination.TourDestination.Activity.Location
                    : currentDestination.TourDestination.Accommodation?.Address,
                VisitOrder = currentDestination.TourDestination.VisitOrder,
                ActualStartTime = currentDestination.ActualStartTime,
                ActualEndTime = currentDestination.ActualEndTime,
                Status = currentDestination.Status
            };
        }


    }
}