using PortalConhecimento.Domain.Interfaces.Repositories;
using PortalConhecimento.UI.Web.ViewModels;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PortalConhecimento.UI.Web.Controllers.Api
{
    [RoutePrefix("api/cidades")]
    public class CidadesController : ApiController
    {
        private readonly ICidadeRepository _cidadeRepository;
        public CidadesController(ICidadeRepository cidadeRepository)
        {
            _cidadeRepository = cidadeRepository;
        }

        [HttpGet]
        [Route("listarporestado/{estadoId}")]
        public HttpResponseMessage ListarPorEstado(int estadoId)
        {
            var cidades = _cidadeRepository.ListarPorEstado(estadoId)
                .Select(c => new CidadeViewModel
                {
                    Id = c.Id,
                    Nome = c.Nome
                }).ToList();

            return Request.CreateResponse(HttpStatusCode.OK, cidades);
        }
    }
}