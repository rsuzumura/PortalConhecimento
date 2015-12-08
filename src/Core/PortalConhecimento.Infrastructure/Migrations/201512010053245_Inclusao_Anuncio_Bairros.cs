namespace PortalConhecimento.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inclusao_Anuncio_Bairros : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Anuncios", "BairroId", "dbo.Bairros");
            DropIndex("dbo.Anuncios", new[] { "BairroId" });
            CreateTable(
                "dbo.BairroAnuncios",
                c => new
                    {
                        Bairro_Id = c.Int(nullable: false),
                        Anuncio_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Bairro_Id, t.Anuncio_Id })
                .ForeignKey("dbo.Bairros", t => t.Bairro_Id, cascadeDelete: true)
                .ForeignKey("dbo.Anuncios", t => t.Anuncio_Id, cascadeDelete: true)
                .Index(t => t.Bairro_Id)
                .Index(t => t.Anuncio_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BairroAnuncios", "Anuncio_Id", "dbo.Anuncios");
            DropForeignKey("dbo.BairroAnuncios", "Bairro_Id", "dbo.Bairros");
            DropIndex("dbo.BairroAnuncios", new[] { "Anuncio_Id" });
            DropIndex("dbo.BairroAnuncios", new[] { "Bairro_Id" });
            DropTable("dbo.BairroAnuncios");
            CreateIndex("dbo.Anuncios", "BairroId");
            AddForeignKey("dbo.Anuncios", "BairroId", "dbo.Bairros", "Id");
        }
    }
}
