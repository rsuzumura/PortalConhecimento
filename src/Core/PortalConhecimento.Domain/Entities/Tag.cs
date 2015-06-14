using System.Collections.Generic;

namespace PortalConhecimento.Domain.Entities
{
    public class Tag
    {
        public int Id { get; set; }
        public string Palavra { get; set; }
        public virtual ICollection<Anuncio> Anuncios { get; set; }
    }
}