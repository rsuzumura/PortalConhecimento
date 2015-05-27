using PortalConhecimento.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace PortalConhecimento.Infrastructure.Configuration
{
    public class ContatoConfig : EntityTypeConfiguration<Contato>
    {
        public ContatoConfig()
        {
            this.ToTable("Contatos");
            this.Property(p => p.Nome).IsRequired().HasMaxLength(80);
            this.Property(p => p.Email).IsRequired().HasMaxLength(100);
            this.Property(p => p.Assunto).IsRequired().HasMaxLength(50);
            this.Property(p => p.Mensagem).IsRequired().HasMaxLength(800);
        }
    }
}