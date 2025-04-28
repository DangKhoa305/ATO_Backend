using Data.Models;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.ContractSer
{
    public interface IContractService
    {
        Task<List<Contract>> ListContract();
        Task<Contract> GetContract(Guid ContractId);
        Task<bool> AddContract(Contract Contract);
        Task<bool> UpdateContract(Guid ContractId, Contract Contract);
        Task<List<Contract>> ListContractTourCompany(Guid userId);
        Task<bool> SendOTPAsync(Guid contractId);
        Task<bool> VerifyOtpAsync(Guid contractId, string requestOtp);
        Task<bool> SignContractAsync(Guid contractId);
        Task<bool> RejectContractAsync(Guid contractId);
        Task<bool> ExtendContractAsync(Guid contractId, int months);
        Task<bool> ApproveExtendContract(Guid contractId);
        Task<List<Data.Models.Contract>> ListContractFacility(Guid userId);
    }
}
