using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using PortalConhecimento.Security.Managers;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PortalConhecimento.Security.Entities
{
    public class AppUser : IdentityUser<int, AppUserLogin, AppUserRole, AppClaim>
    {
        [StringLength(200)]
        public string FullName { get; set; }

        [StringLength(20)]
        public string TaxId { get; set; }

        public bool Enabled { get; set; }

        public Task<ClaimsIdentity> GenerateUserIdentityAsync(AppUserManager manager)
        {
            return Task.FromResult(GenerateUserIdentity(manager));
        }

        public ClaimsIdentity GenerateUserIdentity(AppUserManager manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = manager.CreateIdentity(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            var id = userIdentity.GetUserId<int>();
            var user = manager.FindById(id);
            userIdentity.AddClaim(new Claim("User.FullName", user.FullName));
            return userIdentity;
        }
    }
}