using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO.Respone
{
    public class ProductDTO
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public List<string> Imgs { get; set; }
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
        public string DescriptionAPI { get; set; } =
            "UnitProduct(0-Kg,1-g, 2-mg, 3-l, 4-ml), ProductCategory(0-Food,1-Beverage,2-HerbalMedicine,3-Textiles, 4-SouvenirsFurnitureDecoration, 5-CommunityTourismServicesAndTouristAttractions, 6-Orther)";
    }
    public class CreateProductDTO
    {
        public string ProductName { get; set; }
        public List<string> Imgs { get; set; }
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
        public ProductCategory ProductCategory { get; set; }
    }
    public class UpdateProductDTO
    {
        public string ProductName { get; set; }
        public List<string> Imgs { get; set; }
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
        public ProductCategory ProductCategory { get; set; }
    }
    public class ProductDTO_CM
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public List<string> Imgs { get; set; }
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
        public ProductCategory ProductCategory { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public StatusApproval StatusApproval { get; set; }
        public string? ReplyRequest { get; set; }
        public Guid TouristFacilityId { get; set; }
        public virtual TouristFacilityDTO_Certfication? TouristFacility { get; set; }
        public virtual ICollection<CertificationRespone>? Certifications { get; set; }
    }
}
