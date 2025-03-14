using Data.Models;
using Microsoft.EntityFrameworkCore;
using Service.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.TouristFacilitySer
{
    public class TouristFacilityService : ITouristFacilityService
    {
        private readonly IRepository<TouristFacility> _touristFacilityRepository;
        public TouristFacilityService(IRepository<TouristFacility> touristFacilityRepository)
        {
            _touristFacilityRepository = touristFacilityRepository;
        }

        public async Task AddTouristFacilitiesAsync(TouristFacility TouristFacility)
        {
            await _touristFacilityRepository.AddAsync(TouristFacility);
        }

        public async Task<List<TouristFacility>> GetListTouristFacilities_Admin()
        {
            try
            {
                return await _touristFacilityRepository.Query()
                    .Include(b => b.Account)
                    .ToListAsync();
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }

        public async Task<TouristFacility> GetTouristFacilities_Admin(Guid TouristFacilityId)
        {
            try
            {
                return await _touristFacilityRepository.Query()
                    .Include(b => b.Account)
                    .SingleOrDefaultAsync(x => x.TouristFacilityId == TouristFacilityId);
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }

        public async Task UpdateTouristFacilitiesAsync(TouristFacility TouristFacility)
        {
            await _touristFacilityRepository.UpdateAsync(TouristFacility);
        }
    }
}
