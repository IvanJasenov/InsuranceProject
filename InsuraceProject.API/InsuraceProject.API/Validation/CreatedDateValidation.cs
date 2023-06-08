using System.ComponentModel.DataAnnotations;

namespace InsuraceProject.API.Validation
{
    public class CreatedDateValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            IFromToDateModel model = validationContext.ObjectInstance as IFromToDateModel;
            var now = new DateOnly().Day;
            if (model == null)
                throw new ArgumentException("Created prop is required");

            //if (model.Created.CompareTo(DateOnly.FromDateTime()))
            //    return new ValidationResult("Created date must be earlier than current time");
            
            return ValidationResult.Success;
        }
    }
}
