namespace PortalConhecimento.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddContatosTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contatos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 80, unicode: false),
                        Email = c.String(nullable: false, maxLength: 100, unicode: false),
                        Assunto = c.String(nullable: false, maxLength: 50, unicode: false),
                        Mensagem = c.String(nullable: false, maxLength: 800, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Contatos");
        }
    }
}
