using System.ComponentModel.DataAnnotations;

namespace InsuraceProject.API.DbEntities
{
    public class CoverAudit
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string CoverId { get; set; }

        [Required]
        public DateTime Created { get; set; }

        [Required]
        [MaxLength(255)]
        public string HttpRequestType { get; set; }
    }
}
