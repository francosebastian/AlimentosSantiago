namespace AlimentosSantiago.Dao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedatabaseCampos : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("ALIMENTOSSANTIAGO.Platoes", "Usuario_Id", "ALIMENTOSSANTIAGO.Usuarios");
            DropIndex("ALIMENTOSSANTIAGO.Platoes", new[] { "Usuario_Id" });
            RenameColumn(table: "ALIMENTOSSANTIAGO.Platoes", name: "Usuario_Id", newName: "ProveedorId");
            AlterColumn("ALIMENTOSSANTIAGO.Platoes", "ProveedorId", c => c.Decimal(nullable: false, precision: 10, scale: 0));
            CreateIndex("ALIMENTOSSANTIAGO.Platoes", "ProveedorId");
            AddForeignKey("ALIMENTOSSANTIAGO.Platoes", "ProveedorId", "ALIMENTOSSANTIAGO.Usuarios", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("ALIMENTOSSANTIAGO.Platoes", "ProveedorId", "ALIMENTOSSANTIAGO.Usuarios");
            DropIndex("ALIMENTOSSANTIAGO.Platoes", new[] { "ProveedorId" });
            AlterColumn("ALIMENTOSSANTIAGO.Platoes", "ProveedorId", c => c.Decimal(precision: 10, scale: 0));
            RenameColumn(table: "ALIMENTOSSANTIAGO.Platoes", name: "ProveedorId", newName: "Usuario_Id");
            CreateIndex("ALIMENTOSSANTIAGO.Platoes", "Usuario_Id");
            AddForeignKey("ALIMENTOSSANTIAGO.Platoes", "Usuario_Id", "ALIMENTOSSANTIAGO.Usuarios", "Id");
        }
    }
}
