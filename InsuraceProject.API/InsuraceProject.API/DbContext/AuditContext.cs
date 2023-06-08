using InsuraceProject.API.DbEntities;
using Microsoft.EntityFrameworkCore;

namespace InsuraceProject.Context
{
    public class AuditContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public DbSet<ClaimAudit> ClaimAudits { get; set; }
        public DbSet<CoverAudit> CoverAudits { get; set; }

        public AuditContext(DbContextOptions<AuditContext> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClaimAudit>()
                    .HasData(
                    new ClaimAudit()
                    {
                        Id = 1,
                        ClaimId = "1",
                        HttpRequestType = "Https",
                        Created = DateTime.UtcNow,
                        DamageCost = 122.22m
                    },
                    new ClaimAudit()
                    {
                        Id = 2,
                        ClaimId = "2",
                        HttpRequestType = "Https",
                        Created = DateTime.UtcNow - TimeSpan.FromDays(12),
                        DamageCost = 5.2m
                    },
                    new ClaimAudit()
                    {
                        Id = 3,
                        ClaimId = "3",
                        HttpRequestType = "Https",
                        Created = DateTime.UtcNow - TimeSpan.FromDays(2),
                        DamageCost = 34.13m
                    },
                    new ClaimAudit()
                    {
                        Id = 4,
                        ClaimId = "4",
                        HttpRequestType = "Https",
                        Created = DateTime.UtcNow - TimeSpan.FromDays(5)
                    }
                );

            modelBuilder.Entity<CoverAudit>()
                  .HasData(
                    new CoverAudit()
                    {
                        Id = 1,
                        CoverId = "1",
                        Created = DateTime.UtcNow,
                        HttpRequestType = "Https"
                    }, new CoverAudit()
                    {
                        Id = 2,
                        CoverId = "2",
                        Created = DateTime.UtcNow - TimeSpan.FromDays(3),
                        HttpRequestType = "Https"
                    }, 
                    new CoverAudit()
                    {
                        Id = 3,
                        CoverId = "3",
                        Created = DateTime.UtcNow - TimeSpan.FromDays(10),
                        HttpRequestType = "Https"
                    }, 
                    new CoverAudit()
                    {
                        Id = 4,
                        CoverId = "4",
                        Created = DateTime.UtcNow - TimeSpan.FromDays(5),
                        HttpRequestType = "Https"
                    }
                   
                ) ;


          base.OnModelCreating(modelBuilder);
        }

    }
}
