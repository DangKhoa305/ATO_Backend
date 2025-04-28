using Data.Models;

namespace Service.WithdrawalSer
{
    public interface IWithdrawalService
    {
        Task<List<WithdrawalRequest>> GetUserWithdrawalRequests(Guid userId);
        Task<List<WithdrawalRequest>> GetAllPendingRequests();
        Task<bool> CreateWithdrawalRequest(WithdrawalRequest request);
        Task<bool> ProcessWithdrawalRequest(Guid requestId, bool isApproved, string adminResponse, Guid adminId);
        Task<bool> CompleteWithdrawal(Guid requestId, string note, string image);
        Task<bool> CancelWithdrawal(Guid requestId, string note);
        Task<List<WithdrawalHistory>> GetUserWithdrawalHistory(Guid userId);
        Task<List<WithdrawalHistory>> GetWithdrawalHistory_Admin();
        Task<bool> GenerateMonthlyWithdrawals();
        Task<WithdrawalHistory> GetWithdrawalHistory(Guid id);

    }
}