using System.ComponentModel.DataAnnotations;

namespace GerenciadorOrdensServico.Validations
{
    public class IdValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is null || (int)value <= 0)
            {
                return ValidationResult.Success;
            }
            return ValidationResult.Success;
        }
    }
}
