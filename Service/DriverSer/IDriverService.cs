using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DriverSer
{
    public interface IDriverService
    {
        Task<List<Driver>> ListDriver(Guid UserId);
        Task<Dictionary<Guid?, string>> ListBusyDriver(Guid packageId);
        Task<Dictionary<Guid?, string>> ListAllBusyDriver();

        Task<Driver> GetDriver(Guid DriverId);
        Task<bool> AddDriver(Driver driver, Guid UserId);
        Task<bool> UpdateDriver(Guid DriverId, Driver driver);
    }
}
