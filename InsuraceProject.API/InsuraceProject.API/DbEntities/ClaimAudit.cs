using System.ComponentModel.DataAnnotations;

namespace InsuraceProject.API.DbEntities
{
    public class ClaimAudit
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string ClaimId { get; set; }

        [Required]
        public DateTime Created { get; set; }

        [Required]
        [MaxLength(255)]
        public string HttpRequestType { get; set; }

        public decimal DamageCost { get; set; }
    }
}
