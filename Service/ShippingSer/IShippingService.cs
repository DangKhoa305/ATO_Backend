using Data.DTO.Request;
using Data.DTO.Respone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.ShippingSer
{
    public interface IShippingService
    {
        Task<ShippingOrderResponse> CreateShippingOrder(ShippingOrderRequest request);
        Task<ShippingTrackingResponse> TrackShippingOrder(string orderCode);
    }
}
