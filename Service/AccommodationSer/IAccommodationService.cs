using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.AccommodationSer
{
    public interface IAccommodationService
    {
        Task<List<Accommodation>> ListAccommodations(Guid UserId);
        Task<Accommodation> GetAccommodation(Guid AccommodationId);
        Task<bool> AddAccommodation(Accommodation Accommodation, Guid UserId);
        Task<bool> UpdateAccommodation(Guid AccommodationId, Accommodation Accommodation);
    }
}
