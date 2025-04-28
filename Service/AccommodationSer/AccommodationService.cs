using Data.Models;
using Microsoft.EntityFrameworkCore;
using Service.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.AccommodationSer
{
    public class AccommodationService : IAccommodationService
    {
        private readonly IRepository<TourCompany> _tourCompanyRepository;
        private readonly IRepository<Accommodation> _accommodationRepository;
        public AccommodationService(IRepository<Accommodation> accommodationRepository, IRepository<TourCompany> tourCompanyRepository)
        {
            _accommodationRepository = accommodationRepository;
            _tourCompanyRepository = tourCompanyRepository;
        }
        public async Task<bool> AddAccommodation(Accommodation Accommodation, Guid UserId)
        {
            try
            {
                TourCompany TourCompany = await _tourCompanyRepository.Query()
                .FirstOrDefaultAsync(x => x.UserId == UserId);
                Accommodation.TourCompanyId = TourCompany.TourCompanyId;
                Accommodation.AccommodationId = Guid.NewGuid();
                await _accommodationRepository.AddAsync(Accommodation);

                return true;
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }

        public async Task<Accommodation> GetAccommodation(Guid AccommodationId)
        {
            try
            {
                return await _accommodationRepository.Query()
                    .SingleOrDefaultAsync(x => x.AccommodationId == AccommodationId);
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }

        public async Task<List<Accommodation>> ListAccommodations(Guid UserId)
        {
            try
            {
                TourCompany TourCompany = await _tourCompanyRepository.Query()
                    .FirstOrDefaultAsync(x => x.UserId == UserId);
                return await _accommodationRepository.Query()
                    .Where(x => x.TourCompanyId == TourCompany.TourCompanyId)
                    .OrderByDescending(x => x.AccommodationId)
                    .ToListAsync();
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }

        public async Task<bool> UpdateAccommodation(Guid AccommodationId, Accommodation Accommodation)
        {
            try
            {
                Accommodation exist = await _accommodationRepository.Query().FirstOrDefaultAsync(x => x.AccommodationId == AccommodationId);
                exist.AccommodationName = Accommodation.AccommodationName;
                exist.PhoneNumber = Accommodation.PhoneNumber;
                exist.AccommodationDescription = Accommodation.AccommodationDescription;
                exist.Address = Accommodation.Address;
                exist.Star = Accommodation.Star;
                exist.Imgs = Accommodation.Imgs;
                await _accommodationRepository.UpdateAsync(exist);

                return true;
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }
    }
}
