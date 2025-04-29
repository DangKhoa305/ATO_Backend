namespace Data.Models;
public class FacilityCertification

{

    public Guid CertificationId { get; set; }

    public string CertificationName { get; set; }

    public List<string>? Imgs { get; set; }

    public DateTime IssueDate { get; set; }

    public DateTime ExpiryDate { get; set; }

    public string? CertificationDetails { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    // Request Certificate

    public StatusApproval StatusApproval { get; set; }

    public string? ReplyRequest { get; set; }

    //FK

    public Guid? TouristFacilityId { get; set; }

    public virtual TouristFacility? TouristFacility { get; set; }

}
