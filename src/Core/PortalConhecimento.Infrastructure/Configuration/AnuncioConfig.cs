using PortalConhecimento.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace PortalConhecimento.Infrastructure.Configuration
{
    public class AnuncioConfig : EntityTypeConfiguration<Anuncio>
    {
        public AnuncioConfig()
        {
            this.ToTable("Anuncios");
            this.Property(p => p.Titulo)
                .HasMaxLength(300)
                .IsRequired();
            this.Property(p => p.Descricao)
                .HasMaxLength(4000)
                .IsRequired();
            this.Property(p => p.Observacoes)
                .HasMaxLength(4000);
            this.Property(p => p.Nota).HasMaxLength(300);
            this.Property(p => p.Experiencia).HasMaxLength(8000);
            this.Property(p => p.EstadoId).IsOptional();
            this.Property(p => p.CidadeId).IsOptional();
            this.HasOptional<Estado>(p => p.Estado)
                .WithMany()
                .HasForeignKey(p => p.EstadoId);

            this.HasOptional<Cidade>(p => p.Cidade)
                .WithMany()
                .HasForeignKey(p => p.CidadeId);
        }
    }
}