using AutoMapper;
using Microsoft.AspNet.Identity;
using PortalConhecimento.Domain.Entities;
using PortalConhecimento.Domain.Interfaces.Repositories;
using PortalConhecimento.UI.Web.Filters;
using PortalConhecimento.UI.Web.ViewModels;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PortalConhecimento.UI.Web.Controllers.Api
{
    [Authorize]
    public class AnunciosController : ApiController
    {
        private IAnuncioRepository _anuncioRepository;
        public AnunciosController(IAnuncioRepository anuncioRepository)
        {
            _anuncioRepository = anuncioRepository;
        }

        [HttpGet]
        [Route("api/Anuncios/ListarPalavras")]
        public HttpResponseMessage ListarPalavras(string palavraInicial)
        {
            var result = _anuncioRepository.ListarPalavrasComInicial(palavraInicial, 10);

            return Request.CreateResponse(HttpStatusCode.OK, result.Select(t => new
            {
                t.Id,
                t.Palavra
            }));
        }

        [ValidateModelState]
        public HttpResponseMessage Post(AnuncioViewModel model)
        {
            var anuncio = Mapper.Map<Anuncio>(model);
            anuncio.DataCadastro = anuncio.DataAlteracao = DateTime.Now;

            foreach (var tag in model.Tags)
            {
                var dbTag = _anuncioRepository.BuscarTagPorPalavra(tag.Palavra);
                if (dbTag != null)
                    anuncio.Tags.Add(dbTag);
                else
                    anuncio.Tags.Add(new Tag
                    {
                        Palavra = tag.Palavra
                    });
            }

            anuncio.IdUsuario = User.Identity.GetUserId<int>();
            _anuncioRepository.Add(anuncio);

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                _anuncioRepository.Dispose();
            base.Dispose(disposing);
        }
    }
}
