using PortalConhecimento.Domain.Entities;
using PortalConhecimento.Domain.Interfaces.Repositories;

namespace PortalConhecimento.Infrastructure.Repositories
{
    public class EstadoRepository : BaseRepository<Estado, int>, IEstadoRepository
    {
    }
}