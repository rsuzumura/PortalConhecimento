using PortalConhecimento.Domain.Entities;
using PortalConhecimento.Domain.Interfaces.Repositories;
using System.Linq;

namespace PortalConhecimento.Infrastructure.Repositories
{
    public class CidadeRepository : BaseRepository<Cidade, int>, ICidadeRepository
    {
        public IQueryable<Cidade> ListarPorEstado(int estadoId)
        {
            return this.List().Where(c => c.EstadoId == estadoId);
        }
    }
}