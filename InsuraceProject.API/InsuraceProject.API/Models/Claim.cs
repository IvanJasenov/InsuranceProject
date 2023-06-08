using InsuraceProject.API.Validation;
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
        [CreateEndDateValidation]
        public DateTime Created 
        {
            get => this.Created; 
            set 
            { 
                if (this.Created.CompareTo(DateTime.Now.AddYears(1)) < 1) 
                {
                    this.Created = value;
                }
            } 
        }

        public string? Name { get; set; }

        [Required]
        public ClaimType Type { get; set; } = ClaimType.Grounding;

        [Required, Range(1, 100000)]
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
