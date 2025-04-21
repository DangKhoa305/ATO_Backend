using Data.Models;

namespace Data.DTO.Response;

public class AdminBalanceHistoryResponse
{
    public Guid TransactionId { get; set; }
    public decimal Amount { get; set; }
    public string? Description { get; set; }
    public TransactionType TransactionType { get; set; }
    public DateTime TransactionDate { get; set; }
    public string? OrderReference { get; set; }
    public string? BookingReference { get; set; }
    public decimal RunningBalance { get; set; }
}