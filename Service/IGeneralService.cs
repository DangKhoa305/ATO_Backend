using Data.DTO;

namespace Service;
public interface IGeneralService
{
    Task<TourInfo> GetTourAsync(Guid tourId);
    Task<IEnumerable<IdentityModel>> GetTouristAsync(Guid tourId);
    Task<bool> IsTourStarted(Guid tourId);
    Task UpdateLocationAsync(Guid tourId, string location);
}
