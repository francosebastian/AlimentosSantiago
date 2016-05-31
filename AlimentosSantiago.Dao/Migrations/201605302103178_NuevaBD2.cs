namespace AlimentosSantiago.Dao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NuevaBD2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("ALIMENTOSSANTIAGO.Platoes", "RutaFisicaImagen", c => c.String(maxLength: 300));
            AlterColumn("ALIMENTOSSANTIAGO.Platoes", "RutaVirtualImagen", c => c.String(maxLength: 300));
        }
        
        public override void Down()
        {
            AlterColumn("ALIMENTOSSANTIAGO.Platoes", "RutaVirtualImagen", c => c.String(maxLength: 100));
            AlterColumn("ALIMENTOSSANTIAGO.Platoes", "RutaFisicaImagen", c => c.String(maxLength: 100));
        }
    }
}
