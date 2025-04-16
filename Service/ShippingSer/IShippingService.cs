using Data.DTO.Request;
using Data.DTO.Respone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Service.ShippingSer.ShippingService;

namespace Service.ShippingSer
{
    public interface IShippingService
    {
        Task<ShippingOrderResponse> CreateShippingOrder(ShippingOrderRequest request);
        Task<ShippingTrackingResponse> TrackShippingOrder(string orderCode);
        Task<ShippingFeeResponse> CalculateShippingFee(ShippingFeeRequest request);
        Task<ProvinceResponse> GetProvinces();
        Task<DistrictResponse> GetDistricts(int provinceId);
        Task<WardResponse> GetWards(int districtId);
        Task<BaseResponse> CancelOrder(string orderCode);
        Task<string> PrintShippingLabel(string orderCode);
        Task<ShipAddressRespone> GetShipAddressDetails(Guid shipAddressId);
        Task<List<ShipAddressRespone>> GetShipAddresses(Guid accountId);
    }
}
