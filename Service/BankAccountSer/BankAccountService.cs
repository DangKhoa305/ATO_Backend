using Data.DTO.Request;
using Data.DTO.Response;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Pipelines.Sockets.Unofficial.Buffers;
using Service.Repository;

namespace Service.BankAccountSer;

public class BankAccountService(
    IRepository<BankAccount> bankAccountRepo,
    IRepository<TourCompany> tourCompanyRepo,
    IRepository<TouristFacility> facilityRepo
    ) : IBankAccountService
{
    private readonly IRepository<BankAccount> _bankAccountRepo = bankAccountRepo;
    private readonly IRepository<TourCompany> _tourCompanyRepo = tourCompanyRepo;
    private readonly IRepository<TouristFacility> _facilityRepo = facilityRepo;

    public async Task<BankAccountResponse> CreateBankAccount(BankAccountRequest request, Guid? ownerId)
    {
        var bankAccount = new BankAccount
        {
            BankAccountId = Guid.NewGuid(),
            OwnerId = ownerId ?? Guid.Empty,
            OwnerType = request.OwnerType,
            BankName = request.BankName,
            AccountNumber = request.AccountNumber,
            AccountName = request.AccountName,
            BranchName = request.BranchName,
            CreatedDate = DateTime.UtcNow,
            IsPrimary = request.IsPrimary
        };

        if (request.IsPrimary)
        {
            await ResetPrimary(ownerId);
        }

        await _bankAccountRepo.AddAsync(bankAccount);
        return MapToResponse(bankAccount);
    }

    private async Task ResetPrimary(Guid? ownerId)
    {
        var accounts = await _bankAccountRepo.Query()
            .Where(x => x.OwnerId == ownerId).ToListAsync();
        accounts.ForEach(accounts => accounts.IsPrimary = false);

        await _bankAccountRepo.RealUpdateRangeAsync(accounts);
    }

    private static BankAccountResponse MapToResponse(BankAccount bankAccount)
    {
        return new BankAccountResponse
        {
            BankAccountId = bankAccount.BankAccountId,
            BankName = bankAccount.BankName,
            AccountNumber = bankAccount.AccountNumber,
            AccountName = bankAccount.AccountName,
            BranchName = bankAccount.BranchName,
            IsPrimary = bankAccount.IsPrimary,
            CreatedDate = bankAccount.CreatedDate,
            UpdatedDate = bankAccount.UpdatedDate
        };
    }

    public async Task<BankAccountResponse> UpdateBankAccount(Guid bankAccountId, BankAccountRequest request)
    {
        var bankAccount = await _bankAccountRepo.GetByIdAsync(bankAccountId);
        if (bankAccount == null)
            throw new KeyNotFoundException("Bank account not found");

        bankAccount.BankName = request.BankName;
        bankAccount.AccountNumber = request.AccountNumber;
        bankAccount.AccountName = request.AccountName;
        bankAccount.BranchName = request.BranchName;
        bankAccount.IsPrimary = request.IsPrimary;
        bankAccount.UpdatedDate = DateTime.UtcNow;

        await _bankAccountRepo.UpdateAsync(bankAccount);
        return MapToResponse(bankAccount);
    }

    public async Task<bool> DeleteBankAccount(Guid bankAccountId)
    {
        var bankAccount = await _bankAccountRepo.GetByIdAsync(bankAccountId);
        if (bankAccount == null)
            throw new KeyNotFoundException("Bank account not found");

        await _bankAccountRepo.DeleteAsync(bankAccount);
        return true;
    }

    public async Task<List<BankAccountResponse>> GetBankAccountsByOwner(Guid ownerId)
    {
        var accounts = await _bankAccountRepo.Query()
            .Where(x => x.OwnerId == ownerId)
            .Where(x => x.IsPrimary)
            .ToListAsync();

        return accounts.Select(MapToResponse).ToList();
    }

    public async Task<Guid?> GetOwnerId(Guid id)
    {
        var company = await _tourCompanyRepo.Query()
            .Where(x => x.UserId == id).FirstOrDefaultAsync();

        var facility = await _facilityRepo.Query()
            .Where(x => x.UserId == id).FirstOrDefaultAsync();

        var ownerId = company is not null ? company.TourCompanyId : facility?.TouristFacilityId;
        return ownerId;
    }

    public async Task<List<BankAccountResponse>> GetBankAccountsByUser(Guid id)
    {
        var company = await _tourCompanyRepo.Query()
            .Where(x => x.UserId == id).FirstOrDefaultAsync();

        var facility = await _facilityRepo.Query()
            .Where(x => x.UserId == id).FirstOrDefaultAsync();

        var ownerId = company is not null ? company.TourCompanyId : facility?.TouristFacilityId;

        var accounts = await _bankAccountRepo.Query()
             .Where(x => x.OwnerId == ownerId)
             .ToListAsync();

        return accounts.Select(MapToResponse).ToList();
    }

    public async Task<BankAccountResponse> GetBankAccount(Guid bankAccountId)
    {
        var bankAccount = await _bankAccountRepo.GetByIdAsync(bankAccountId);
        if (bankAccount == null)
            throw new KeyNotFoundException("Bank account not found");

        return MapToResponse(bankAccount);
    }

    public async Task<bool> SetPrimaryAccount(Guid bankAccountId)
    {
        var bankAccount = await _bankAccountRepo.GetByIdAsync(bankAccountId);
        if (bankAccount == null)
            throw new KeyNotFoundException("Bank account not found");

        // Reset all accounts for this owner to non-primary
        var accounts = await _bankAccountRepo.Query()
            .Where(x => x.OwnerId == bankAccount.OwnerId)
            .ToListAsync();

        foreach (var account in accounts)
        {
            account.IsPrimary = false;
            await _bankAccountRepo.UpdateAsync(account);
        }

        // Set the selected account as primary
        bankAccount.IsPrimary = true;
        await _bankAccountRepo.UpdateAsync(bankAccount);

        return true;
    }

}