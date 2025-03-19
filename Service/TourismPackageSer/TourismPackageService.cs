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
        private readonly IRepository<Activity> _activityRepository;
        public TourismPackageService(
            IRepository<TourismPackage> tourismPackageRepository,
            IRepository<TouristFacility> touristFacilityRepository,
            IRepository<Activity> activityRepository)
        {
            _tourismPackageRepository = tourismPackageRepository;
            _touristFacilityRepository = touristFacilityRepository;
            _activityRepository = activityRepository;
        }

        public async Task<bool> CreateActivity_AFTO(Activity responseResult)
        {
            try
            {
                responseResult.ActivityId = Guid.NewGuid();
                responseResult.CreateDate = DateTime.UtcNow;
                responseResult.StatusApproval = StatusApproval.Processing;
                await _activityRepository.AddAsync(responseResult);

                return true;
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
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

        public async Task<bool> UpdateActivity_AFTO(Guid activityId, Activity responseResult)
        {
            try
            {
                Activity existingActivity = await _activityRepository.Query()
                    .SingleOrDefaultAsync(x => x.ActivityId == activityId);

                if (existingActivity == null)
                {
                    throw new Exception("Không tìm thấy hoạt động trải nghiệm!");
                }

                existingActivity.ActivityName = responseResult.ActivityName;
                existingActivity.Description = responseResult.Description;
                existingActivity.DurationInHours = responseResult.DurationInHours;
                existingActivity.DurationInHoursType = responseResult.DurationInHoursType;
                existingActivity.Location = responseResult.Location;
                existingActivity.Imgs = responseResult.Imgs;
                existingActivity.BreakTimeInMinutesType = responseResult.BreakTimeInMinutesType;
                existingActivity.PackageId = responseResult.PackageId;
                existingActivity.UpdateDate = DateTime.UtcNow;

                await _activityRepository.UpdateAsync(existingActivity);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
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
                existingTourismPackage.DurationsType = responseResult.DurationsType;
                existingTourismPackage.TourCompanyId = responseResult.TourCompanyId;
                existingTourismPackage.StatusOperating = responseResult.StatusOperating;
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
