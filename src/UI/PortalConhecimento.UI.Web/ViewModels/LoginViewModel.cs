using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PortalConhecimento.UI.Web.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name="Usuário")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Senha")]
        public string Password { get; set; }
    }
}