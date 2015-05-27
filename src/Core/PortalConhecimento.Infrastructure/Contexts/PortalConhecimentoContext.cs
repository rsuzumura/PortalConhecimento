using PortalConhecimento.Domain.Entities;
using PortalConhecimento.Infrastructure.Configuration;
using System.Data.Entity;

namespace PortalConhecimento.Infrastructure.Contexts
{
    public class PortalConhecimentoContext : DbContext
    {
        public PortalConhecimentoContext()
            : base("PortalConnection")
        {
        }

        public DbSet<Contato> Contatos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar").HasMaxLength(200));
            modelBuilder.Configurations.Add<Contato>(new ContatoConfig());
        }
    }
}