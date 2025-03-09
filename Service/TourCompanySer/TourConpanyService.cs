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
        public TourCompanyService(IRepository<TourCompany> tourCompanyRepository)
        {
            _tourCompanyRepository = tourCompanyRepository;
        }
        public async Task<List<TourCompany>> GetListTourCompanies_Admin()
        {
            try
            {
                return await _tourCompanyRepository.Query()
                    .Include(b => b.Account)
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
    }
}
