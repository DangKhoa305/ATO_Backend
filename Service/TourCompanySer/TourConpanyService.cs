using Data.Models;
using Microsoft.EntityFrameworkCore;
using Service.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.TourCompanySer
{
    public class TourCompanyService : ITourCompanyService
    {
        private readonly IRepository<TourCompany> _tourCompanyRepository;
        private readonly IRepository<TourGuide> _tourGuideRepo;
        public TourCompanyService(IRepository<TourCompany> tourCompanyRepository, IRepository<TourGuide> tourGuideRepo)
        {
            _tourCompanyRepository = tourCompanyRepository;
            _tourGuideRepo = tourGuideRepo;
        }

        public async Task AddTourCompanyAsync(TourCompany tourCompany)
        {
            await _tourCompanyRepository.AddAsync(tourCompany);
        }
        public async Task UpdateTourCompanyAsync(TourCompany tourCompany)
        {
            await _tourCompanyRepository.UpdateAsync(tourCompany);
        }
        public async Task<List<TourCompany>> GetListTourCompanies_Admin()
        {
            try
            {
                return await _tourCompanyRepository.Query()
                    .Include(b => b.Account)
                    .OrderByDescending(x => x.CreateDate)
                    .ToListAsync();
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }

        public async Task<TourCompany> GetTourCompany_Admin(Guid TourCompanyId)
        {
            try
            {
                return await _tourCompanyRepository.Query()
                    .Include(b => b.Account)
                    .SingleOrDefaultAsync(x => x.TourCompanyId == TourCompanyId);
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }

        public async Task UpdateTourGuide(Guid companyId, Guid guideId)
        {
            var company = await _tourCompanyRepository.Query()
                     .Include(b => b.Account)
                     .SingleOrDefaultAsync(x => x.TourCompanyId == companyId);


            if (company is not null)
            {
                company.UserId = guideId;

                await _tourCompanyRepository.UpdateAsync(company);
            }
        }

        public async Task AddTourGuide(TourGuide guide)
        {
            await _tourGuideRepo.AddAsync(guide);
        }
    }
}
