using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace InsuraceProject.API.Models
{
    public class Claim
    {
        public int Id { get; set; }

        [Required]
        public string CoverId { get; set; }

        [Required]
        public DateTime Created { get; set; }

        public string? Name { get; set; }

        [Required]
        public ClaimType Type { get; set; } = ClaimType.Grounding;

        [Required]
        public decimal DamageCost { get; set; }
    }

    public enum ClaimType
    {
        Collision = 0,
        Grounding = 1,
        BadWeather = 2,
        Fire = 3
    }
}
