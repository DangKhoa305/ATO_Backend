namespace Data.DTO.Response;

public class ProfileResponse
{
    public Guid UserId { get; set; }
    public string? Email { get; set; }
    public string? FullName { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Address { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string? Avatar { get; set; }
    public string? Role { get; set; }
    public DateTime CreatedDate { get; set; }
}