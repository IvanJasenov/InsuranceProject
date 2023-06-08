using AutoMapper;
using InsuraceProject.API.DbEntities;
using InsuraceProject.API.Models;

namespace InsuraceProject.API.MapProfiles
{
    public class CoverProfile : Profile
    {
        public CoverProfile() 
        {
            CreateMap<ClaimAudit, Claim>();
        }
    }
}
