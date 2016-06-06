namespace AlimentosSantiago.Dao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregaCampoEstadoCompra : DbMigration
    {
        public override void Up()
        {
            AddColumn("ALIMENTOSSANTIAGO.PedidoMenus", "EstadoPedidoId", c => c.Decimal(precision: 10, scale: 0));
            CreateIndex("ALIMENTOSSANTIAGO.PedidoMenus", "EstadoPedidoId");
            AddForeignKey("ALIMENTOSSANTIAGO.PedidoMenus", "EstadoPedidoId", "ALIMENTOSSANTIAGO.EstadoPedidoes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("ALIMENTOSSANTIAGO.PedidoMenus", "EstadoPedidoId", "ALIMENTOSSANTIAGO.EstadoPedidoes");
            DropIndex("ALIMENTOSSANTIAGO.PedidoMenus", new[] { "EstadoPedidoId" });
            DropColumn("ALIMENTOSSANTIAGO.PedidoMenus", "EstadoPedidoId");
        }
    }
}
