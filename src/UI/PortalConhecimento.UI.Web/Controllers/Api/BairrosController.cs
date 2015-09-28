using PortalConhecimento.Domain.Interfaces.Repositories;
using PortalConhecimento.UI.Web.ViewModels;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PortalConhecimento.UI.Web.Controllers.Api
{
    [RoutePrefix("api/bairros")]
    public class BairrosController : ApiController
    {
        private readonly IBairroRepository _bairroRepository;
        public BairrosController(IBairroRepository bairroRepository)
        {
            _bairroRepository = bairroRepository;
        }

        [HttpGet]
        [Route("listarporcidade/{cidadeId}")]
        public HttpResponseMessage ListarPorCidade(int cidadeId)
        {
            var bairros = _bairroRepository.ListarPorCidade(cidadeId)
                .Select(b => new BairroViewModel
                {
                    Id = b.Id,
                    Nome = b.Nome
                }).ToList();

            return Request.CreateResponse(HttpStatusCode.OK, bairros);
        }
    }
}