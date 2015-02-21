using System.ComponentModel.DataAnnotations;

namespace PortalConhecimento.UI.Web.ViewModels
{
    public class RegisterUserViewModel
    {
        [Required]
        [Display(Name = "Nome de Usuário")]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Nome Completo")]
        public string FullName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "A {0} deve ter pelo menos {2} caracteres.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmação de Senha")]
        [Compare("Password", ErrorMessage = "A senha e a confirmação não batem.")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "CPF")]
        public string TaxId { get; set; }

        [Display(Name = "Celular")]
        public string MobilePhone { get; set; }
    }
}