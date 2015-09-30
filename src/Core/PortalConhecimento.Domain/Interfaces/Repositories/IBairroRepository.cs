using PortalConhecimento.Domain.Entities;
using System.Linq;

namespace PortalConhecimento.Domain.Interfaces.Repositories
{
    public interface IBairroRepository : IBaseRepository<Bairro, int>
    {
        IQueryable<Bairro> ListarPorCidade(int cidadeId);
    }
}