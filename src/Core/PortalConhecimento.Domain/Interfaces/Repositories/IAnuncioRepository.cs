using PortalConhecimento.Domain.Entities;
using System.Collections.Generic;

namespace PortalConhecimento.Domain.Interfaces.Repositories
{
    public interface IAnuncioRepository : IBaseRepository<Anuncio, int>
    {
        IEnumerable<Anuncio> ListarPorUsuario(int idUsuario);

        IEnumerable<Tag> ListarPalavrasComInicial(string inicioPalavra, int quantidade);

        Tag BuscarTagPorPalavra(string palavra);
    }
}