using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using PortalConhecimento.Security.Contexts;
using PortalConhecimento.Security.Entities;
using PortalConhecimento.Security.Services;
using PortalConhecimento.Security.Stores;
using System;

namespace PortalConhecimento.Security.Managers
{
    public class AppUserManager : UserManager<AppUser, int>
    {
        public AppUserManager(IUserStore<AppUser, int> store)
            : base(store)
        {
        }

        public static AppUserManager Create(
            IdentityFactoryOptions<AppUserManager> options, IOwinContext context)
        {
            var manager = new AppUserManager(
                new AppUserStore(context.Get<SecurityContext>()));
            // Configure validation logic for usernames 
            manager.UserValidator = new UserValidator<AppUser, int>(manager)
            {
                AllowOnlyAlphanumericUserNames = false,
                RequireUniqueEmail = true
            };
            // Configure validation logic for passwords 
            manager.PasswordValidator = new PasswordValidator
            {
                RequiredLength = 6,
                RequireNonLetterOrDigit = false,
                RequireDigit = false,
                RequireLowercase = false,
                RequireUppercase = false,
            };
            manager.MaxFailedAccessAttemptsBeforeLockout = 6;
            manager.DefaultAccountLockoutTimeSpan = TimeSpan.FromMinutes(5);
            manager.UserLockoutEnabledByDefault = true;
            // Register two factor authentication providers. This application uses Phone 
            // and Emails as a step of receiving a code for verifying the user 
            // You can write your own provider and plug in here. 
            //manager.RegisterTwoFactorProvider("PhoneCode",
            //    new PhoneNumberTokenProvider<ApplicationUser, Guid>
            //    {
            //        MessageFormat = "Your security code is: {0}"
            //    });
            manager.RegisterTwoFactorProvider("EmailCode",
                new EmailTokenProvider<AppUser, int>
                {
                    Subject = "Código de Segurança",
                    BodyFormat = "Seu código de segurança é: {0}"
                });
            manager.EmailService = new EmailService();
            //manager.SmsService = new SmsService();
            var dataProtectionProvider = options.DataProtectionProvider;
            if (dataProtectionProvider != null)
            {
                manager.UserTokenProvider =
                    new DataProtectorTokenProvider<AppUser, int>(
                        dataProtectionProvider.Create("Portal do Conhecimento ASP.NET Identity"));
            }
            return manager;
        } 
    }
}