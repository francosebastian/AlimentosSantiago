namespace AlimentosSantiago.Dao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModificacionDatabase001 : DbMigration
    {
        public override void Up()
        {
            AddColumn("ALIMENTOSSANTIAGO.Clientes", "Eliminado", c => c.Decimal(nullable: false, precision: 1, scale: 0));
            AddColumn("ALIMENTOSSANTIAGO.Clientes", "Deshabilitado", c => c.Decimal(nullable: false, precision: 1, scale: 0));
            AddColumn("ALIMENTOSSANTIAGO.Clientes", "Creado", c => c.DateTime(nullable: false));
            AddColumn("ALIMENTOSSANTIAGO.Clientes", "Modificado", c => c.DateTime(nullable: false));
            AddColumn("ALIMENTOSSANTIAGO.Repartidors", "Eliminado", c => c.Decimal(nullable: false, precision: 1, scale: 0));
            AddColumn("ALIMENTOSSANTIAGO.Repartidors", "Deshabilitado", c => c.Decimal(nullable: false, precision: 1, scale: 0));
            AddColumn("ALIMENTOSSANTIAGO.Repartidors", "Creado", c => c.DateTime(nullable: false));
            AddColumn("ALIMENTOSSANTIAGO.Repartidors", "Modificado", c => c.DateTime(nullable: false));
            AddColumn("ALIMENTOSSANTIAGO.Proveedors", "Eliminado", c => c.Decimal(nullable: false, precision: 1, scale: 0));
            AddColumn("ALIMENTOSSANTIAGO.Proveedors", "Deshabilitado", c => c.Decimal(nullable: false, precision: 1, scale: 0));
            AddColumn("ALIMENTOSSANTIAGO.Proveedors", "Creado", c => c.DateTime(nullable: false));
            AddColumn("ALIMENTOSSANTIAGO.Proveedors", "Modificado", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("ALIMENTOSSANTIAGO.Proveedors", "Modificado");
            DropColumn("ALIMENTOSSANTIAGO.Proveedors", "Creado");
            DropColumn("ALIMENTOSSANTIAGO.Proveedors", "Deshabilitado");
            DropColumn("ALIMENTOSSANTIAGO.Proveedors", "Eliminado");
            DropColumn("ALIMENTOSSANTIAGO.Repartidors", "Modificado");
            DropColumn("ALIMENTOSSANTIAGO.Repartidors", "Creado");
            DropColumn("ALIMENTOSSANTIAGO.Repartidors", "Deshabilitado");
            DropColumn("ALIMENTOSSANTIAGO.Repartidors", "Eliminado");
            DropColumn("ALIMENTOSSANTIAGO.Clientes", "Modificado");
            DropColumn("ALIMENTOSSANTIAGO.Clientes", "Creado");
            DropColumn("ALIMENTOSSANTIAGO.Clientes", "Deshabilitado");
            DropColumn("ALIMENTOSSANTIAGO.Clientes", "Eliminado");
        }
    }
}
