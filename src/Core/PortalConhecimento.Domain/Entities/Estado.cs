using System.Collections.Generic;

namespace PortalConhecimento.Domain.Entities
{
    public class Estado
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Cidade> Cidades { get; set; }
    }
}