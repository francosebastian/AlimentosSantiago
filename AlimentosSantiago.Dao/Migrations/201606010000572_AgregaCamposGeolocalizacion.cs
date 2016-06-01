namespace AlimentosSantiago.Dao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregaCamposGeolocalizacion : DbMigration
    {
        public override void Up()
        {
            AddColumn("ALIMENTOSSANTIAGO.DireccionUsuarios", "Nombre", c => c.String(nullable: false, maxLength: 100));
            AddColumn("ALIMENTOSSANTIAGO.DireccionUsuarios", "Latitud", c => c.String(maxLength: 100));
            AddColumn("ALIMENTOSSANTIAGO.DireccionUsuarios", "Longitud", c => c.String(maxLength: 100));
            AlterColumn("ALIMENTOSSANTIAGO.DireccionUsuarios", "Direccion", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("ALIMENTOSSANTIAGO.DireccionUsuarios", "Direccion", c => c.String(nullable: false, maxLength: 100));
            DropColumn("ALIMENTOSSANTIAGO.DireccionUsuarios", "Longitud");
            DropColumn("ALIMENTOSSANTIAGO.DireccionUsuarios", "Latitud");
            DropColumn("ALIMENTOSSANTIAGO.DireccionUsuarios", "Nombre");
        }
    }
}
