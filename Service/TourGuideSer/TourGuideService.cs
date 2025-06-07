using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Service.TourGuideSer
{
    public class TourGuideService : ITourGuideService
    {
        private readonly Service.Repository.IRepository<TourGuide> _tourGuideRepository;
        private readonly Service.Repository.IRepository<TourCompany> _tourCompanyRepository;
        private readonly Service.Repository.IRepository<AgriculturalTourPackage> _agriculturalTourPackageRepository;

        public TourGuideService(
            Service.Repository.IRepository<TourGuide> tourGuideRepository,
            Service.Repository.IRepository<TourCompany> tourCompanyRepository,
            Service.Repository.IRepository<AgriculturalTourPackage> agriculturalTourPackageRepository
            )
        {
            _tourGuideRepository = tourGuideRepository;
            _tourCompanyRepository = tourCompanyRepository;
            _agriculturalTourPackageRepository = agriculturalTourPackageRepository;
        }
        public async Task AddTourGuideAsync(TourGuide TourGuide, Guid UserId)
        {
            TourCompany TourCompany = await _tourCompanyRepository.Query()
.SingleOrDefaultAsync(x => x.UserId == UserId);
            TourGuide.TourCompanyId = TourCompany.TourCompanyId;

            await _tourGuideRepository.AddAsync(TourGuide);
        }

        public async Task<TourGuide> GetTourGuideByIdAsync(Guid GuideId)
        {
            try
            {

                return await _tourGuideRepository.Query()
                       .Include(b => b.Account)
                       .FirstOrDefaultAsync(x => x.GuideId == GuideId);
            }
            catch (Exception)
            {

                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }

        public async Task<IEnumerable<TourGuide>> GetTourGuidesAsync(Guid UserId)
        {
            try
            {
                var TourCompany = await _tourCompanyRepository.Query()
                    .SingleOrDefaultAsync(x => x.UserId == UserId);
                return await _tourGuideRepository.Query()
                        .AsNoTracking()
                       .Include(b => b.Account)
                       .Where(x => x.TourCompanyId == TourCompany.TourCompanyId)
                       .ToListAsync();
            }
            catch (Exception ex)
            {

                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }

        public async Task<Dictionary<Guid, string>> GetBusyTourGuide(Guid packageId)
        {
            try
            {
                Dictionary<Guid, string> busyTourGuides = new();

                var tours = await _agriculturalTourPackageRepository.Query()
                    .Include(x => x.TourGuides)
                    .Where(x => x.TourId != packageId)
                    .Select(x => new { x.TourGuides, x.PackageName, x.EndTime }).ToListAsync();

                foreach (var tour in tours)
                {
                    if (tour is not null)
                    {
                        var guides = tour.TourGuides?.ToList();
                        if (guides is not null)
                        {
                            foreach (var guide in guides)
                            {
                                var key = Guid.Parse(guide.GuideId.ToString()!);
                                if (!busyTourGuides.Keys.Contains(key))
                                {
                                    busyTourGuides.Add(key, $"Đang bận hướng dẫn tour '{tour.PackageName}', rảnh sau ngày {tour.EndTime.ToShortDateString()}");
                                }
                            }
                        }
                    }

                }

                return busyTourGuides;
            }
            catch (Exception ex)
            {

                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }
        public async Task<Dictionary<Guid, string>> GetListBusyTourGuide()
        {
            try
            {
                Dictionary<Guid, string> busyTourGuides = new();

                var tours = await _agriculturalTourPackageRepository.Query()
                    .Include(x => x.TourGuides)
                    .Select(x => new { x.TourGuides, x.PackageName, x.EndTime }).ToListAsync();

                foreach (var tour in tours)
                {
                    if (tour is not null)
                    {
                        var guides = tour.TourGuides?.ToList();
                        if (guides is not null)
                        {
                            foreach (var guide in guides)
                            {
                                var key = Guid.Parse(guide.GuideId.ToString()!);
                                if (!busyTourGuides.Keys.Contains(key))
                                {
                                    busyTourGuides.Add(key, $"Đang bận hướng dẫn tour '{tour.PackageName}', rảnh sau ngày {tour.EndTime.ToShortDateString()}");
                                }
                            }
                        }
                    }

                }

                return busyTourGuides;
            }
            catch (Exception ex)
            {

                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }


        public async Task UpdateTourGuideAsync(TourGuide TourGuide)
        {
            await _tourGuideRepository.UpdateAsync(TourGuide);
        }
    }
}
