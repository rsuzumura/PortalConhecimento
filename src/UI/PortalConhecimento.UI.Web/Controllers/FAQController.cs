using PortalConhecimento.UI.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortalConhecimento.UI.Web.Controllers
{
    public class FAQController : Controller
    {
        // GET: FAQ
        public ActionResult Index()
        {
            var model = FAQViewModel.ListarAtivos();
            return View(model);
        }
    }
}