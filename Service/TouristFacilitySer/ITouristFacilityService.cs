using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.TouristFacilitySer
{
    public interface ITouristFacilityService
    {
        Task<List<TouristFacility>> GetListTouristFacilities_Admin();
        Task<TouristFacility> GetTouristFacilities_Admin(Guid TouristFacilityId);
        Task AddTouristFacilitiesAsync(TouristFacility TouristFacility);
        Task UpdateTouristFacilitiesAsync(TouristFacility TouristFacility);
        Task<TouristFacility> GetTouristFacilities_Guest(Guid TouristFacilityId);
    }
}
