using Data.DTO.Request;
using Data.DTO.Respone;
using Microsoft.Extensions.Configuration;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Service.ShippingSer
{
    public class ShippingService : IShippingService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        private const string TOKEN = "694d5427-13a5-11f0-8686-8669292be81e";
        private const int SHOP_ID = 5722523;

        public ShippingService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
            _httpClient.BaseAddress = new Uri("https://online-gateway.ghn.vn/shiip/public-api/");

            // Clear any existing headers
            _httpClient.DefaultRequestHeaders.Clear();

            // Add required GHN headers
            _httpClient.DefaultRequestHeaders.Add("Token", TOKEN);
            _httpClient.DefaultRequestHeaders.Add("ShopId", SHOP_ID.ToString());
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<ShippingOrderResponse> CreateShippingOrder(ShippingOrderRequest request)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync("v2/shipping-order/create", request);
                var responseContent = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"GHN API Error: {responseContent}");
                }

                var jsonResponse = JsonDocument.Parse(responseContent);
                var root = jsonResponse.RootElement;
                var data = root.GetProperty("data");

                return new ShippingOrderResponse
                {
                    Code = root.GetProperty("code").GetInt32(),
                    Message = root.GetProperty("message").GetString(),
                    order_code = data.GetProperty("order_code").GetString(),
                    expected_delivery_time = data.GetProperty("expected_delivery_time").GetString(),
                    total_fee = data.GetProperty("total_fee").GetDecimal(),
                    insurance = data.GetProperty("fee").GetProperty("insurance").GetDecimal(),
                    cod_fee = data.GetProperty("fee").GetProperty("cod_fee").GetDecimal()
                };
            }
            catch (Exception ex)
            {
                throw new Exception($"Create shipping order failed: {ex.Message}", ex);
            }
        }
        public async Task<ShippingTrackingResponse> TrackShippingOrder(string orderCode)
        {
            try
            {
                var response = await _httpClient.GetAsync($"v2/shipping-order/detail?order_code={orderCode}");
                var responseContent = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"GHN Tracking API Error: {responseContent}");
                }

                var jsonResponse = JsonDocument.Parse(responseContent);
                var root = jsonResponse.RootElement;
                var data = root.GetProperty("data");

                // Handle string status
                var statusString = data.GetProperty("status").GetString();
                int status = ConvertStatusToInt(statusString);
                var statusName = GetStatusName(status);

                return new ShippingTrackingResponse
                {
                    Code = root.GetProperty("code").GetInt32(),
                    Message = root.GetProperty("message").GetString(),
                    Data = new TrackingData
                    {
                        OrderCode = orderCode,
                        Status = status,
                        StatusName = statusName,
                        CreatedDate = DateTime.Parse(data.GetProperty("created_date").GetString()),
                        LastUpdateDate = data.TryGetProperty("updated_date", out var updateDate) ?
                            DateTime.Parse(updateDate.GetString()) : null
                    }
                };
            }
            catch (Exception ex)
            {
                throw new Exception($"Track shipping order failed: {ex.Message}", ex);
            }
        }

        private int ConvertStatusToInt(string status)
        {
            return status?.ToLower() switch
            {
                "ready_to_pick" => 1,
                "picking" => 2,
                "picked" => 2,
                "delivering" => 4,
                "delivered" => 5,
                "delivery_failed" => 10,
                "cancel" => -1,
                "return" => 8,
                "returned" => 9,
                "lost" => 13,
                "damage" => 13,
                "waiting_to_return" => 20,
                _ => 0
            };
        }
        private string GetStatusName(int status)
        {
            return status switch
            {
                -1 => "Đơn hàng đã hủy",
                1 => "Chờ lấy hàng",
                2 => "Đã lấy hàng",
                3 => "Đang vận chuyển",
                4 => "Đang giao hàng",
                5 => "Đã giao hàng",
                6 => "Đã đối soát",
                7 => "Không lấy được hàng",
                8 => "Hoàn hàng",
                9 => "Đã hoàn hàng",
                10 => "Không giao được hàng",
                11 => "Đã điều chỉnh COD",
                12 => "Đã điều chỉnh phí",
                13 => "Đơn hàng bị lỗi",
                20 => "Đang duyệt hoàn",
                21 => "Đã duyệt hoàn",
                _ => "Không xác định"
            };
        }
        public async Task<ShippingFeeResponse> CalculateShippingFee(ShippingFeeRequest request)
        {
            try
            {
                var feeRequest = new
                {
                    from_district_id = 1454, // Hardcoded district ID for testing
                    from_ward_code = "21211", // Hardcoded ward code for testing
                    to_district_id = request.ToDistrictId,
                    to_ward_code = request.ToWardCode,
                    height = request.Height,
                    length = request.Length,
                    weight = request.Weight,
                    width = request.Width,
                    insurance_value = request.InsuranceValue,
                    service_type_id = 2
                };

                var response = await _httpClient.PostAsJsonAsync("v2/shipping-order/fee", feeRequest);
                var responseContent = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"GHN Fee Calculation Error: {responseContent}");
                }

                return await response.Content.ReadFromJsonAsync<ShippingFeeResponse>();
            }
            catch (Exception ex)
            {
                throw new Exception($"Calculate shipping fee failed: {ex.Message}", ex);
            }
        }

        // Get provinces
        public async Task<ProvinceResponse> GetProvinces()
        {
            try
            {
                var response = await _httpClient.GetAsync("master-data/province");
                return await response.Content.ReadFromJsonAsync<ProvinceResponse>();
            }
            catch (Exception ex)
            {
                throw new Exception($"Get provinces failed: {ex.Message}", ex);
            }
        }

        // Get districts by province
        public async Task<DistrictResponse> GetDistricts(int provinceId)
        {
            try
            {
                var response = await _httpClient.GetAsync($"master-data/district?province_id={provinceId}");
                return await response.Content.ReadFromJsonAsync<DistrictResponse>();
            }
            catch (Exception ex)
            {
                throw new Exception($"Get districts failed: {ex.Message}", ex);
            }
        }

        // Get wards by district
        public async Task<WardResponse> GetWards(int districtId)
        {
            try
            {
                var response = await _httpClient.GetAsync($"master-data/ward?district_id={districtId}");
                return await response.Content.ReadFromJsonAsync<WardResponse>();
            }
            catch (Exception ex)
            {
                throw new Exception($"Get wards failed: {ex.Message}", ex);
            }
        }

        // Cancel shipping order
        public async Task<BaseResponse> CancelOrder(string orderCode)
        {
            try
            {
                var request = new { order_codes = new[] { orderCode } };
                var response = await _httpClient.PostAsJsonAsync("v2/switch-status/cancel", request);
                var responseContent = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"GHN Cancel Order Error: {responseContent}");
                }

                return await response.Content.ReadFromJsonAsync<BaseResponse>();
            }
            catch (Exception ex)
            {
                throw new Exception($"Cancel order failed: {ex.Message}", ex);
            }
        }

        // Print shipping label
        public async Task<string> PrintShippingLabel(string orderCode)
        {
            try
            {
                var request = new { order_codes = new[] { orderCode } };
                var response = await _httpClient.PostAsJsonAsync("v2/a5/gen-token", request);
                var responseContent = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"GHN Print Label Error: {responseContent}");
                }

                var printResponse = await response.Content.ReadFromJsonAsync<PrintResponse>();
                return printResponse.Data.Token;
            }
            catch (Exception ex)
            {
                throw new Exception($"Print shipping label failed: {ex.Message}", ex);
            }
        }

        public class GHNResponse
        {
            public int code { get; set; }
            public string message { get; set; }
            public GHNOrderData data { get; set; }
        }

        public class GHNOrderData
        {
            public string order_code { get; set; }
            public string expected_delivery_time { get; set; }
            public decimal total_fee { get; set; }
            public decimal insurance_fee { get; set; }
            public decimal cod_fee { get; set; }
            public int status { get; set; }
            public string status_name { get; set; }
        }

        public class ShippingOrderResponse
        {
            public int Code { get; set; }
            public string Message { get; set; }
            public string order_code { get; set; }
            public string expected_delivery_time { get; set; }
            public decimal total_fee { get; set; }
            public decimal insurance { get; set; }
            public decimal cod_fee { get; set; }
        }


        public class ShippingTrackingResponse
        {
            public int Code { get; set; }
            public string Message { get; set; }
            public TrackingData Data { get; set; }
        }

        public class TrackingData
        {
            public string OrderCode { get; set; }
            public string ClientOrderCode { get; set; }
            public int Status { get; set; }
            public string StatusName { get; set; }
            public DateTime CreatedDate { get; set; }
            public DateTime? LastUpdateDate { get; set; }
            public decimal TotalFee { get; set; }
            public List<TrackingLog> TrackingLogs { get; set; }
        }

        public class TrackingLog
        {
            public string Status { get; set; }
            public string StatusName { get; set; }
            public DateTime Timestamp { get; set; }
            public string Location { get; set; }
            public string Description { get; set; }
            public string Reason { get; set; }
        }
    }
    public class ShippingFeeResponse : BaseResponse
    {
        public FeeData Data { get; set; }
    }

    public class FeeData
    {
        public decimal Total { get; set; }
        public decimal ServiceFee { get; set; }
        public decimal InsuranceFee { get; set; }
        public decimal CodFee { get; set; }
        public string ExpectedDeliveryTime { get; set; }
    }

    public class ProvinceResponse : BaseResponse
    {
        public List<ProvinceData> Data { get; set; }
    }

    public class ProvinceData
    {
        public int ProvinceID { get; set; }
        public string ProvinceName { get; set; }
    }

    public class DistrictResponse : BaseResponse
    {
        public List<DistrictData> Data { get; set; }
    }

    public class DistrictData
    {
        public int DistrictID { get; set; }
        public string DistrictName { get; set; }
    }

    public class WardResponse : BaseResponse
    {
        public List<WardData> Data { get; set; }
    }

    public class WardData
    {
        public string WardCode { get; set; }
        public string WardName { get; set; }
    }

    public class PrintResponse : BaseResponse
    {
        public PrintData Data { get; set; }
    }

    public class PrintData
    {
        public string Token { get; set; }
    }

    public class BaseResponse
    {
        public int Code { get; set; }
        public string Message { get; set; }
    }
    public class ShippingFeeRequest
    {
        // Destination Information
        public string ToWardCode { get; set; }
        public int ToDistrictId { get; set; }

        // Package Dimensions
        public int Weight { get; set; }
        public int Length { get; set; } = 15;
        public int Width { get; set; } = 15;
        public int Height { get; set; } = 15;

        // Insurance and Service
        public decimal InsuranceValue { get; set; } = 0;
        public int ServiceTypeId { get; set; } = 2;

        // Optional Settings
        public bool IsFreeShip { get; set; } = false;
        public decimal CouponValue { get; set; } = 0;
    }
}
