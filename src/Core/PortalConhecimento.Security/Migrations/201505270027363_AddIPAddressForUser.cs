namespace PortalConhecimento.Security.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIPAddressForUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "IPAddress", c => c.String(maxLength: 8000, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "IPAddress");
        }
    }
}
