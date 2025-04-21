using Data.Models;

namespace Service.TourismPackageSer
{
    public interface ITourismPackageService
    {
        Task<bool> CreateActivity_AFTO(Activity responseResult);
        Task<bool> CreateTourismPackage_AFTO(TourismPackage responseResult, Guid UserId);
        Task<List<TourismPackage>> GetListTourismPackages(Guid UserId);
        Task<TourismPackage> GetTourismPackage(Guid PackageId);
        Task<Activity> GetActivity(Guid ActivityId);
        Task<bool> UpdateActivity_AFTO(Guid activityId, Activity responseResult);
        Task<bool> UpdateTourismPackage_AFTO(Guid packageId, TourismPackage responseResult);
        Task<List<TourismPackage>> GetListTourism_TC();
        Task<TourismPackage> GetTourismPackage_TC(Guid PackageId);
        Task<List<TourismPackage>> GetAllAsync();
        Task<bool> ProcessApprovalAsync(Guid packageId, StatusApproval status);
    }
}
