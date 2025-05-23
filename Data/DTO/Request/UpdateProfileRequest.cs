﻿namespace Data.DTO.Request
{
    public class UpdateProfileRequest
    {
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime Dob { get; set; }
        public string? AvatarURL { get; set; }
    }
}