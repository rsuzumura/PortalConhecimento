namespace PortalConhecimento.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IncludeAnuncioTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Anuncios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Titulo = c.String(nullable: false, maxLength: 300, unicode: false),
                        Descricao = c.String(nullable: false, maxLength: 4000, unicode: false),
                        Ativo = c.Boolean(nullable: false),
                        Nota = c.String(maxLength: 300, unicode: false),
                        DataCadastro = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                        IdUsuario = c.Int(nullable: false),
                        Aprovado = c.Boolean(nullable: false),
                        TipoAnuncio = c.Byte(nullable: false),
                        StatusAnuncio = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Palavra = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TagAnuncios",
                c => new
                    {
                        Tag_Id = c.Int(nullable: false),
                        Anuncio_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Tag_Id, t.Anuncio_Id })
                .ForeignKey("dbo.Tags", t => t.Tag_Id, cascadeDelete: true)
                .ForeignKey("dbo.Anuncios", t => t.Anuncio_Id, cascadeDelete: true)
                .Index(t => t.Tag_Id)
                .Index(t => t.Anuncio_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TagAnuncios", "Anuncio_Id", "dbo.Anuncios");
            DropForeignKey("dbo.TagAnuncios", "Tag_Id", "dbo.Tags");
            DropIndex("dbo.TagAnuncios", new[] { "Anuncio_Id" });
            DropIndex("dbo.TagAnuncios", new[] { "Tag_Id" });
            DropTable("dbo.TagAnuncios");
            DropTable("dbo.Tags");
            DropTable("dbo.Anuncios");
        }
    }
}
