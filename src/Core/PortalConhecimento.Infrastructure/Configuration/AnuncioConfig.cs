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
            this.Property(p => p.Nota).HasMaxLength(300);
            this.HasMany(a => a.Experiencias)
                .WithMany()
                .Map(a =>
                {
                    a.MapLeftKey("AnuncioId");
                    a.MapRightKey("ExperienciaId");
                    a.ToTable("AnunciosExperiencias");
                });
        }
    }
}
