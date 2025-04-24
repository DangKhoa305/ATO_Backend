using Data.Models;
using Microsoft.EntityFrameworkCore;
using Service.Repository;

namespace Service.TourGuidePackageSer
{
    public class TourGuidePackageService : ITourGuidePackageService
    {
        private readonly IRepository<AgriculturalTourPackage> _packageRepository;
        private readonly IRepository<TourGuide> _tourGuideRepository;

        public TourGuidePackageService(
            IRepository<AgriculturalTourPackage> packageRepository,
            IRepository<TourGuide> tourGuideRepository)
        {
            _packageRepository = packageRepository;
            _tourGuideRepository = tourGuideRepository;
        }

        public async Task<List<AgriculturalTourPackage>> GetAssignedPackages(Guid guideId)
        {
            var query = _packageRepository.Query()
                .Include(x => x.TourGuides)
                .Include(x => x.TourCompany)
                .Include(x => x.TourDestinations)
                .Where(x => x.TourGuides!.Any(g => g.UserId == guideId));

            return await query
                .OrderByDescending(x => x.CreateDate)
                .ToListAsync();
        }

        public async Task<AgriculturalTourPackage> GetPackageDetails(Guid packageId, Guid guideId)
        {
            return await _packageRepository.Query()
                .Include(x => x.TourGuides)
                .Include(x => x.TourDestinations)
                    .ThenInclude(d => d.Activity)
                .Include(x => x.TourDestinations)
                    .ThenInclude(d => d.Accommodation)
                .Include(x => x.TourCompany)
                .FirstOrDefaultAsync(x => 
                    x.TourId == packageId && 
                    x.TourGuides.Any(g => g.UserId == guideId));
        }
    }
}