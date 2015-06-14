using Microsoft.Practices.Unity;
using PortalConhecimento.Domain.Interfaces.Repositories;
using PortalConhecimento.Infrastructure.Repositories;
using PortalConhecimento.UI.Web.Controllers;
using System.Web.Http;
using System.Web.Mvc;

namespace PortalConhecimento.UI.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IContatoRepository, ContatoRepository>();
            container.RegisterType<IAnuncioRepository, AnuncioRepository>();
            container.RegisterType<AccountController>(new InjectionConstructor());

            DependencyResolver.SetResolver(new Unity.Mvc5.UnityDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);
        }
    }
}