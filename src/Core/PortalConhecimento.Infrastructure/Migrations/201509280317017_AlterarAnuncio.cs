namespace PortalConhecimento.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterarAnuncio : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Anuncios", "EstadoId", c => c.Int());
            AddColumn("dbo.Anuncios", "CidadeId", c => c.Int());
            AddColumn("dbo.Anuncios", "BairroId", c => c.Int());
            CreateIndex("dbo.Anuncios", "EstadoId");
            CreateIndex("dbo.Anuncios", "CidadeId");
            CreateIndex("dbo.Anuncios", "BairroId");
            AddForeignKey("dbo.Anuncios", "BairroId", "dbo.Bairros", "Id");
            AddForeignKey("dbo.Anuncios", "CidadeId", "dbo.Cidades", "Id");
            AddForeignKey("dbo.Anuncios", "EstadoId", "dbo.Estados", "Id");
            DropColumn("dbo.Anuncios", "Estado");
            DropColumn("dbo.Anuncios", "Cidade");
            DropColumn("dbo.Anuncios", "Bairro");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Anuncios", "Bairro", c => c.String(maxLength: 200, unicode: false));
            AddColumn("dbo.Anuncios", "Cidade", c => c.String(maxLength: 200, unicode: false));
            AddColumn("dbo.Anuncios", "Estado", c => c.String(maxLength: 200, unicode: false));
            DropForeignKey("dbo.Anuncios", "EstadoId", "dbo.Estados");
            DropForeignKey("dbo.Anuncios", "CidadeId", "dbo.Cidades");
            DropForeignKey("dbo.Anuncios", "BairroId", "dbo.Bairros");
            DropIndex("dbo.Anuncios", new[] { "BairroId" });
            DropIndex("dbo.Anuncios", new[] { "CidadeId" });
            DropIndex("dbo.Anuncios", new[] { "EstadoId" });
            DropColumn("dbo.Anuncios", "BairroId");
            DropColumn("dbo.Anuncios", "CidadeId");
            DropColumn("dbo.Anuncios", "EstadoId");
        }
    }
}
