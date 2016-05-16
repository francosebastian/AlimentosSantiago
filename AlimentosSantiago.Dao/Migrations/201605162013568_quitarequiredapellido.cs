namespace AlimentosSantiago.Dao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class quitarequiredapellido : DbMigration
    {
        public override void Up()
        {
            AlterColumn("ALIMENTOSSANTIAGO.Usuarios", "Apellido", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("ALIMENTOSSANTIAGO.Usuarios", "Apellido", c => c.String(nullable: false));
        }
    }
}
