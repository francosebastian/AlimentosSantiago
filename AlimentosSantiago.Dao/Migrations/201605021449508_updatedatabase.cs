namespace AlimentosSantiago.Dao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedatabase : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("ALIMENTOSSANTIAGO.PedidoMenus", "RepartidorId", "ALIMENTOSSANTIAGO.Usuarios");
            DropForeignKey("ALIMENTOSSANTIAGO.Usuarios", "EmpresaId", "ALIMENTOSSANTIAGO.Empresas");
            DropIndex("ALIMENTOSSANTIAGO.PedidoMenus", new[] { "RepartidorId" });
            DropIndex("ALIMENTOSSANTIAGO.Usuarios", new[] { "EmpresaId" });
            AlterColumn("ALIMENTOSSANTIAGO.PedidoMenus", "RepartidorId", c => c.Decimal(precision: 10, scale: 0));
            AlterColumn("ALIMENTOSSANTIAGO.Usuarios", "EmpresaId", c => c.Decimal(precision: 10, scale: 0));
            CreateIndex("ALIMENTOSSANTIAGO.PedidoMenus", "RepartidorId");
            CreateIndex("ALIMENTOSSANTIAGO.Usuarios", "EmpresaId");
            AddForeignKey("ALIMENTOSSANTIAGO.PedidoMenus", "RepartidorId", "ALIMENTOSSANTIAGO.Usuarios", "Id");
            AddForeignKey("ALIMENTOSSANTIAGO.Usuarios", "EmpresaId", "ALIMENTOSSANTIAGO.Empresas", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("ALIMENTOSSANTIAGO.Usuarios", "EmpresaId", "ALIMENTOSSANTIAGO.Empresas");
            DropForeignKey("ALIMENTOSSANTIAGO.PedidoMenus", "RepartidorId", "ALIMENTOSSANTIAGO.Usuarios");
            DropIndex("ALIMENTOSSANTIAGO.Usuarios", new[] { "EmpresaId" });
            DropIndex("ALIMENTOSSANTIAGO.PedidoMenus", new[] { "RepartidorId" });
            AlterColumn("ALIMENTOSSANTIAGO.Usuarios", "EmpresaId", c => c.Decimal(nullable: false, precision: 10, scale: 0));
            AlterColumn("ALIMENTOSSANTIAGO.PedidoMenus", "RepartidorId", c => c.Decimal(nullable: false, precision: 10, scale: 0));
            CreateIndex("ALIMENTOSSANTIAGO.Usuarios", "EmpresaId");
            CreateIndex("ALIMENTOSSANTIAGO.PedidoMenus", "RepartidorId");
            AddForeignKey("ALIMENTOSSANTIAGO.Usuarios", "EmpresaId", "ALIMENTOSSANTIAGO.Empresas", "Id", cascadeDelete: true);
            AddForeignKey("ALIMENTOSSANTIAGO.PedidoMenus", "RepartidorId", "ALIMENTOSSANTIAGO.Usuarios", "Id", cascadeDelete: true);
        }
    }
}
