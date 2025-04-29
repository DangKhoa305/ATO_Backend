using Data.Models;
using Microsoft.EntityFrameworkCore;
using Service.Repository;

namespace Service.AgriculturalTourPackageSer
{
    public class AgriculturalTourPackageService : IAgriculturalTourPackageService
    {
        private readonly IRepository<AgriculturalTourPackage> _agriculturalTourPackageRepository;
        private readonly IRepository<TourDestination> _tourDestinationRepository;
        private readonly IRepository<TourCompany> _tourCompanyRepository;
        private readonly IRepository<TourGuide> _tourGuideRepository;
        private readonly IRepository<BookingAgriculturalTour> _bookingRepository;
        private readonly IRepository<BookingTourDestination> _bookingTourDestinationRepo;
        public AgriculturalTourPackageService(
            IRepository<AgriculturalTourPackage> agriculturalTourPackageRepository,
            IRepository<TourCompany> tourCompanyRepository,
            IRepository<TourGuide> tourGuideRepository,
            IRepository<TourDestination> tourDestinationRepository,
            IRepository<BookingAgriculturalTour> bookingRepository,
            IRepository<BookingTourDestination> bookingTourDestinationRepo
            )
        {
            _agriculturalTourPackageRepository = agriculturalTourPackageRepository;
            _tourCompanyRepository = tourCompanyRepository;
            _tourGuideRepository = tourGuideRepository;
            _tourDestinationRepository = tourDestinationRepository;
            _bookingRepository = bookingRepository;
            _bookingTourDestinationRepo = bookingTourDestinationRepo;
        }

        public async Task<bool> CreateAgriculturalTourPackage(AgriculturalTourPackage newTour, Guid UserId)
        {
            try
            {
                var TourCompany = await _tourCompanyRepository.Query().SingleOrDefaultAsync(x => x.UserId == UserId);
                var tourGuides = newTour.TourGuides?.ToArray().ToList();
                var tourDestinations = newTour.TourDestinations?.ToArray().ToList();

                newTour.TourId = Guid.NewGuid();
                newTour.CreateDate = DateTime.UtcNow;
                newTour.TourCompanyId = TourCompany!.TourCompanyId;
                newTour.TourGuides?.Clear();
                newTour.TourDestinations?.Clear();
                newTour.StatusActive = StatusActive.inactive;

                await _agriculturalTourPackageRepository.AddRangeAsync(newTour);

                await AddTourDestinations(tourDestinations, newTour.TourId);
                await AddTourGuides(tourGuides?.Select(x => x.GuideId).ToList(), newTour.TourId);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }
        public async Task<bool> UpdateAgriculturalTourPackage(Guid TourId, AgriculturalTourPackage updatedTour)
        {
            try
            {
                var existing = await _agriculturalTourPackageRepository.Query()
                    .Include(x => x.TourGuides)
                    .SingleOrDefaultAsync(x => x.TourId == TourId);

                if (existing == null)
                    throw new Exception("Không tìm thấy gói du lịch!");

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
                existing.TourGuides?.Clear();
                existing.TourDestinations?.Clear();
                existing.StatusActive = updatedTour.StatusActive;
                await _agriculturalTourPackageRepository.UpdateRangeAsync(existing);

                await AddTourDestinations(updatedTour.TourDestinations, TourId);
                await AddTourGuides(updatedTour.TourGuides?.Select(x => x.GuideId).ToList(), TourId);

                return true;
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }

        public async Task<bool> ProcessApproval(Guid id, StatusApproval status)
        {
            try
            {
                var existing = await _agriculturalTourPackageRepository.Query()
                    .Include(x => x.TourGuides)
                    .SingleOrDefaultAsync(x => x.TourId == id);

                if (existing == null)
                    throw new Exception("Không tìm thấy gói du lịch!");


                existing.StatusActive = status == StatusApproval.Approved
                    ? StatusActive.active : StatusActive.inactive;

                if (existing.TourDestinations is not null)
                {
                    List<TourDestination> items = [];
                    foreach (var item in existing.TourDestinations)
                    {
                        item.StatusApproval = status;
                        items.Add(item);
                    }

                    existing.TourDestinations = items;
                }

                await _agriculturalTourPackageRepository.UpdateRangeAsync(existing);
                return true;
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }

        public async Task<bool> CreateTourDestination(TourDestination newTourDestination, Guid TourId)
        {
            try
            {
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
                var TourCompany = await _tourCompanyRepository.Query()
                    .SingleOrDefaultAsync(x => x.UserId == UserId);
                return await _agriculturalTourPackageRepository.Query()
                                .Include(x => x.TourGuides)
                                .Include(x => x.TourDestinations)
                                .Where(x => x.TourCompanyId == TourCompany.TourCompanyId)
                                .OrderByDescending(x => x.CreateDate)
                                .ToListAsync();
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }

        public async Task<List<AgriculturalTourPackage>> GetAllByTourGuideAsync(Guid UserId)
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
                    .Where(x => x.TourGuides.Any(x => x.UserId == UserId))
                    .OrderByDescending(x => x.CreateDate)
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
                    .OrderByDescending(x => x.CreateDate)
                    .ToListAsync();
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }

        public async Task<List<AgriculturalTourPackage>> GetAll()
        {
            try
            {
                return await _agriculturalTourPackageRepository.Query()
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
        public async Task<bool> UpdateTourDestination(Guid TourDestinationId, TourDestination updatedTour)
        {
            var existing = await _tourDestinationRepository.Query()
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


        public async Task<int> GetPeople(Guid tourId)
        {
            return await _bookingRepository.Query()
              .Where(x => x.TourId == tourId)
              .Where(x => x.StatusBooking != StatusBooking.Canceled)
              .CountAsync();
        }

        #region private 
        private async Task AddTourDestinations(ICollection<TourDestination>? destinations, Guid tourId)
        {
            await RemoveBookedTourDestinations(tourId);
            await RemoveTourDestinations(tourId);
            if (destinations is null) return;
            foreach (var des in destinations)
            {
                await CreateTourDestination(des, tourId);
            }
        }

        private async Task RemoveBookedTourDestinations(Guid tourId)
        {
            var bookedDestinations = await _bookingTourDestinationRepo.Query().Where(x => x.TourId == tourId).ToListAsync();
            foreach (var des in bookedDestinations)
            {
                await _bookingTourDestinationRepo.DeleteAsync(des.TourDestinationId);
            }
        }

        private async Task RemoveTourDestinations(Guid tourId)
        {
            var destinations = await _tourDestinationRepository.Query()
                .Where(x => x.TourId == tourId).ToListAsync();

            foreach (var des in destinations)
            {
                await _tourDestinationRepository.DeleteAsync(des.TourDestinationId);
            }
        }

        private async Task AddTourGuides(List<Guid>? tourGuideIds, Guid tourId)
        {
            if (tourGuideIds is null) return;

            var pack = await _agriculturalTourPackageRepository.Query().SingleOrDefaultAsync(x => x.TourId == tourId);
            if (pack is null) return;

            var tourGuides = await _tourGuideRepository.Query()
                .Where(tg => tourGuideIds.Contains(tg.GuideId))
                .ToListAsync();

            pack.TourGuides = tourGuides;
            await _agriculturalTourPackageRepository.UpdateRangeAsync(pack);
        }



        #endregion

    }
}
