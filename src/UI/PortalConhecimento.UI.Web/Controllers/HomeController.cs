using System.Web.Mvc;

namespace PortalConhecimento.UI.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(bool? cadastroOk)
        {
            if (cadastroOk == true)
            {
                ViewBag.CadastroOk = true;
            }
            return View();
        }
    }
}