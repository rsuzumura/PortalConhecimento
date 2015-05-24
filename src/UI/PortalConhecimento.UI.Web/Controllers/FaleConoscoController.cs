using AutoMapper;
using PortalConhecimento.Domain.Entities;
using PortalConhecimento.Domain.Interfaces.Repositories;
using PortalConhecimento.UI.Web.ViewModels;
using Recaptcha.Web;
using Recaptcha.Web.Mvc;
using System.Web.Mvc;

namespace PortalConhecimento.UI.Web.Controllers
{
    public class FaleConoscoController : Controller
    {
        private IContatoRepository _contatoRepository;
        public FaleConoscoController(IContatoRepository contatoRepository)
        {
            _contatoRepository = contatoRepository;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(ContatoViewModel model)
        {
            var recaptchaHelper = this.GetRecaptchaVerificationHelper();
            if (string.IsNullOrEmpty(recaptchaHelper.Response))
            {
                ModelState.AddModelError("", "O captcha é obrigatório.");
                return View(model);
            }

            var recaptchaResult = recaptchaHelper.VerifyRecaptchaResponse();
            if (recaptchaResult != RecaptchaVerificationResult.Success)
            {
                ModelState.AddModelError("", "Captcha incorreto.");
                return View(model);
            }

            if (ModelState.IsValid)
            {
                var entity = Mapper.Map<Contato>(model);
                _contatoRepository.Add(entity);
                TempData.Add("Message", "Seu contato foi recebido com sucesso! Em breve estaremos respondendo a sua dúvida!");
                return RedirectToAction("Index", "Home", null);
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _contatoRepository.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}