using AutoMapper;
using InsuraceProject.API.DbEntities;
using InsuraceProject.API.Models;

namespace InsuraceProject.API.MapProfiles
{
    public class ClaimProfile : Profile
    {
        public ClaimProfile()
        {
            CreateMap<ClaimAudit, Claim>();
        }
        

    }
}
