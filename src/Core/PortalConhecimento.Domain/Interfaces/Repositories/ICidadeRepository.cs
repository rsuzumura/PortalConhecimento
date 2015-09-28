using PortalConhecimento.Domain.Entities;
using System.Linq;

namespace PortalConhecimento.Domain.Interfaces.Repositories
{
    public interface ICidadeRepository : IBaseRepository<Cidade, int>
    {
        IQueryable<Cidade> ListarPorEstado(int estadoId);
    }
}