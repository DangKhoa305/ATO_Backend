namespace Data.Models
{
    public class Contract
    {
        public Guid ContractId { get; set; }
        public string? ContractContent { get; set; }
        public decimal? DiscountRate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? SignedDate { get; set; }
        public bool? Status { get; set; }
        public bool? RequestReSignContract { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid? TourCompanyId { get; set; }
        public Guid? TouristFacilityId { get; set; }
        public virtual TourCompany? TourCompany { get; set; }
        public virtual TouristFacility? TouristFacility { get; set; }
        public SigningStatus SigningStatus { get; set; } = SigningStatus.New;
    }


    public enum SigningStatus
    {
        New = 0,
        Signed = 1,
        RequestExtend = 2,
        ApprovedExtend = 3,
        AboutToEnd = 4,
        Ended = 5,
        Rejected = 6
    }
}
