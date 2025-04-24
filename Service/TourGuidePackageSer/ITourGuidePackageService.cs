using Data.Models;

namespace Service.TourGuidePackageSer
{
    public interface ITourGuidePackageService
    {
        Task<List<AgriculturalTourPackage>> GetAssignedPackages(Guid guideId);
        Task<AgriculturalTourPackage> GetPackageDetails(Guid packageId, Guid guideId);
    }
}