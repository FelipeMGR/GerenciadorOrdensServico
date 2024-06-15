using System.ComponentModel.DataAnnotations;

namespace GerenciadorOrdensServico.Validations
{
    public class NameValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is null || string.IsNullOrEmpty(value.ToString()))
            {
                return ValidationResult.Success;
            }
            var name = value.ToString()[0].ToString();

            if(name !== name.ToUpper())
            {
                return new ValidationResult("A primeira letra precisa ser maiuscula!");
            }

            else
            {
                return ValidationResult.Success;
            }
        }
    }
}
