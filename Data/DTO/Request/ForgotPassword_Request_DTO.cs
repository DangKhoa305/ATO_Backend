using System.ComponentModel.DataAnnotations;

namespace Data.DTO.Request
{
    public class ForgotPassword_Request_DTO
    {
        public string username { get; set; }
    }
    public class ForgotPassword_DTO
    {
        [Required]
        public string username { get; set; }
        [Required]
        public string NewPassword { get; set; }
        [Required]
        public string ConfimPassword { get; set; }
    }

    public record ChangePasswordModel(string CurrentPassword, string NewPassword);
}
