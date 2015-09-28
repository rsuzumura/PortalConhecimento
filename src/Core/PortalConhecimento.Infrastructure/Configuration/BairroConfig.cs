using PortalConhecimento.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace PortalConhecimento.Infrastructure.Configuration
{
    public class BairroConfig : EntityTypeConfiguration<Bairro>
    {
        public BairroConfig()
        {
            this.ToTable("Bairros");
            this.Property(e => e.Nome)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}