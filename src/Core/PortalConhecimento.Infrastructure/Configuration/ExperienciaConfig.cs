using PortalConhecimento.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace PortalConhecimento.Infrastructure.Configuration
{
    public class ExperienciaConfig : EntityTypeConfiguration<Experiencia>
    {
        public ExperienciaConfig()
        {
            this.ToTable("Experiencias");
            this.HasRequired(e => e.Usuario).WithMany(u => u.Experiencias).HasForeignKey(e => e.IdUsuario);
            this.Property(p => p.Titulo).IsRequired().HasMaxLength(100);
            this.Property(p => p.Detalhes).IsRequired().HasMaxLength(4000);
        }
    }
}