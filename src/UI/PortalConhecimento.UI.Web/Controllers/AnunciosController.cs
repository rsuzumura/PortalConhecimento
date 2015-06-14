using PortalConhecimento.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Identity;
using System.Web;
using System.Web.Mvc;

namespace PortalConhecimento.UI.Web.Controllers
{
    [Authorize]
    public class AnunciosController : Controller
    {
        private IAnuncioRepository _anuncioRepository;
        public AnunciosController(IAnuncioRepository anuncioRepository)
        {
            _anuncioRepository = anuncioRepository;
        }

        public ActionResult Index()
        {
            var idUsuario = User.Identity.GetUserId<int>();
            var anuncios = _anuncioRepository.ListarPorUsuario(idUsuario);
            return View(anuncios);
        }

        public ActionResult Create()
        {
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _anuncioRepository.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}