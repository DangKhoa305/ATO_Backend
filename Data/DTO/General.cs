namespace Data.DTO;

public record IdentityModel(string? Name, string? Phone, string? Email);

public class TourInfo
{
    public bool IsStarted { get; set; }
    public IEnumerable<IdentityModel> Tourists { get; set; } = [];
    public IEnumerable<IdentityModel> TourGuides { get; set; } = [];
    public IdentityModel? TourCompany { get; set; }
    public string? Location { get; set; }
}
public record Notification(string Message);