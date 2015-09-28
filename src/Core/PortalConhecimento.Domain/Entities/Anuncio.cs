using PortalConhecimento.Domain.Enums;
using System;
using System.Collections.Generic;

namespace PortalConhecimento.Domain.Entities
{
    public class Anuncio
    {
        public Anuncio()
        {
            this.StatusAnuncio = Enums.StatusAnuncio.EmAprovacao;
            this.Tags = new HashSet<Tag>();
        }

        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Observacoes { get; set; }
        public bool Ativo { get; set; }
        public string Nota { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public int IdUsuario { get; set; }
        public bool Aprovado { get; set; }
        public TimeSpan? HoraInicial { get; set; }
        public TimeSpan? HoraFinal { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public decimal? Preco { get; set; }
        public string Experiencia { get; set; }
        public TipoAnuncio TipoAnuncio { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
        public virtual Usuario Usuario { get; set; }
        public StatusAnuncio StatusAnuncio { get; set; }
    }
}