using PortalConhecimento.Domain.Entities;
using PortalConhecimento.Domain.Interfaces.Repositories;

namespace PortalConhecimento.Infrastructure.Repositories
{
    public class ContatoRepository : BaseRepository<Contato, int>, IContatoRepository
    {
    }
}