namespace AlimentosSantiago.Dao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class actualizacionbasedatos003 : DbMigration
    {
        public override void Up()
        {
            AddColumn("ALIMENTOSSANTIAGO.Platoes", "RutaFisicaImagen", c => c.String());
            AddColumn("ALIMENTOSSANTIAGO.Platoes", "RutaVirtualImagen", c => c.String());
            DropColumn("ALIMENTOSSANTIAGO.Platoes", "RutaImagen");
        }
        
        public override void Down()
        {
            AddColumn("ALIMENTOSSANTIAGO.Platoes", "RutaImagen", c => c.String());
            DropColumn("ALIMENTOSSANTIAGO.Platoes", "RutaVirtualImagen");
            DropColumn("ALIMENTOSSANTIAGO.Platoes", "RutaFisicaImagen");
        }
    }
}
