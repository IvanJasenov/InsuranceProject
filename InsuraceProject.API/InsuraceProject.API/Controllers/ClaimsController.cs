using AutoMapper;
using InsuraceProject.API.DbEntities;
using InsuraceProject.API.Models;
using InsuraceProject.API.Repository.RepoInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace InsuraceProject.API.Controllers
{
    [ApiController]
    public class ClaimsController : ControllerBase
    {
        private readonly ILogger<ClaimsController> _logger;
        private readonly IClaimAuditRepository _repository;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public ClaimsController(ILogger<ClaimsController> logger, IClaimAuditRepository repository, IMapper mapper, IConfiguration configuration)
        {
            _logger = logger;
            _repository = repository;
            _mapper = mapper;
            _configuration = configuration;

        }


        [HttpGet("api/claims")]
        public async Task<IActionResult> GetClaims()
        {
            try
            {
                var claims = await _repository.GetAllClaims();
                var maped = _mapper.Map<List<Claim>>(claims);
                return Ok(maped);
            }
            catch (Exception ex)
            {

                _logger.LogCritical($"Exception while getting all claims, exception: {ex.Message}");
                return StatusCode(500, "A problem hapened while handling your request");
            }
           
        }

        [HttpGet("api/getclaim")]
        public async Task<IActionResult> GetClaimBuId([FromQuery] string claimId)
        {
            ClaimAudit res = await _repository.GetClaimById(claimId);
            if (res == null)
            {
                return NotFound();
            }
            Claim claim = _mapper.Map<Claim>(res);

            return Ok(claim);
        }

        [HttpPost("api/createclaim")]
        public async Task<IActionResult> CreateClaim([FromBody] Claim model)
        {
            if (!ModelState.IsValid) 
            {
                return BadRequest(ModelState);
            }
            Random rnd = new Random();
            ClaimAudit req = new ClaimAudit()
            {
                ClaimId = Guid.NewGuid().ToString(),
                Created = DateTime.UtcNow,
                DamageCost = model.DamageCost,
                HttpRequestType = _configuration.GetValue<string>("ProtocolType")
                
            };
            //ClaimAudit req = _mapper.Map<ClaimAudit>(model);
            int res = await _repository.CreteClaim(req);
            if (res > 0) 
            {
                return Ok(new { message = "claim created" });
            }
            return BadRequest();
        }

        [HttpDelete("api/claims/delete/{claimId}")]
        public async Task<IActionResult> DeleteClaim(string claimId)
        {
            int res = await _repository.DeleteClaim(claimId);
            if (res > 0)
            {
                return Ok(new { message = $"Claim with claimId={claimId} deleted" });
            }
            return NotFound();
        }

    }
}
