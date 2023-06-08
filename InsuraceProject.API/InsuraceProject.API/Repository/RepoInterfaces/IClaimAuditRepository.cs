using InsuraceProject.API.DbEntities;
using InsuraceProject.API.Models;

namespace InsuraceProject.API.Repository.RepoInterfaces
{
    public interface IClaimAuditRepository
    {
        Task<IEnumerable<ClaimAudit>> GetAllClaims();

        Task<int> CreteClaim(ClaimAudit model);

        Task<ClaimAudit> GetClaimById(string claimId);

        Task<int> DeleteClaim(string claimId);
    }
}
