using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PortalConhecimento.UI.Web.Startup))]
namespace PortalConhecimento.UI.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
