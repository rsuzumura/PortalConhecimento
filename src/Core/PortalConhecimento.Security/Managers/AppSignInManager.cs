using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using PortalConhecimento.Security.Entities;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PortalConhecimento.Security.Managers
{
    public class AppSignInManager : SignInManager<AppUser, int>
    {
        public AppSignInManager(AppUserManager userManager, IAuthenticationManager authenticationManager) :
            base(userManager, authenticationManager) { }

        public static AppSignInManager Create(IdentityFactoryOptions<AppSignInManager> options, IOwinContext context)
        {
            return new AppSignInManager(context.GetUserManager<AppUserManager>(), context.Authentication);
        }

        public async override Task<ClaimsIdentity> CreateUserIdentityAsync(AppUser user)
        {
            return await user.GenerateUserIdentityAsync((AppUserManager)UserManager);
        }

        public async override Task<SignInStatus> PasswordSignInAsync(string userName, string password, bool isPersistent, bool shouldLockout)
        {
            var user = await this.UserManager.FindByNameAsync(userName);
            if (user != null)
            {
                if (user.Enabled)
                    return await base.PasswordSignInAsync(userName, password, isPersistent, shouldLockout);
                else
                {
                    return await Task.FromResult<SignInStatus>(SignInStatus.LockedOut);
                }
            }
            else
                return await Task.FromResult<SignInStatus>(SignInStatus.Failure);
        }
    }
}