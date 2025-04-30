using Data.Models;

namespace Service.TourCompanySer
{
    public interface ITourCompanyService
    {
        Task<List<TourCompany>> GetListTourCompanies_Admin();
        Task<TourCompany> GetTourCompany_Admin(Guid TourCompanyId);
        Task AddTourCompanyAsync(TourCompany tourCompany);
        Task UpdateTourCompanyAsync(TourCompany tourCompany);
        Task UpdateTourGuide(Guid companyId, Guid guideId);
        Task AddTourGuide(TourGuide guide);
    }
}
