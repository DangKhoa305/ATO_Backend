using Data.Migrations;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Service.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.AgriculturalTourPackageSer
{
    public class AgriculturalTourPackageService : IAgriculturalTourPackageService
    {
        private readonly IRepository<AgriculturalTourPackage> _agriculturalTourPackageRepository;
        private readonly IRepository<TourDestination> _tourDestinationRepository;
        private readonly IRepository<TourCompany> _tourCompanyRepository;
        private readonly IRepository<TourGuide> _tourGuideRepository;
        public AgriculturalTourPackageService(
            IRepository<AgriculturalTourPackage> agriculturalTourPackageRepository,
            IRepository<TourCompany> tourCompanyRepository,
            IRepository<TourGuide> tourGuideRepository,
            IRepository<TourDestination> tourDestinationRepository
            )
        {
            _agriculturalTourPackageRepository = agriculturalTourPackageRepository;
            _tourCompanyRepository = tourCompanyRepository;
            _tourGuideRepository = tourGuideRepository;
            _tourDestinationRepository = tourDestinationRepository;
        }

        public async Task<bool> CreateAgriculturalTourPackage(AgriculturalTourPackage newTour, Guid UserId)
        {
            try
            {
                TourCompany TourCompany = await _tourCompanyRepository.Query()
                    .SingleOrDefaultAsync(x => x.UserId == UserId);
                newTour.TourId = Guid.NewGuid();
                newTour.CreateDate = DateTime.UtcNow;
                newTour.TourCompanyId = TourCompany.TourCompanyId;
                if (newTour.TourGuides != null && newTour.TourGuides.Any())
                {
                    // Lấy các đối tượng TourGuide từ database dựa trên danh sách id
                    var tourGuideIds = newTour.TourGuides.Select(tg => tg.GuideId).ToList();

                    var tourGuides = await _tourGuideRepository.Query()
                        .Where(tg => tourGuideIds.Contains(tg.GuideId))
                        .ToListAsync();


                    // Gán các đối tượng TourGuide vào collection của AgriculturalTourPackage
                    newTour.TourGuides = tourGuides;
                }
                await _agriculturalTourPackageRepository.AddRangeAsync(newTour);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }

        public async Task<bool> CreateTourDestination(TourDestination newTourDestination, Guid TourId)
        {
            try
            {
                AgriculturalTourPackage AgriculturalTourPackage = await _agriculturalTourPackageRepository.Query()
                    .SingleOrDefaultAsync(x => x.TourId == TourId);
                newTourDestination.TourDestinationId = Guid.NewGuid();
                newTourDestination.CreateDate = DateTime.UtcNow;
                newTourDestination.TourId = TourId;
                newTourDestination.StatusApproval = StatusApproval.Processing;
                if (newTourDestination.TourGuides != null && newTourDestination.TourGuides.Any())
                {
                    // Lấy các đối tượng TourGuide từ database dựa trên danh sách id
                    var tourGuideIds = newTourDestination.TourGuides.Select(tg => tg.GuideId).ToList();

                    var tourGuides = await _tourGuideRepository.Query()
                        .Where(tg => tourGuideIds.Contains(tg.GuideId))
                        .ToListAsync();


                    // Gán các đối tượng TourGuide vào collection của AgriculturalTourPackage
                    newTourDestination.TourGuides = tourGuides;
                }
                await _tourDestinationRepository.AddAsync(newTourDestination);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }

        public async Task<AgriculturalTourPackage> GetAgriculturalTourPackage(Guid TourId)
        {
            try
            {
                return await _agriculturalTourPackageRepository.Query()
                    .Include(x => x.TourDestinations)
                        .ThenInclude(b => b.TourismPackage)
                    .Include(x => x.TourDestinations)
                        .ThenInclude(b => b.Driver)
                    .Include(x => x.TourDestinations)
                        .ThenInclude(b => b.Accommodation)
                    .Include(x => x.TourDestinations)
                        .ThenInclude(b => b.Activity)
                            .ThenInclude(x => x.Products)
                    .Include(x => x.TourDestinations)
                        .ThenInclude(b => b.TourGuides)
                    .Include(x => x.TourGuides)
                        .ThenInclude(b => b.Account)
                    .SingleOrDefaultAsync(x => x.TourId == TourId);
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }

        public async Task<List<AgriculturalTourPackage>> GetListAgriculturalTourPackages(Guid UserId)
        {
            try
            {
                TourCompany TourCompany = await _tourCompanyRepository.Query()
                    .SingleOrDefaultAsync(x => x.UserId == UserId);
                return await _agriculturalTourPackageRepository.Query()
                    .Where(x => x.TourCompanyId == TourCompany.TourCompanyId)
                    .ToListAsync();
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }
        public async Task<List<AgriculturalTourPackage>> GetListAgriculturalTourPackages_Guest()
        {
            try
            {
                return await _agriculturalTourPackageRepository.Query()
                    .Where(x => x.StatusActive == StatusActive.active)
                    .ToListAsync();
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }
        public async Task<AgriculturalTourPackage> GetAgriculturalTourPackage_Guest(Guid TourId)
        {
            try
            {
                return await _agriculturalTourPackageRepository.Query()
                    .Include(x => x.TourDestinations.Where(x => x.StatusApproval == StatusApproval.Approved))
                        .ThenInclude(b => b.TourismPackage)
                    .Include(x => x.TourDestinations)
                        .ThenInclude(b => b.Driver)
                    .Include(x => x.TourDestinations)
                        .ThenInclude(b => b.Accommodation)
                    .Include(x => x.TourDestinations)
                        .ThenInclude(b => b.Activity)
                        .ThenInclude(x => x.Products)
                    .Include(x => x.TourDestinations)
                        .ThenInclude(b => b.TourGuides)
                    .Include(x => x.TourGuides)
                        .ThenInclude(b => b.Account)
                    .SingleOrDefaultAsync(x => x.TourId == TourId);
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }
        public async Task<TourDestination> GetTourDestination(Guid TourDestinationId)
        {
            try
            {
                return await _tourDestinationRepository.Query()
                    .Include(x => x.TourismPackage)
                    .Include(x => x.Driver)
                    .Include(x => x.Accommodation)
                    .Include(x => x.AgriculturalTourPackage)
                    .Include(x => x.Activity)
                    .Include(x => x.TourGuides)
                        .ThenInclude(b => b.Account)
                    .SingleOrDefaultAsync(x => x.TourDestinationId == TourDestinationId);
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }

        public async Task<bool> UpdateAgriculturalTourPackage(Guid TourId, AgriculturalTourPackage updatedTour)
        {
            try
            {
                AgriculturalTourPackage existing = await _agriculturalTourPackageRepository.Query()
                    .Include(x => x.TourGuides)
                    .SingleOrDefaultAsync(x => x.TourId == TourId);

                if (existing == null)
                {
                    throw new Exception("Không tìm thấy gói du lịch!");
                }

                existing.PackageName = updatedTour.PackageName;
                existing.Description = updatedTour.Description;
                existing.Imgs = updatedTour.Imgs;
                existing.PriceOfAdults = updatedTour.PriceOfAdults;
                existing.PriceOfChildren = updatedTour.PriceOfChildren;
                existing.ChildTicketAge = updatedTour.ChildTicketAge;
                existing.Slot = updatedTour.Slot;
                existing.StartTime = updatedTour.StartTime;
                existing.EndTime = updatedTour.EndTime;
                existing.Durations = updatedTour.Durations;
                existing.DurationsType = updatedTour.DurationsType;
                existing.UpdateDate = DateTime.UtcNow;
                existing.Imgs = updatedTour.Imgs;
                existing.TourGuides.Clear();
                if (updatedTour.TourGuides == null)
                {

                    // Lấy danh sách các GuideId từ updatedTour
                    var tourGuideIds = updatedTour.TourGuides.Select(tg => tg.GuideId).ToList();

                    // Truy vấn lấy các TourGuide tương ứng từ database
                    var tourGuides = await _tourGuideRepository.Query()
                        .Where(tg => tourGuideIds.Contains(tg.GuideId))
                        .ToListAsync();

                    // Thêm lại các TourGuide mới vào collection của existing
                    foreach (var tg in tourGuides)
                    {
                        existing.TourGuides.Add(tg);
                    }
                }

                await _agriculturalTourPackageRepository.UpdateRangeAsync(existing);

                return true;
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }

        public async Task<bool> UpdateTourDestination(Guid TourDestinationId, TourDestination updatedTour)
        {
            TourDestination existing = await _tourDestinationRepository.Query()
                    .Include(x => x.TourGuides)
                .SingleOrDefaultAsync(x => x.TourDestinationId == TourDestinationId);

            if (existing == null)
            {
                throw new Exception("Không tìm thấy hoạt động!");
            }

            existing.Title = updatedTour.Title;
            existing.Description = updatedTour.Description;
            existing.StartTime = updatedTour.StartTime;
            existing.EndTime = updatedTour.EndTime;
            existing.CheckInDate = updatedTour.CheckInDate;
            existing.CheckOutDate = updatedTour.CheckOutDate;
            existing.VisitOrder = updatedTour.VisitOrder;
            existing.TypeActivity = updatedTour.TypeActivity;
            existing.DriverId = updatedTour.DriverId;
            existing.TourismPackageId = updatedTour.TourismPackageId;
            existing.AccommodationId = updatedTour.AccommodationId;
            existing.ActivityId = updatedTour.ActivityId;
            existing.UpdateDate = DateTime.UtcNow;
            existing.TourGuides.Clear();
            if (updatedTour.TourGuides != null)
            {

                // Lấy danh sách các GuideId từ updatedTour
                var tourGuideIds = updatedTour.TourGuides.Select(tg => tg.GuideId).ToList();

                // Truy vấn lấy các TourGuide tương ứng từ database
                var tourGuides = await _tourGuideRepository.Query()
                    .Where(tg => tourGuideIds.Contains(tg.GuideId))
                    .ToListAsync();

                // Thêm lại các TourGuide mới vào collection của existing
                foreach (var tg in tourGuides)
                {
                    existing.TourGuides.Add(tg);
                }
            }

            await _tourDestinationRepository.UpdateRangeAsync(existing);

            return true;
        }
    }
}
