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
        Task<List<TourismPackage>> GetListTourismPackages();
        Task<TourismPackage> GetTourismPackage(Guid PackageId);
    }
}
