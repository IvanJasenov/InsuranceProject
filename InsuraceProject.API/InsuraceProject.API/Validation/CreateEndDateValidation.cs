using System.ComponentModel.DataAnnotations;

namespace InsuraceProject.API.Validation
{
    public class CreateEndDateValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            IEndDateValidation model = validationContext.ObjectInstance as IEndDateValidation;
            if (model == null)
                throw new ArgumentException("EndDate prop is required");


            return ValidationResult.Success;
        }
    }
};

