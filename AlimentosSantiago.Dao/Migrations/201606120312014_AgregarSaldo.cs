namespace AlimentosSantiago.Dao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregarSaldo : DbMigration
    {
        public override void Up()
        {
            AddColumn("ALIMENTOSSANTIAGO.Usuarios", "Saldo", c => c.Decimal(precision: 10, scale: 0));
            AddColumn("ALIMENTOSSANTIAGO.LogSaldoes", "SaldoCargado", c => c.Decimal(nullable: false, precision: 10, scale: 0));
        }
        
        public override void Down()
        {
            DropColumn("ALIMENTOSSANTIAGO.LogSaldoes", "SaldoCargado");
            DropColumn("ALIMENTOSSANTIAGO.Usuarios", "Saldo");
        }
    }
}
