using System.ComponentModel.DataAnnotations;

namespace PortalConhecimento.UI.Web.ViewModels
{
    public class ContatoViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(80)]
        public string Nome { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "O formato do e-mail está inválido.")]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string Assunto { get; set; }

        [Required]
        [StringLength(800)]
        public string Mensagem { get; set; }
    }
}