﻿using PortalConhecimento.Domain.Entities;
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
        public DbSet<Anuncio> Anuncios { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Bairro> Bairros { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar").HasMaxLength(200));
            modelBuilder.Configurations.Add<Contato>(new ContatoConfig());
            modelBuilder.Configurations.Add<Anuncio>(new AnuncioConfig());
            modelBuilder.Configurations.Add<Usuario>(new UsuarioConfig());
            modelBuilder.Configurations.Add<Estado>(new EstadoConfig());
            modelBuilder.Configurations.Add<Cidade>(new CidadeConfig());
            modelBuilder.Configurations.Add<Bairro>(new BairroConfig());
        }
    }
}