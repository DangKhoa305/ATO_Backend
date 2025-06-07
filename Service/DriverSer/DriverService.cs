using Data.Models;
using Microsoft.EntityFrameworkCore;
using Service.Repository;

namespace Service.DriverSer
{
    public class DriverService : IDriverService
    {
        private readonly IRepository<TourCompany> _tourCompanyRepository;
        private readonly IRepository<Driver> _driverRepository;
        private readonly IRepository<AgriculturalTourPackage> _agriculturalTourPackageRepository;

        public DriverService(IRepository<Driver> driverRepository,
            IRepository<TourCompany> tourCompanyRepository,
            IRepository<AgriculturalTourPackage> agriculturalTourPackageRepository)
        {
            _driverRepository = driverRepository;
            _tourCompanyRepository = tourCompanyRepository;
            _agriculturalTourPackageRepository = agriculturalTourPackageRepository;
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

        public async Task<Dictionary<Guid?, string>> ListBusyDriver(Guid packageId)
        {
            Dictionary<Guid?, string> busyDrivers = new();

            var tours = await _agriculturalTourPackageRepository.Query()
                .Include(x => x.TourDestinations)
                .Where(x => x.TourId != packageId)
                .Select(x => new { x.TourDestinations, x.PackageName }).ToListAsync();

            foreach (var tour in tours)
            {
                if (tour is not null)
                {
                    var destinations = tour.TourDestinations?.ToList();
                    if (destinations is not null)
                    {
                        foreach (var destination in destinations)
                        {
                            if (destination.DriverId is not null)
                            {
                                var key = destination.DriverId;
                                if (!busyDrivers.Keys.Contains(key))
                                {
                                    busyDrivers.Add(key, $"Đang bận lái xe cho tour '{tour.PackageName}', rảnh sau ngày {destination.EndTime.ToShortDateString()}");
                                }
                            }
                        }
                    }
                }

            }

            return busyDrivers;
        }

        public async Task<Dictionary<Guid?, string>> ListAllBusyDriver()
        {
            Dictionary<Guid?, string> busyDrivers = new();

            var tours = await _agriculturalTourPackageRepository.Query()
                .Include(x => x.TourDestinations)
                .Select(x => new { x.TourDestinations, x.PackageName }).ToListAsync();

            foreach (var tour in tours)
            {
                if (tour is not null)
                {
                    var destinations = tour.TourDestinations?.ToList();
                    if (destinations is not null)
                    {
                        foreach (var destination in destinations)
                        {
                            if (destination.DriverId is not null)
                            {
                                var key = destination.DriverId;
                                if (!busyDrivers.Keys.Contains(key))
                                {
                                    busyDrivers.Add(key, $"Đang bận lái xe cho tour '{tour.PackageName}', rảnh sau ngày {destination.EndTime.ToShortDateString()}");
                                }
                            }
                        }
                    }
                }

            }

            return busyDrivers;
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
