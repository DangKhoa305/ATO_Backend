using Data.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.WithdrawalSer
{
    public interface IWithdrawalService
    {
        Task<List<WithdrawalRequest>> GetUserWithdrawalRequests(Guid userId);
        Task<List<WithdrawalRequest>> GetAllPendingRequests();
        Task<bool> CreateWithdrawalRequest(WithdrawalRequest request);
        Task<bool> ProcessWithdrawalRequest(Guid requestId, bool isApproved, string adminResponse, Guid adminId);
        Task<bool> CompleteWithdrawal(Guid requestId, string transactionReference);
        Task<List<WithdrawalHistory>> GetUserWithdrawalHistory(Guid userId);
    }
}