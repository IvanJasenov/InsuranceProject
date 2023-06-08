using InsuraceProject.API.DbEntities;
using InsuraceProject.API.Models;

namespace InsuraceProject.API.Repository.RepoInterfaces
{
    public interface ICoverAuditRepository
    {
        Task<IEnumerable<Cover>> GetAllCover();
    }
}
