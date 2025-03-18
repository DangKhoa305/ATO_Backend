using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.TourismPackageSer
{
    public interface ITourismPackageService
    {
        Task<bool> CreateActivity_AFTO(Activity responseResult);
        Task<bool> CreateTourismPackage_AFTO(TourismPackage responseResult, Guid UserId);
        Task<List<TourismPackage>> GetListTourismPackages(Guid UserId);
        Task<TourismPackage> GetTourismPackage(Guid PackageId);
        Task<bool> UpdateActivity_AFTO(Guid activityId, Activity responseResult);
        Task<bool> UpdateTourismPackage_AFTO(Guid packageId, TourismPackage responseResult);
    }
}
