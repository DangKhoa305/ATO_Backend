using Data.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.FacilityCertificationSer;

public interface IFacilityCertificationService
{
    Task<FacilityCertification> GetByIdAsync(Guid id);
    Task<List<FacilityCertification>> GetAll();
    Task<List<FacilityCertification>> GetAllByFacilityAsync(Guid facilityId);
    Task<bool> CreateAsync(FacilityCertification certification);
    Task<bool> UpdateAsync(Guid id, FacilityCertification certification);
    Task<bool> DeleteAsync(Guid id);
    Task<bool> ApproveCertificationAsync(Guid id, string? reply);
    Task<bool> RejectCertificationAsync(Guid id, string? reply);
}