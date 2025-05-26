using Data.DTO;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Service.Repository;

namespace Service;
public class GeneralService(
    IRepository<BookingAgriculturalTour> bookingRepo,
    IRepository<BookingTourDestination> bookingDestinationRepo,
    IRepository<AgriculturalTourPackage> packageRepo) : IGeneralService
{
    public async Task<TourInfo> GetTourAsync(Guid tourId)
    {
        var query = bookingRepo.Query()
            .Include(x => x.Customer)
            .Include(x => x.AgriculturalTourPackage)
                .ThenInclude(x => x!.TourGuides)!
                .ThenInclude(x => x.Account)
            .Include(x => x.AgriculturalTourPackage)
                .ThenInclude(x => x!.TourCompany)
            .Where(x => x.TourId == tourId);

        var location = (await query.FirstOrDefaultAsync())?.AgriculturalTourPackage?.GatheringLocation;

        var tourists = await query
            .Select(x => new IdentityModel(x.Customer!.Fullname, x.Customer.PhoneNumber, x.Customer.Email))
            .Distinct()
            .ToListAsync();

        var tourGuideQuery = (await query
            .FirstOrDefaultAsync())?.AgriculturalTourPackage?.TourGuides;

        var tourGuides = tourGuideQuery?.Select(
            x => new IdentityModel(x.Account!.Fullname, x.Account.PhoneNumber, x.Account.Email)) ?? [];

        var isStarted = await bookingDestinationRepo.Query()
            .AnyAsync(x => x.TourId == tourId);

        var tourCompany = await query
            .Select(x => new IdentityModel(
                x.AgriculturalTourPackage!.TourCompany!.CompanynName,
                x.AgriculturalTourPackage.TourCompany.Website,
                x.AgriculturalTourPackage.TourCompany.EmailCompany))
            .FirstOrDefaultAsync();

        return new TourInfo
        {
            IsStarted = isStarted,
            TourGuides = tourGuides,
            Tourists = tourists,
            TourCompany = tourCompany,
            Location = location,
        };
    }

    public async Task<IEnumerable<IdentityModel>> GetTouristAsync(Guid tourId)
    {
        var query = bookingRepo.Query()
            .Include(x => x.Customer)
            .Include(x => x.AgriculturalTourPackage)
                .ThenInclude(x => x!.TourGuides)!
                .ThenInclude(x => x.Account)
            .Include(x => x.AgriculturalTourPackage)
                .ThenInclude(x => x!.TourCompany)
            .Where(x => x.TourId == tourId);

        var tourists = await query
            .Select(x => new IdentityModel(x.Customer!.Fullname, x.Customer.PhoneNumber, x.Customer.Email))
            .Distinct()
            .ToListAsync();

        return tourists;
    }

    public async Task<bool> IsTourStarted(Guid tourId)
    {
        var isStarted = await bookingDestinationRepo.Query()
           .AnyAsync(x => x.TourId == tourId);
        return isStarted;
    }

    public async Task UpdateLocationAsync(Guid tourId, string location)
    {
        var tour = await packageRepo.Query()
            .FirstOrDefaultAsync(x => x.TourId == tourId);

        if (tour is not null)
        {
            tour.GatheringLocation = location;
            await packageRepo.UpdateAsync(tour);
        }

    }
}
