using Microsoft.AspNet.Identity.EntityFramework;
using PortalConhecimento.Security.Contexts;
using PortalConhecimento.Security.Entities;

namespace PortalConhecimento.Security.Stores
{
    public class AppUserStore : UserStore<AppUser, AppRole, int, AppUserLogin, AppUserRole, AppClaim>
    {
        public AppUserStore(SecurityContext context)
            : base(context)
        {
        }
    }
}