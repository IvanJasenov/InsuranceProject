using AutoMapper;
using InsuraceProject.API.Repository.RepoInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace InsuraceProject.API.Controllers
{
    public class CoverController: ControllerBase
    {
        private readonly ILogger<ClaimsController> _logger;
        private readonly IClaimAuditRepository _repository;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public CoverController(ILogger<ClaimsController> logger, IClaimAuditRepository repository, IMapper mapper, IConfiguration configuration)
        {
            _logger = logger;
            _repository = repository;
            _mapper = mapper;
            _configuration = configuration;
        }
    }
}
