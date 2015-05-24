using System.ComponentModel.DataAnnotations;

namespace PortalConhecimento.ComponentModel.DataAnnotations
{
    public class CpfAttribute : ValidationAttribute
    {
        public CpfAttribute() : base("O campo {0} não é válido.")
        {
        }

        public override string FormatErrorMessage(string name)
        {
            return string.Format(ErrorMessageString, name);
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                if (IsValidCpf(value as string))
                    return new ValidationResult(FormatErrorMessage(validationContext.DisplayName));
            }
            return ValidationResult.Success;
        }

        private bool IsValidCpf(string cpf)
        {
            return false;
        }
    }
}
