using PortalConhecimento.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace PortalConhecimento.Infrastructure.Configuration
{
    public class CidadeConfig : EntityTypeConfiguration<Cidade>
    {
        public CidadeConfig()
        {
            this.ToTable("Cidades");
            this.Property(e => e.Nome)
                .IsRequired()
                .HasMaxLength(100);

            this.HasMany<Bairro>(c => c.Bairros)
                .WithRequired(b => b.Cidade)
                .HasForeignKey(b => b.CidadeId);
        }
    }
}
