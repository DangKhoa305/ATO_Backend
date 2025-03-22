using Data.Models;
using Microsoft.EntityFrameworkCore;
using Service.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DriverSer
{
    public class DriverService : IDriverService
    {
        private readonly IRepository<TourCompany> _tourCompanyRepository;
        private readonly IRepository<Driver> _driverRepository;
        public DriverService(IRepository<Driver> driverRepository, IRepository<TourCompany> tourCompanyRepository)
        {
            _driverRepository = driverRepository;
            _tourCompanyRepository = tourCompanyRepository;
        }
        public async Task<bool> AddDriver(Driver driver, Guid UserId)
        {

            try
            {
                TourCompany TourCompany = await _tourCompanyRepository.Query()
                .FirstOrDefaultAsync(x => x.UserId == UserId);
                driver.TourCompanyId = TourCompany.TourCompanyId;
                driver.DriverId = Guid.NewGuid();
                await _driverRepository.AddAsync(driver);

                return true;
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }

        public async Task<Driver> GetDriver(Guid DriverId)
        {
            try
            {
                return await _driverRepository.Query()
                    .SingleOrDefaultAsync(x => x.DriverId == DriverId);
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }

        public async Task<List<Driver>> ListDriver(Guid UserId)
        {
            try
            {
                TourCompany TourCompany = await _tourCompanyRepository.Query()
                    .FirstOrDefaultAsync(x => x.UserId == UserId);
                return await _driverRepository.Query()
                    .Where(x => x.TourCompanyId == TourCompany.TourCompanyId)
                    .ToListAsync();
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }

        public async Task<bool> UpdateDriver(Guid DriverId, Driver driver)
        {
            try
            {
                Driver exist = await _driverRepository.Query().FirstOrDefaultAsync(x => x.DriverId == DriverId);
                exist.DriverName = driver.DriverName;
                exist.PhoneNumber = driver.PhoneNumber;
                exist.VehicleType = driver.VehicleType;
                exist.Imgs = driver.Imgs;
                await _driverRepository.UpdateAsync(exist);

                return true;
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }
    }
}
