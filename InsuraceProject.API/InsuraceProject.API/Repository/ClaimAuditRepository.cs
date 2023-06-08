using InsuraceProject.API.DbEntities;
using InsuraceProject.API.Models;
using InsuraceProject.API.Repository.RepoInterfaces;
using InsuraceProject.Context;
using Microsoft.EntityFrameworkCore;

namespace InsuraceProject.API.Repository
{
    public class ClaimAuditRepository : IClaimAuditRepository
    {
        private readonly AuditContext _context;

        public ClaimAuditRepository(AuditContext context)
        {
            _context = context;
        }

        public async Task<int> CreteClaim(ClaimAudit model)
        {
            await _context.ClaimAudits.AddAsync(model);
            var res = await _context.SaveChangesAsync();
            return res;
        }

        public async Task<int> DeleteClaim(string claimId)
        {
            ClaimAudit res = await GetClaimById(claimId);
            if (res != null)
            {
                _context.ClaimAudits.Remove(res);
                return await _context.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<IEnumerable<ClaimAudit>> GetAllClaims()
        {
            return await _context.ClaimAudits.ToListAsync();
        }

        public async Task<ClaimAudit> GetClaimById(string claimId)
        {
            return await _context.ClaimAudits.FirstOrDefaultAsync(el => el.ClaimId == claimId);
        }
    }
}
