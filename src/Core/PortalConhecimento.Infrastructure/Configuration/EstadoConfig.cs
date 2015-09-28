using PortalConhecimento.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace PortalConhecimento.Infrastructure.Configuration
{
    public class EstadoConfig : EntityTypeConfiguration<Estado>
    {
        public EstadoConfig()
        {
            this.ToTable("Estados");
            this.Property(e => e.Nome)
                .IsRequired()
                .HasMaxLength(50);

            this.HasMany<Cidade>(e => e.Cidades)
                .WithRequired(c => c.Estado)
                .HasForeignKey(c => c.EstadoId);
        }
    }
}