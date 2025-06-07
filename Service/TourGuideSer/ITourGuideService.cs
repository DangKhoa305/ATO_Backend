using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.TourGuideSer
{
    public interface ITourGuideService
    {
        Task<IEnumerable<TourGuide>> GetTourGuidesAsync(Guid UserId);
        Task<TourGuide> GetTourGuideByIdAsync(Guid GuideId);
        Task AddTourGuideAsync(TourGuide TourGuide, Guid UserId);
        Task UpdateTourGuideAsync(TourGuide TourGuide);

        Task<Dictionary<Guid, string>> GetBusyTourGuide(Guid packageId);
        Task<Dictionary<Guid, string>> GetListBusyTourGuide();

    }
}
