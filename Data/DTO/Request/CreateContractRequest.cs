using Data.Models;

namespace Data.DTO.Request;
public class CreateContractRequest
{
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
    public SigningStatus SigningStatus { get; set; } = SigningStatus.New;
}

public class UpdateContractRequest : CreateContractRequest
{
    public Guid? ContractId { get; set; }
}
