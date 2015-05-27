using Microsoft.Practices.Unity;
using PortalConhecimento.Domain.Interfaces.Repositories;
using PortalConhecimento.Infrastructure.Repositories;
using PortalConhecimento.UI.Web.Controllers;
using System.Web.Mvc;
using Unity.Mvc5;

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
            container.RegisterType<AccountController>(new InjectionConstructor());
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}