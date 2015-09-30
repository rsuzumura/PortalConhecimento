using PortalConhecimento.Domain.Entities;
using PortalConhecimento.Domain.Interfaces.Repositories;
using System.Linq;

namespace PortalConhecimento.Infrastructure.Repositories
{
    public class BairroRepository : BaseRepository<Bairro, int>, IBairroRepository
    {
        public IQueryable<Bairro> ListarPorCidade(int cidadeId)
        {
            return this.List().Where(b => b.CidadeId == cidadeId);
        }
    }
}