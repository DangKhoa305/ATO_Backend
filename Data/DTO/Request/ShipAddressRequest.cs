namespace Data.DTO.Respone
{
    public class ShipAddressRequest : AddShipAddressRequest
    {
        public Guid ShipAddressId { get; set; }
    }

    public class AddShipAddressRequest
    {
        public bool DefaultAddress { get; set; }
        public string ToName { get; set; }
        public string ToPhone { get; set; }

        // Province
        public int ToProvinceId { get; set; }
        public string ToProvinceName { get; set; }

        // District
        public int ToDistrictId { get; set; }
        public string ToDistrictName { get; set; }

        // Ward
        public string ToWardCode { get; set; }
        public string ToWardName { get; set; }
    }
}
