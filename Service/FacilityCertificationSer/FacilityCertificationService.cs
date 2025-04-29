using Data.Models;
using Microsoft.EntityFrameworkCore;
using Service.Repository;

namespace Service.FacilityCertificationSer;

public class FacilityCertificationService(IRepository<FacilityCertification> certificationRepo) : IFacilityCertificationService
{
    private readonly IRepository<FacilityCertification> _certificationRepo = certificationRepo;

    public async Task<FacilityCertification> GetByIdAsync(Guid id)
    {
        return await _certificationRepo.Query()
            .Include(x => x.TouristFacility)
            .Where(x => x.CertificationId == id)
            .FirstOrDefaultAsync();
    }

    public async Task<List<FacilityCertification>> GetAllByFacilityAsync(Guid facilityId)
    {
        return await _certificationRepo.Query()
            .Where(c => c.TouristFacilityId == facilityId)
             .Include(x => x.TouristFacility)
            .ToListAsync();
    }

    public async Task<bool> CreateAsync(FacilityCertification certification)
    {
        certification.CertificationId = Guid.NewGuid();
        certification.CreateDate = DateTime.UtcNow;
        await _certificationRepo.AddAsync(certification);
        return true;
    }

    public async Task<bool> UpdateAsync(Guid id, FacilityCertification certification)
    {
        var existing = await _certificationRepo.GetByIdAsync(id);
        if (existing == null) return false;

        existing.CertificationName = certification.CertificationName;
        existing.Imgs = certification.Imgs;
        existing.IssueDate = certification.IssueDate;
        existing.ExpiryDate = certification.ExpiryDate;
        existing.CertificationDetails = certification.CertificationDetails;
        existing.UpdateDate = DateTime.UtcNow;

        await _certificationRepo.UpdateAsync(existing);
        return true;
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        var certification = await _certificationRepo.GetByIdAsync(id);
        if (certification == null) return false;

        await _certificationRepo.DeleteAsync(certification);
        return true;
    }

    public async Task<bool> ApproveCertificationAsync(Guid id, string? reply)
    {
        var certification = await _certificationRepo.GetByIdAsync(id);
        if (certification == null) return false;

        certification.StatusApproval = StatusApproval.Approved;
        certification.ReplyRequest = reply;
        certification.UpdateDate = DateTime.UtcNow;

        await _certificationRepo.UpdateAsync(certification);
        return true;
    }

    public async Task<bool> RejectCertificationAsync(Guid id, string? reply)
    {
        var certification = await _certificationRepo.GetByIdAsync(id);
        if (certification == null) return false;

        certification.StatusApproval = StatusApproval.Reject;
        certification.ReplyRequest = reply;
        certification.UpdateDate = DateTime.UtcNow;

        await _certificationRepo.UpdateAsync(certification);
        return true;
    }

    public async Task<List<FacilityCertification>> GetAll()
    {
        return await _certificationRepo.Query()
            .Include(x => x.TouristFacility)
            .ToListAsync();
    }
}