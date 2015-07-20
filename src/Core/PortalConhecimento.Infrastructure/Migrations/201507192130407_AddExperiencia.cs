namespace PortalConhecimento.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddExperiencia : DbMigration
    {
        public override void Up()
        {
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
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.IdUsuario, cascadeDelete: true)
                .Index(t => t.IdUsuario);
            
            CreateTable(
                "dbo.AnunciosExperiencias",
                c => new
                    {
                        AnuncioId = c.Int(nullable: false),
                        ExperienciaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.AnuncioId, t.ExperienciaId })
                .ForeignKey("dbo.Anuncios", t => t.AnuncioId, cascadeDelete: true)
                .ForeignKey("dbo.Experiencias", t => t.ExperienciaId, cascadeDelete: true)
                .Index(t => t.AnuncioId)
                .Index(t => t.ExperienciaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AnunciosExperiencias", "ExperienciaId", "dbo.Experiencias");
            DropForeignKey("dbo.AnunciosExperiencias", "AnuncioId", "dbo.Anuncios");
            DropForeignKey("dbo.Experiencias", "IdUsuario", "dbo.Users");
            DropIndex("dbo.AnunciosExperiencias", new[] { "ExperienciaId" });
            DropIndex("dbo.AnunciosExperiencias", new[] { "AnuncioId" });
            DropIndex("dbo.Experiencias", new[] { "IdUsuario" });
            DropTable("dbo.AnunciosExperiencias");
            DropTable("dbo.Experiencias");
        }
    }
}
