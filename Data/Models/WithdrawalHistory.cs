using System;

namespace Data.Models
{
    public class WithdrawalHistory
    {
        public Guid WithdrawalId { get; set; }
        public decimal Amount { get; set; }
        public string? TransactionReference { get; set; }
        public DateTime ProcessedDate { get; set; }
        public string? Note { get; set; }
        public string? TransactionImage { get; set; }
        public WithdrawalStatus WithdrawalStatus { get; set; } = WithdrawalStatus.New;

        public Guid? BankAccountId { get; set; }

        // Navigation properties
        public Guid? TourCompanyId { get; set; }
        public Guid? TouristFacilityId { get; set; }
        public virtual TourCompany? TourCompany { get; set; }
        public virtual TouristFacility? TouristFacility { get; set; }
    }

    public enum WithdrawalStatus
    {
        New = 0,
        InProgress = 1,
        Completed = 2,
        Cancelled = 3
    }

}