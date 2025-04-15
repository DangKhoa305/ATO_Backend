using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO.Request
{
    public class ShippingOrderRequest
    {
        // Order Information - cần truyền
        public string client_order_code { get; set; }
        public string content { get; set; }
        public Guid ShipAddressId { get; set; }
        public decimal insurance_value { get; set; }
        public decimal cod_amount { get; set; }

        // Shop Information - không cần truyền 
        public string? from_name { get; set; } = "ATO Shop";
        public string? from_phone { get; set; }
        public string? from_address { get; set; }
        public string? from_ward_name { get; set; }
        public string? from_district_name { get; set; }
        public string? from_province_name { get; set; }
        public string? from_ward_code { get; set; }

        // Return Information
        public string? return_phone { get; set; }
        public string? return_address { get; set; }
        public int? return_district_id { get; set; }
        public string? return_ward_code { get; set; }


        // Customer Information - không cần truyền 
        public string? to_name { get; set; }
        public string? to_phone { get; set; }
        public string? to_address { get; set; }
        public string? to_ward_code { get; set; }
        public int? to_district_id { get; set; }

        // Package Information - không cần truyền 
        public int? weight { get; set; }
        public int? length { get; set; } = 15;
        public int? width { get; set; } = 15;
        public int? height { get; set; } = 15;

        // Delivery Settings - không cần truyền
        public int? pick_station_id { get; set; }
        public int? deliver_station_id { get; set; }
        public List<int>? pick_shift { get; set; }

        // Service Settings - không cần truyền
        public string? note { get; set; }
        public int? payment_type_id { get; set; } = 2;
        public int? service_type_id { get; set; } = 2;
        public int? service_id { get; set; }
        public string? required_note { get; set; } = "KHONGCHOXEMHANG";
        public string? coupon { get; set; }

        // Items Information
        public List<ShippingOrderItem> items { get; set; } = new List<ShippingOrderItem>();
    }

    public class ShippingOrderItem
    {
        public string name { get; set; }
        public string code { get; set; }
        public int quantity { get; set; }
        public int price { get; set; }
        public int length { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int weight { get; set; }
        public Category category { get; set; }
    }

    public class Category
    {
        public string level1 { get; set; }
    }
}
