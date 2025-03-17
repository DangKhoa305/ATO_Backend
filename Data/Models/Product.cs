using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Product
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public List<string>? Imgs { get; set; }
        public double? Price { get; set; }
        public string? Description { get; set; }
        public string? Additional { get; set; }
        public string? NutritionType { get; set; }
        public string? Age { get; set; }
        public string? Ingredient { get; set; }
        public string? Volume { get; set; }
        public string? Origin { get; set; }
        public string? Manufacturer { get; set; }
        public string? AddressManufacturer { get; set; }
        public UnitProduct? UnitProduct { get; set; }
        //category
        public ProductCategory ProductCategory { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public StatusApproval StatusApproval { get; set; }
        public string? ReplyRequest { get; set; }
        //FK
        public Guid TouristFacilityId { get; set; }
        public virtual TouristFacility? TouristFacility { get; set; }
        public virtual ICollection<Certification>? Certifications { get; set; }
        public virtual ICollection<OCOPSell>? OCOPSells { get; set; }
    }
    public enum ProductCategory
    {
        [Description("Thực phẩm")]
        Food,
        [Description("Đồ uống")]
        Beverage,
        [Description("Thảo dược")]
        HerbalMedicine,
        [Description("Vải may mặc")]
        Textiles,
        [Description("Lưu niệm - Nội thất - Trang trí")]
        SouvenirsFurnitureDecoration,
        [Description("Dịch vụ du lịch cộng đồng và điểm du lịch")]
        CommunityTourismServicesAndTouristAttractions,
        [Description("Khác")]
        Orther
    }
    public enum UnitProduct
    {
        Kg, g, mg, l, ml
    }
}
