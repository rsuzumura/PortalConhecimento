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
            this.Bairros = new HashSet<Bairro>();
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
        public bool DiasUteis { get; set; }
        public TimeSpan? HoraInicialDiaUtil { get; set; }
        public TimeSpan? HoraFinalDiaUtil { get; set; }
        public bool FimDeSemanaEFeriado { get; set; }
        public TimeSpan? HoraInicialFimDeSemanaEFeriado { get; set; }
        public TimeSpan? HoraFinalDeSemanaEFeriado { get; set; }
        public bool ACombinar { get; set; }
        public byte TipoCusto { get; set; }
        public decimal? Valor { get; set; }
        public int? EstadoId { get; set; }
        public int? CidadeId { get; set; }
        public decimal? Preco { get; set; }
        public string Experiencia { get; set; }
        public TipoAnuncio TipoAnuncio { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual Cidade Cidade { get; set; }
        public virtual ICollection<Bairro> Bairros { get; set; }
        public StatusAnuncio StatusAnuncio { get; set; }
    }
}