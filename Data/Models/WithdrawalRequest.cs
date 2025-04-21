using System;

namespace Data.Models
{
    public class WithdrawalRequest
    {
        public Guid RequestId { get; set; }
        public Guid UserId { get; set; }
        public decimal Amount { get; set; }
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string? Note { get; set; }
        public WithdrawalRequestStatus Status { get; set; }
        public DateTime RequestDate { get; set; }
        public DateTime? ProcessedDate { get; set; }
        public string? AdminResponse { get; set; }

        // Navigation properties
        public virtual Account? User { get; set; }
    }

    public enum WithdrawalRequestStatus
    {
        Pending,
        Approved,
        Rejected,
        Completed
    }
}