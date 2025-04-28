using Data.DTO.Request;
using Data.DTO.Response;

namespace Service.BankAccountSer
{
    public interface IBankAccountService
    {
        Task<BankAccountResponse> CreateBankAccount(BankAccountRequest request, Guid? ownerId);
        Task<BankAccountResponse> UpdateBankAccount(Guid bankAccountId, BankAccountRequest request);
        Task<bool> DeleteBankAccount(Guid bankAccountId);
        Task<List<BankAccountResponse>> GetBankAccountsByOwner(Guid ownerId);
        Task<List<BankAccountResponse>> GetBankAccountsByUser(Guid id);
        Task<Guid?> GetOwnerId(Guid id);
        Task<BankAccountResponse> GetBankAccount(Guid bankAccountId);
        Task<bool> SetPrimaryAccount(Guid bankAccountId);
    }
}