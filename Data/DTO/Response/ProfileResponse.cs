namespace Data.DTO.Response;

public class ProfileResponse
{
    public Guid Id { get; set; }
    public string? Email { get; set; }
    public string? FullName { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Address { get; set; }
    public DateTime Dob { get; set; }
    public string? AvatarURL { get; set; }
    public string? Role { get; set; }
}