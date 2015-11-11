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

        [StringLength(4000)]
        public string Observacoes { get; set; }

        [StringLength(8000)]
        public string Experiencia { get; set; }

        public bool DiasUteis { get; set; }

        public int[] DiaUtil { get; set; }

        public bool FinsDeSemanaEFeriados { get; set; }

        public int[] FimDeSemanaFeriado { get; set; }


        public bool ACombinar { get; set; }

        public int? EstadoId { get; set; }

        public int? CidadeId { get; set; }

        public int[] BairroIds { get; set; }

        public byte TipoCusto { get; set; }

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