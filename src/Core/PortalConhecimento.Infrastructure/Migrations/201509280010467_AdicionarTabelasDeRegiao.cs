namespace PortalConhecimento.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionarTabelasDeRegiao : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Experiencias", "IdUsuario", "dbo.Users");
            DropForeignKey("dbo.AnunciosExperiencias", "AnuncioId", "dbo.Anuncios");
            DropForeignKey("dbo.AnunciosExperiencias", "ExperienciaId", "dbo.Experiencias");
            DropIndex("dbo.Experiencias", new[] { "IdUsuario" });
            DropIndex("dbo.AnunciosExperiencias", new[] { "AnuncioId" });
            DropIndex("dbo.AnunciosExperiencias", new[] { "ExperienciaId" });
            CreateTable(
                "dbo.Bairros",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100, unicode: false),
                        CidadeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cidades", t => t.CidadeId, cascadeDelete: true)
                .Index(t => t.CidadeId);
            
            CreateTable(
                "dbo.Cidades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100, unicode: false),
                        EstadoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Estados", t => t.EstadoId, cascadeDelete: true)
                .Index(t => t.EstadoId);
            
            CreateTable(
                "dbo.Estados",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Anuncios", "Observacoes", c => c.String(maxLength: 4000, unicode: false));
            AddColumn("dbo.Anuncios", "Estado", c => c.String(maxLength: 200, unicode: false));
            AddColumn("dbo.Anuncios", "Cidade", c => c.String(maxLength: 200, unicode: false));
            AddColumn("dbo.Anuncios", "Bairro", c => c.String(maxLength: 200, unicode: false));
            AddColumn("dbo.Anuncios", "Experiencia", c => c.String(maxLength: 8000, unicode: false));
            CreateIndex("dbo.Anuncios", "IdUsuario");
            AddForeignKey("dbo.Anuncios", "IdUsuario", "dbo.Users", "Id", cascadeDelete: true);
            DropColumn("dbo.Anuncios", "Regiao");
            DropTable("dbo.Experiencias");
            DropTable("dbo.AnunciosExperiencias");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.AnunciosExperiencias",
                c => new
                    {
                        AnuncioId = c.Int(nullable: false),
                        ExperienciaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.AnuncioId, t.ExperienciaId });
            
            CreateTable(
                "dbo.Experiencias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdUsuario = c.Int(nullable: false),
                        Titulo = c.String(nullable: false, maxLength: 100, unicode: false),
                        Detalhes = c.String(nullable: false, maxLength: 4000, unicode: false),
                        DataInicial = c.DateTime(),
                        DataFinal = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Anuncios", "Regiao", c => c.String(maxLength: 200, unicode: false));
            DropForeignKey("dbo.Cidades", "EstadoId", "dbo.Estados");
            DropForeignKey("dbo.Bairros", "CidadeId", "dbo.Cidades");
            DropForeignKey("dbo.Anuncios", "IdUsuario", "dbo.Users");
            DropIndex("dbo.Cidades", new[] { "EstadoId" });
            DropIndex("dbo.Bairros", new[] { "CidadeId" });
            DropIndex("dbo.Anuncios", new[] { "IdUsuario" });
            DropColumn("dbo.Anuncios", "Experiencia");
            DropColumn("dbo.Anuncios", "Bairro");
            DropColumn("dbo.Anuncios", "Cidade");
            DropColumn("dbo.Anuncios", "Estado");
            DropColumn("dbo.Anuncios", "Observacoes");
            DropTable("dbo.Estados");
            DropTable("dbo.Cidades");
            DropTable("dbo.Bairros");
            CreateIndex("dbo.AnunciosExperiencias", "ExperienciaId");
            CreateIndex("dbo.AnunciosExperiencias", "AnuncioId");
            CreateIndex("dbo.Experiencias", "IdUsuario");
            AddForeignKey("dbo.AnunciosExperiencias", "ExperienciaId", "dbo.Experiencias", "Id", cascadeDelete: true);
            AddForeignKey("dbo.AnunciosExperiencias", "AnuncioId", "dbo.Anuncios", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Experiencias", "IdUsuario", "dbo.Users", "Id", cascadeDelete: true);
        }
    }
}
