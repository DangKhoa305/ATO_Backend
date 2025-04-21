using System;

namespace Data.Models
{
    public class WithdrawalHistory
    {
        public Guid WithdrawalId { get; set; }
        public Guid RequestId { get; set; }
        public Guid UserId { get; set; }
        public decimal Amount { get; set; }
        public string TransactionReference { get; set; }
        public DateTime ProcessedDate { get; set; }
        public string? Note { get; set; }

        // Navigation properties
        public virtual WithdrawalRequest? Request { get; set; }
        public virtual Account? User { get; set; }
    }
}