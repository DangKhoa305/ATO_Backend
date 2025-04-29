using Data.Models;

namespace Service.DashboardSer;

public interface IDashboardService
{
    Task<AdminDashboardData> GetAdminDashboardDataAsync();
    Task<TourCompanyDashboardData> GetTourCompanyDashboardDataAsync(Guid companyId);
    Task<TouristFacilityDashboardData> GetTouristFacilityDashboardDataAsync(Guid facilityId);
    Task<Guid?> GetCompanyIdFromUserIdAsync(Guid userId);
    Task<Guid?> GetFacilityIdFromUserIdAsync(Guid userId);
}