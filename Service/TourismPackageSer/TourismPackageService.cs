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

        public async Task<bool> CreateTourismPackage_AFTO(TourismPackage responseResult, Guid UserId)
        {
            try
            {
                TouristFacility TouristFacility = await _touristFacilityRepository.Query()
                    .SingleOrDefaultAsync(x => x.UserId == UserId);
                responseResult.PackageId = Guid.NewGuid();
                responseResult.TouristFacilityId = TouristFacility.TouristFacilityId;
                responseResult.CreateDate = DateTime.UtcNow;
                responseResult.StatusApproval = StatusApproval.Processing;
                await _tourismPackageRepository.AddAsync(responseResult);

                return true;
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
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

        public async Task<bool> UpdateTourismPackage_AFTO(Guid packageId, TourismPackage responseResult)
        {
            try
            {
                TourismPackage existingTourismPackage = await _tourismPackageRepository.Query()
                    .SingleOrDefaultAsync(x => x.PackageId == packageId);

                if (existingTourismPackage == null)
                {
                    throw new Exception("Không tìm thấy gói du lịch!");
                }

                existingTourismPackage.PackageName = responseResult.PackageName;
                existingTourismPackage.Description = responseResult.Description;
                existingTourismPackage.Price = responseResult.Price;
                existingTourismPackage.Durations = responseResult.Durations;
                existingTourismPackage.TourCompanyId = responseResult.TourCompanyId;
                existingTourismPackage.UpdateDate = DateTime.UtcNow;

                await _tourismPackageRepository.UpdateAsync(existingTourismPackage);

                return true;
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }
    }
}
