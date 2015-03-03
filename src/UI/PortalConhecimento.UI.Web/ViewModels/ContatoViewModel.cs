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
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Assunto { get; set; }

        [Required]
        [StringLength(800)]
        public string Mensagem { get; set; }
    }
}