using Data.Models;

namespace Data.DTO.Request
{
    public class BankAccountRequest
    {
        public OwnerType OwnerType { get; set; }
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string BranchName { get; set; }
        public bool IsPrimary { get; set; }
    }
}