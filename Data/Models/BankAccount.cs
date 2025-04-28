using System;

namespace Data.Models
{
    public class BankAccount
    {
        public Guid BankAccountId { get; set; }
        public Guid OwnerId { get; set; } // Can be CompanyId or FacilityId
        public OwnerType OwnerType { get; set; }
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string BranchName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsPrimary { get; set; }
    }

    public enum OwnerType
    {
        Company,
        Facility
    }
}