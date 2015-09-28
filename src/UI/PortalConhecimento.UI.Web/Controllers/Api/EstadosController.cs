using PortalConhecimento.Domain.Interfaces.Repositories;
using PortalConhecimento.UI.Web.ViewModels;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PortalConhecimento.UI.Web.Controllers.Api
{
    public class EstadosController : ApiController
    {
        private readonly IEstadoRepository _estadoRepository;
        public EstadosController(IEstadoRepository estadoRepository)
        {
            _estadoRepository = estadoRepository;
        }

        public HttpResponseMessage Get()
        {
            var estados = _estadoRepository.List()
                .Select(e => new EstadoViewModel
                {
                    Id = e.Id,
                    Nome = e.Nome
                }).ToList();

            return Request.CreateResponse(HttpStatusCode.OK, estados);
        }
    }
}