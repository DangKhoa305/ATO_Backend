using Data.DTO.Request;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Service.EmailSer;
using Service.Repository;
using System.Diagnostics.Contracts;

namespace Service.ContractSer;

public class ContractService(IRepository<Data.Models.Contract> contractRepository, IRepository<TouristFacility> touristFacilityRepository, IRepository<TourCompany> tourCompanyRepository, IMemoryCache cache, IEmailService emailService) : IContractService
{
    private readonly IRepository<Data.Models.Contract> _contractRepository = contractRepository;
    private readonly IRepository<TourCompany> _tourCompanyRepository = tourCompanyRepository;
    private readonly IRepository<TouristFacility> _touristFacilityRepository = touristFacilityRepository;
    private readonly IMemoryCache _cache = cache;
    private readonly TimeSpan _otpLifetime = TimeSpan.FromMinutes(5);
    private readonly IEmailService _emailService = emailService;

    public async Task<bool> AddContract(Data.Models.Contract Contract)
    {
        try
        {
            Contract.ContractId = Guid.NewGuid();
            Contract.CreateDate = DateTime.Now;
            await _contractRepository.AddAsync(Contract);

            return true;
        }
        catch (Exception)
        {
            throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
        }
    }

    public async Task<Data.Models.Contract> GetContract(Guid ContractId)
    {
        try
        {
            return await _contractRepository.Query()
                .Include(x => x.TourCompany)
                .Include(x => x.TouristFacility)
                .SingleOrDefaultAsync(x => x.ContractId == ContractId);
        }
        catch (Exception)
        {
            throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
        }
    }

    public async Task<List<Data.Models.Contract>> ListContract()
    {
        try
        {
            return await _contractRepository.Query()
                .Include(x => x.TourCompany)
                .Include(x => x.TouristFacility)
                .ToListAsync();
        }
        catch (Exception)
        {
            throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
        }
    }
    public async Task<List<Data.Models.Contract>> ListContractTourCompany(Guid userId)
    {
        try
        {
            TourCompany TourCompany = await _tourCompanyRepository.Query()
           .FirstOrDefaultAsync(x => x.UserId == userId);
            return await _contractRepository.Query()
                .Include(x => x.TourCompany)
                .Include(x => x.TouristFacility)
                .Where(x => x.TourCompanyId == TourCompany.TourCompanyId)
                .ToListAsync();
        }
        catch (Exception)
        {
            throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
        }
    }
    public async Task<List<Data.Models.Contract>> ListContractFacility(Guid userId)
    {
        try
        {
            TouristFacility TouristFacility = await _touristFacilityRepository.Query()
           .FirstOrDefaultAsync(x => x.UserId == userId);
            return await _contractRepository.Query()
                .Include(x => x.TourCompany)
                .Include(x => x.TouristFacility)
                .Where(x => x.TourCompanyId == TouristFacility.TouristFacilityId)
                .ToListAsync();
        }
        catch (Exception)
        {
            throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
        }
    }
    public async Task<bool> SendOTPAsync(Guid contractId)
    {
        try
        {
            var exist = await _contractRepository.Query()
                    .Include(x => x.TourCompany)
                    .Include(x => x.TouristFacility)
                    .FirstOrDefaultAsync();
            var email = "";
            if (exist == null) throw new Exception();
            else if (exist.TourCompany != null) email = exist.TourCompany.EmailCompany;
            else if (exist.TouristFacility != null) email = exist.TouristFacility.EmailTouristFacility;
            if (email == null)
            {
                return false;
            }
            var otp = new Random().Next(100000, 999999).ToString();
            EmailRequest emailRequest = new EmailRequest();
            emailRequest.ToEmail = email;
            emailRequest.Subject = "Xác thực ký kết";
            emailRequest.Body = $"Mã ký kết của bạn là: {otp}";
            _cache.Set(emailRequest.ToEmail, otp, _otpLifetime);
            await _emailService.SendEmailAsync(emailRequest);
            return true;
        }
        catch (Exception)
        {
            throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
        }

    }
    public async Task<bool> SignContractAsync(Guid contractId)
    {
        try
        {
            var exist = await _contractRepository.GetByIdAsync(contractId);
            exist.UpdateDate = DateTime.UtcNow;
            exist.Status = exist.Status == false ? true : exist.Status;
            exist.SigningStatus = SigningStatus.Signed;

            await _contractRepository.UpdateAsync(exist);
            return true;
        }
        catch (Exception)
        {
            throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
        }

    }
    public async Task<bool> UpdateContract(Guid ContractId, Data.Models.Contract Contract)
    {
        try
        {
            var exist = await _contractRepository.GetByIdAsync(ContractId);
            exist.Status = Contract.Status;
            exist.ContractContent = Contract.ContractContent;
            exist.StartDate = Contract.StartDate;
            exist.EndDate = Contract.EndDate;
            exist.SignedDate = Contract.SignedDate;
            exist.RequestReSignContract = Contract.RequestReSignContract;
            exist.UpdateDate = DateTime.UtcNow;
            exist.SigningStatus = SigningStatus.New;

            await _contractRepository.UpdateAsync(Contract);

            return true;
        }
        catch (Exception)
        {
            throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
        }
    }

    public async Task<bool> ExtendContract(Guid contractId)
    {
        try
        {
            var exist = await _contractRepository.GetByIdAsync(contractId);
            exist.RequestReSignContract = true;
            exist.SigningStatus = SigningStatus.RequestExtend;

            return true;
        }
        catch (Exception)
        {
            throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
        }
    }

    public async Task<bool> ApproveExtendContract(Guid contractId)
    {
        try
        {
            var exist = await _contractRepository.GetByIdAsync(contractId);
            exist.RequestReSignContract = false;
            exist.SigningStatus = SigningStatus.ApprovedExtend;

            return true;
        }
        catch (Exception)
        {
            throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
        }
    }
}
