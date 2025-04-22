using Data.Models;
using Microsoft.EntityFrameworkCore;
using Service.Repository;

namespace Service.ShipAddressSer;

public class ShipAddressService(IRepository<ShipAddress> shipAddressRepository) : IShipAddressService
{
    private readonly IRepository<ShipAddress> _shipAddressRepository = shipAddressRepository;

    public async Task<bool> AddShipAddress(ShipAddress shipAddress)
    {
        try
        {
            shipAddress.ShipAddressId = Guid.NewGuid();
            shipAddress.ToAddress =
                $"{shipAddress.ToWardName}, {shipAddress.ToDistrictName}, {shipAddress.ToProvinceName}";

            if (shipAddress.DefaultAddress)
            {
                await UpdateDefaultAddressStatus(shipAddress.AccountId, null);
            }

            await _shipAddressRepository.AddAsync(shipAddress);
            return true;
        }
        catch (Exception ex)
        {

            throw new Exception("Đã xảy ra lỗi vui lòng tử lại sau!");
        }
    }

    private async Task UpdateDefaultAddressStatus(Guid id, Guid? exceptId)
    {
        var query = _shipAddressRepository
            .Query()
            .Where(x => x.AccountId == id).AsNoTracking();

        if (exceptId is not null)
        {
            query = query.Where(x => x.ShipAddressId != exceptId);
        }


        var addresses = await query.ToListAsync();
        addresses.ForEach(x => x.DefaultAddress = false);
        await _shipAddressRepository.RealUpdateRangeAsync(addresses);
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

            var existingAddress = await _shipAddressRepository
                .Query().Where(x => x.ShipAddressId == shipAddress.ShipAddressId)
                .AsNoTracking().FirstOrDefaultAsync();

            if (existingAddress == null)
                return false;

            shipAddress.ToPhone = shipAddress.ToPhone;
            shipAddress.ToDistrictId = shipAddress.ToDistrictId;
            shipAddress.ToWardCode = shipAddress.ToWardCode;
            shipAddress.DefaultAddress = shipAddress.DefaultAddress;
            shipAddress.ToName = shipAddress.ToName;
            shipAddress.ToAddress =
               $"{shipAddress.ToWardName}, {shipAddress.ToDistrictName}, {shipAddress.ToProvinceName}";

            if (shipAddress.DefaultAddress)
            {
                await UpdateDefaultAddressStatus(shipAddress.AccountId, shipAddressId);
            }

            await _shipAddressRepository.DetachedAndUpdateAsync(shipAddress);
            return true;
        }
        catch (Exception)
        {

            throw new Exception("Đã xảy ra lỗi vui lòng tử lại sau!");
        }
    }
    public async Task<bool> DeleteShipAddress(Guid shipAddressId)
    {
        try
        {
            await _shipAddressRepository.DeleteAsync(shipAddressId);
            return true;
        }
        catch (Exception)
        {

            throw new Exception("Đã xảy ra lỗi vui lòng tử lại sau!");
        }
    }
}
