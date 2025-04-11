using Data.Models;
using Microsoft.EntityFrameworkCore;
using Service.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.ShipAddressSer
{
    public class ShipAddressService : IShipAddressService
    {
        private readonly IRepository<ShipAddress> _shipAddressRepository;

        public ShipAddressService(IRepository<ShipAddress> shipAddressRepository)
        {
            _shipAddressRepository = shipAddressRepository;
        }

        public async Task<bool> AddShipAddress(ShipAddress shipAddress)
        {
            try
            {
                shipAddress.ShipAddressId = Guid.NewGuid();
                await _shipAddressRepository.AddAsync(shipAddress);
                return true;
            }
            catch (Exception)
            {

                throw new Exception("Đã xảy ra lỗi vui lòng tử lại sau!");
            }
        }

        public async Task<ShipAddress> GetShipAddressDetails(Guid shipAddressId)
        {
            return await _shipAddressRepository.GetByIdAsync(shipAddressId);
        }

        public async Task<List<ShipAddress>> GetShipAddresses(Guid accountId)
        {
            return await _shipAddressRepository.Query()
            .Where(x => x.AccountId == accountId).ToListAsync();
        }

        public async Task<bool> UpdateShipAddress(Guid shipAddressId, ShipAddress shipAddress)
        {
            try
            {

                var existingAddress = await _shipAddressRepository.GetByIdAsync(shipAddressId);
                if (existingAddress == null)
                    return false;

                shipAddress.ToPhone = shipAddress.ToPhone;
                shipAddress.ToDistrictId = shipAddress.ToDistrictId;
                shipAddress.ToWardCode = shipAddress.ToWardCode;
                shipAddress.DefaultAddress = shipAddress.DefaultAddress;
                shipAddress.ToName = shipAddress.ToName;
                await _shipAddressRepository.UpdateAsync(shipAddress);
                return true;
            }
            catch (Exception)
            {

                throw new Exception("Đã xảy ra lỗi vui lòng tử lại sau!");
            }
        }

    }
}
