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


    public class ProductDTO_Guest
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
        public double SellVolume { get; set; }
        //category
        public ProductCategory ProductCategory { get; set; }
        public Guid TouristFacilityId { get; set; }
        public virtual ProductDTO_TouristFacility? TouristFacility { get; set; }
        public virtual ICollection<CertificationRespone_Guest>? Certifications { get; set; }
        public DateTime ExpirationDate { get; set; }
        public IEnumerable<OCOPSellDTO> Variations { get; set; } = [];
        public Guid OcopId { get; set; }
    }
    public class ProductDTO_TouristFacility
    {
        public Guid TouristFacilityId { get; set; }
        public string TouristFacilityName { get; set; }
        public string? Description { get; set; }
        public string? ContactInfor { get; set; }
        public string? EmailTouristFacility { get; set; }
        public string? Website { get; set; }
        public string? LogoURL { get; set; }
    }
}
