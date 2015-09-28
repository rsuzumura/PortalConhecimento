using PortalConhecimento.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace PortalConhecimento.Infrastructure.Configuration
{
    public class UsuarioConfig : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfig()
        {
            this.ToTable("Users");
            this.Property(p => p.FullName).HasMaxLength(200);
            this.Property(p => p.TaxId).HasMaxLength(20);
            this.Property(p => p.IPAddress).HasMaxLength(50);
            this.Property(p => p.Email).HasMaxLength(256);
            this.Property(p => p.PasswordHash).HasMaxLength(8000);
            this.Property(p => p.SecurityStamp).HasMaxLength(8000);
            this.Property(p => p.PhoneNumber).HasMaxLength(50);
            this.Property(p => p.UserName).IsRequired().HasMaxLength(256);
            this.HasMany<Anuncio>(u => u.Anuncios).WithRequired(a => a.Usuario).HasForeignKey(a => a.IdUsuario);
        }
    }
}