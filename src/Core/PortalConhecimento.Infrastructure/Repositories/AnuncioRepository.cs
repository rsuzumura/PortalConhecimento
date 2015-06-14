using PortalConhecimento.Domain.Entities;
using PortalConhecimento.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace PortalConhecimento.Infrastructure.Repositories
{
    public class AnuncioRepository : BaseRepository<Anuncio, int>, IAnuncioRepository
    {
        public IEnumerable<Anuncio> ListarPorUsuario(int idUsuario)
        {
            var result = this._context.Anuncios.Where(a =>
                a.IdUsuario == idUsuario &&
                a.StatusAnuncio != Domain.Enums.StatusAnuncio.Reprovado).ToList();
            return result;
        }

        public Tag BuscarPorPalavra(string palavra)
        {
            var result = this._context.Tags
                .Where(t => t.Palavra == palavra).FirstOrDefault();

            return result;
        }

        public IEnumerable<Tag> ListarPalavrasComInicial(string inicioPalavra, int quantidade)
        {
            var result = this._context.Tags
                .Where(t => t.Palavra.StartsWith(inicioPalavra))
                .OrderBy(t => t.Palavra)
                .Take(10)
                .ToList();

            return result;
        }
    }
}
