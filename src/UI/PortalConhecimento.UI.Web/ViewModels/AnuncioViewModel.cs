using PortalConhecimento.Domain.Entities;
using PortalConhecimento.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PortalConhecimento.UI.Web.ViewModels
{
    public class AnuncioViewModel
    {
        public int Id { get; set; }

        [StringLength(300)]
        [Required]
        public string Titulo { get; set; }

        [StringLength(4000)]
        [Required]
        public string Descricao { get; set; }

        public bool Ativo { get; set; }

        [Required]
        public TipoAnuncio TipoAnuncio { get; set; }

        public List<TagViewModel> Tags { get; set; }
    }

    public class TagViewModel
    {
        public int Id { get; set; }
        public string Palavra { get; set; }
    }
}