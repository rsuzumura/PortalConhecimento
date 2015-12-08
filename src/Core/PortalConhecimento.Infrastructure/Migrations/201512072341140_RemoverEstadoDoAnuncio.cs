namespace PortalConhecimento.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoverEstadoDoAnuncio : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Anuncios", "BairroId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Anuncios", "BairroId", c => c.Int());
        }
    }
}
