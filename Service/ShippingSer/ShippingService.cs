using Data.DTO.Request;
using Data.DTO.Respone;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Service.ShippingSer
{
    public class ShippingService : IShippingService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public ShippingService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
            _httpClient.BaseAddress = new Uri(_configuration["ShippingAPI:BaseUrl"]);
            _httpClient.DefaultRequestHeaders.Add("Token", _configuration["ShippingAPI:Token"]);
        }

        public async Task<ShippingOrderResponse> CreateShippingOrder(ShippingOrderRequest request)
        {
            var response = await _httpClient.PostAsJsonAsync("/shipping/order", request);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<ShippingOrderResponse>();
        }
        public async Task<ShippingTrackingResponse> TrackShippingOrder(string orderCode)
        {
            var response = await _httpClient.GetAsync($"/shipping/tracking/{orderCode}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<ShippingTrackingResponse>();
        }
    }
}
