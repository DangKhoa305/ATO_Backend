using Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Service.EmailSer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.TourGuideSer
{
    public class TourGuideService : ITourGuideService
    {
        private readonly Service.Repository.IRepository<TourGuide> _tourGuideRepository;
        private readonly Service.Repository.IRepository<TourCompany> _tourCompanyRepository;
        public TourGuideService(
            Service.Repository.IRepository<TourGuide> tourGuideRepository,
            Service.Repository.IRepository<TourCompany> tourCompanyRepository
            )
        {
            _tourGuideRepository = tourGuideRepository;
            _tourCompanyRepository = tourCompanyRepository;
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

        public async Task UpdateTourGuideAsync(TourGuide TourGuide)
        {
            await _tourGuideRepository.UpdateAsync(TourGuide);
        }
    }
}
