using Microsoft.AspNet.Identity.EntityFramework;
using PortalConhecimento.Security.Entities;

namespace PortalConhecimento.Security.Contexts
{
    public class SecurityContext : IdentityDbContext<AppUser, AppRole, int, AppUserLogin, AppUserRole, AppClaim>
    {
        public SecurityContext()
            : base("PortalConnection")
        {
        }

        public static SecurityContext Create()
        {
            return new SecurityContext();
        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Entity<AppUser>()
                .ToTable("Users")
                .Property(p => p.PhoneNumber).HasMaxLength(50);
            modelBuilder.Entity<AppRole>().ToTable("Roles");
            modelBuilder.Entity<AppUserRole>().ToTable("UsersRoles");
            modelBuilder.Entity<AppClaim>().ToTable("UsersClaims");
            modelBuilder.Entity<AppUserLogin>().ToTable("UsersLogins");
        }
    }
}