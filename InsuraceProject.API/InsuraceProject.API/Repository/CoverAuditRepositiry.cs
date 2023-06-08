using InsuraceProject.API.Models;
using InsuraceProject.API.Repository.RepoInterfaces;
using InsuraceProject.Context;

namespace InsuraceProject.API.Repository
{
    public class CoverAuditRepositiry : ICoverAuditRepository
    {
        private readonly AuditContext _context;

        public CoverAuditRepositiry(AuditContext context)
        {
            _context = context;
        }

        public Task<IEnumerable<Cover>> GetAllCover()
        {
            throw new NotImplementedException();
        }
    }
}
