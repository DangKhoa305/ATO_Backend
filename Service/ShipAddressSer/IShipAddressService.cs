using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.ShipAddressSer
{
    public interface IShipAddressService
    {
        Task<List<ShipAddress>> GetShipAddresses(Guid AccountId);
        Task<ShipAddress> GetShipAddressDetails(Guid ShipAddressId);
        Task<bool> AddShipAddress(ShipAddress ShipAddress);
        Task<bool> UpdateShipAddress(Guid ShipAddressId, ShipAddress ShipAddress);
    }
}
