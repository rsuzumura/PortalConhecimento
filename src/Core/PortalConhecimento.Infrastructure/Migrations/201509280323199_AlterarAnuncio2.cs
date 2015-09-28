namespace PortalConhecimento.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterarAnuncio2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Anuncios", "DiasUteis", c => c.Boolean(nullable: false));
            AddColumn("dbo.Anuncios", "HoraInicialDiaUtil", c => c.Time(precision: 7));
            AddColumn("dbo.Anuncios", "HoraFinalDiaUtil", c => c.Time(precision: 7));
            AddColumn("dbo.Anuncios", "FimDeSemanaEFeriado", c => c.Boolean(nullable: false));
            AddColumn("dbo.Anuncios", "HoraInicialFimDeSemanaEFeriado", c => c.Time(precision: 7));
            AddColumn("dbo.Anuncios", "HoraFinalDeSemanaEFeriado", c => c.Time(precision: 7));
            AddColumn("dbo.Anuncios", "ACombinar", c => c.Boolean(nullable: false));
            AddColumn("dbo.Anuncios", "TipoCusto", c => c.Byte(nullable: false));
            AddColumn("dbo.Anuncios", "Valor", c => c.Decimal(precision: 18, scale: 2));
            DropColumn("dbo.Anuncios", "HoraInicial");
            DropColumn("dbo.Anuncios", "HoraFinal");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Anuncios", "HoraFinal", c => c.Time(precision: 7));
            AddColumn("dbo.Anuncios", "HoraInicial", c => c.Time(precision: 7));
            DropColumn("dbo.Anuncios", "Valor");
            DropColumn("dbo.Anuncios", "TipoCusto");
            DropColumn("dbo.Anuncios", "ACombinar");
            DropColumn("dbo.Anuncios", "HoraFinalDeSemanaEFeriado");
            DropColumn("dbo.Anuncios", "HoraInicialFimDeSemanaEFeriado");
            DropColumn("dbo.Anuncios", "FimDeSemanaEFeriado");
            DropColumn("dbo.Anuncios", "HoraFinalDiaUtil");
            DropColumn("dbo.Anuncios", "HoraInicialDiaUtil");
            DropColumn("dbo.Anuncios", "DiasUteis");
        }
    }
}
