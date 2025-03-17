using Data.Models;
using Microsoft.EntityFrameworkCore;
using Service.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.TourismPackageSer
{
    public class TourismPackageService : ITourismPackageService
    {
        private readonly IRepository<TourismPackage> _tourismPackageRepository;
        private readonly IRepository<TouristFacility> _touristFacilityRepository;
        public TourismPackageService(IRepository<TourismPackage> tourismPackageRepository, IRepository<TouristFacility> touristFacilityRepository)
        {
            _tourismPackageRepository = tourismPackageRepository;
            _touristFacilityRepository = touristFacilityRepository;
        }
        public async Task<List<TourismPackage>> GetListTourismPackages(Guid UserId)
        {
            try
            {
                TouristFacility TouristFacility = await _touristFacilityRepository.Query()
                    .SingleOrDefaultAsync(x => x.UserId == UserId);
                return await _tourismPackageRepository.Query()
                    .Include(b => b.TourCompany)
                    .Where(x => x.TouristFacilityId == TouristFacility.TouristFacilityId)
                    .ToListAsync();
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }

        public async Task<TourismPackage> GetTourismPackage(Guid PackageId)
        {
            try
            {
                return await _tourismPackageRepository.Query()
                    .Include(b => b.Activities)
                    .Include(b => b.TourCompany)
                    .SingleOrDefaultAsync(x => x.PackageId == PackageId);
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }
    }
}
