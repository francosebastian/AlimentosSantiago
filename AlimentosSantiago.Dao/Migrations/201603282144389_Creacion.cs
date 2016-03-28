namespace AlimentosSantiago.Dao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Creacion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "ALIMENTOSSANTIAGO.Clientes",
                c => new
                    {
                        UsuarioId = c.Decimal(nullable: false, precision: 10, scale: 0),
                        Saldo = c.Decimal(nullable: false, precision: 10, scale: 0),
                        EmpresaId = c.Decimal(nullable: false, precision: 10, scale: 0),
                        Telefono = c.String(),
                    })
                .PrimaryKey(t => t.UsuarioId)
                .ForeignKey("ALIMENTOSSANTIAGO.Empresas", t => t.EmpresaId, cascadeDelete: true)
                .ForeignKey("ALIMENTOSSANTIAGO.Usuarios", t => t.UsuarioId)
                .Index(t => t.UsuarioId)
                .Index(t => t.EmpresaId);
            
            CreateTable(
                "ALIMENTOSSANTIAGO.DireccionClientes",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Direccion = c.String(),
                        ClienteId = c.Decimal(nullable: false, precision: 10, scale: 0),
                        Eliminado = c.Decimal(nullable: false, precision: 1, scale: 0),
                        Deshabilitado = c.Decimal(nullable: false, precision: 1, scale: 0),
                        Creado = c.DateTime(nullable: false),
                        Modificado = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("ALIMENTOSSANTIAGO.Clientes", t => t.ClienteId, cascadeDelete: true)
                .Index(t => t.ClienteId);
            
            CreateTable(
                "ALIMENTOSSANTIAGO.Empresas",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Nombre = c.String(),
                        Eliminado = c.Decimal(nullable: false, precision: 1, scale: 0),
                        Deshabilitado = c.Decimal(nullable: false, precision: 1, scale: 0),
                        Creado = c.DateTime(nullable: false),
                        Modificado = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "ALIMENTOSSANTIAGO.Menus",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        ClienteId = c.Decimal(nullable: false, precision: 10, scale: 0),
                        Eliminado = c.Decimal(nullable: false, precision: 1, scale: 0),
                        Deshabilitado = c.Decimal(nullable: false, precision: 1, scale: 0),
                        Creado = c.DateTime(nullable: false),
                        Modificado = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("ALIMENTOSSANTIAGO.Clientes", t => t.ClienteId, cascadeDelete: true)
                .Index(t => t.ClienteId);
            
            CreateTable(
                "ALIMENTOSSANTIAGO.DetalleMenus",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        MenuId = c.Decimal(nullable: false, precision: 10, scale: 0),
                        PlatoId = c.Decimal(nullable: false, precision: 10, scale: 0),
                        Eliminado = c.Decimal(nullable: false, precision: 1, scale: 0),
                        Deshabilitado = c.Decimal(nullable: false, precision: 1, scale: 0),
                        Creado = c.DateTime(nullable: false),
                        Modificado = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("ALIMENTOSSANTIAGO.Menus", t => t.MenuId, cascadeDelete: true)
                .ForeignKey("ALIMENTOSSANTIAGO.Platoes", t => t.PlatoId, cascadeDelete: true)
                .Index(t => t.MenuId)
                .Index(t => t.PlatoId);
            
            CreateTable(
                "ALIMENTOSSANTIAGO.Platoes",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        ProveedorId = c.Decimal(nullable: false, precision: 10, scale: 0),
                        Precio = c.Decimal(nullable: false, precision: 10, scale: 0),
                        Nombre = c.String(nullable: false),
                        Descripcion = c.String(nullable: false),
                        Codigo = c.String(nullable: false),
                        TiempoPreparacion = c.Decimal(nullable: false, precision: 10, scale: 0),
                        Eliminado = c.Decimal(nullable: false, precision: 1, scale: 0),
                        Deshabilitado = c.Decimal(nullable: false, precision: 1, scale: 0),
                        Creado = c.DateTime(nullable: false),
                        Modificado = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("ALIMENTOSSANTIAGO.Proveedors", t => t.ProveedorId, cascadeDelete: true)
                .Index(t => t.ProveedorId);
            
            CreateTable(
                "ALIMENTOSSANTIAGO.DetallePedidoes",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        PedidoId = c.Decimal(nullable: false, precision: 10, scale: 0),
                        Cantidad = c.Decimal(nullable: false, precision: 10, scale: 0),
                        Subtotal = c.Decimal(nullable: false, precision: 10, scale: 0),
                        PlatoId = c.Decimal(nullable: false, precision: 10, scale: 0),
                        Eliminado = c.Decimal(nullable: false, precision: 1, scale: 0),
                        Deshabilitado = c.Decimal(nullable: false, precision: 1, scale: 0),
                        Creado = c.DateTime(nullable: false),
                        Modificado = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("ALIMENTOSSANTIAGO.Pedidoes", t => t.PedidoId, cascadeDelete: true)
                .ForeignKey("ALIMENTOSSANTIAGO.Platoes", t => t.PlatoId, cascadeDelete: true)
                .Index(t => t.PedidoId)
                .Index(t => t.PlatoId);
            
            CreateTable(
                "ALIMENTOSSANTIAGO.Pedidoes",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Total = c.Decimal(nullable: false, precision: 10, scale: 0),
                        ClienteId = c.Decimal(nullable: false, precision: 10, scale: 0),
                        Eliminado = c.Decimal(nullable: false, precision: 1, scale: 0),
                        Deshabilitado = c.Decimal(nullable: false, precision: 1, scale: 0),
                        Creado = c.DateTime(nullable: false),
                        Modificado = c.DateTime(nullable: false),
                        EstadoPedido_Id = c.Decimal(precision: 10, scale: 0),
                        Repartidor_UsuarioId = c.Decimal(precision: 10, scale: 0),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("ALIMENTOSSANTIAGO.Clientes", t => t.ClienteId, cascadeDelete: true)
                .ForeignKey("ALIMENTOSSANTIAGO.EstadoPedidoes", t => t.EstadoPedido_Id)
                .ForeignKey("ALIMENTOSSANTIAGO.Repartidors", t => t.Repartidor_UsuarioId)
                .Index(t => t.ClienteId)
                .Index(t => t.EstadoPedido_Id)
                .Index(t => t.Repartidor_UsuarioId);
            
            CreateTable(
                "ALIMENTOSSANTIAGO.EstadoPedidoes",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Nombre = c.String(nullable: false),
                        Eliminado = c.Decimal(nullable: false, precision: 1, scale: 0),
                        Deshabilitado = c.Decimal(nullable: false, precision: 1, scale: 0),
                        Creado = c.DateTime(nullable: false),
                        Modificado = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "ALIMENTOSSANTIAGO.HistorialPedidoes",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Log = c.String(nullable: false),
                        Eliminado = c.Decimal(nullable: false, precision: 1, scale: 0),
                        Deshabilitado = c.Decimal(nullable: false, precision: 1, scale: 0),
                        Creado = c.DateTime(nullable: false),
                        Modificado = c.DateTime(nullable: false),
                        Pedido_Id = c.Decimal(precision: 10, scale: 0),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("ALIMENTOSSANTIAGO.Pedidoes", t => t.Pedido_Id)
                .Index(t => t.Pedido_Id);
            
            CreateTable(
                "ALIMENTOSSANTIAGO.Repartidors",
                c => new
                    {
                        UsuarioId = c.Decimal(nullable: false, precision: 10, scale: 0),
                    })
                .PrimaryKey(t => t.UsuarioId)
                .ForeignKey("ALIMENTOSSANTIAGO.Usuarios", t => t.UsuarioId)
                .Index(t => t.UsuarioId);
            
            CreateTable(
                "ALIMENTOSSANTIAGO.Usuarios",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Email = c.String(nullable: false),
                        Nombre = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Eliminado = c.Decimal(nullable: false, precision: 1, scale: 0),
                        Deshabilitado = c.Decimal(nullable: false, precision: 1, scale: 0),
                        Creado = c.DateTime(nullable: false),
                        Modificado = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "ALIMENTOSSANTIAGO.TipoPagoes",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Nombre = c.String(nullable: false),
                        Descripcion = c.String(nullable: false),
                        Eliminado = c.Decimal(nullable: false, precision: 1, scale: 0),
                        Deshabilitado = c.Decimal(nullable: false, precision: 1, scale: 0),
                        Creado = c.DateTime(nullable: false),
                        Modificado = c.DateTime(nullable: false),
                        Pedido_Id = c.Decimal(precision: 10, scale: 0),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("ALIMENTOSSANTIAGO.Pedidoes", t => t.Pedido_Id)
                .Index(t => t.Pedido_Id);
            
            CreateTable(
                "ALIMENTOSSANTIAGO.DetallePromocions",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        PlatoId = c.Decimal(nullable: false, precision: 10, scale: 0),
                        Eliminado = c.Decimal(nullable: false, precision: 1, scale: 0),
                        Deshabilitado = c.Decimal(nullable: false, precision: 1, scale: 0),
                        Creado = c.DateTime(nullable: false),
                        Modificado = c.DateTime(nullable: false),
                        Promocion_Id = c.Decimal(precision: 10, scale: 0),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("ALIMENTOSSANTIAGO.Platoes", t => t.PlatoId, cascadeDelete: true)
                .ForeignKey("ALIMENTOSSANTIAGO.Promocions", t => t.Promocion_Id)
                .Index(t => t.PlatoId)
                .Index(t => t.Promocion_Id);
            
            CreateTable(
                "ALIMENTOSSANTIAGO.Proveedors",
                c => new
                    {
                        UsuarioId = c.Decimal(nullable: false, precision: 10, scale: 0),
                        Nombre = c.String(nullable: false),
                        Direccion = c.String(nullable: false),
                        Telefono = c.String(nullable: false),
                        TipoProveedorId = c.Decimal(nullable: false, precision: 10, scale: 0),
                    })
                .PrimaryKey(t => t.UsuarioId)
                .ForeignKey("ALIMENTOSSANTIAGO.TipoProveedors", t => t.TipoProveedorId, cascadeDelete: true)
                .ForeignKey("ALIMENTOSSANTIAGO.Usuarios", t => t.UsuarioId)
                .Index(t => t.UsuarioId)
                .Index(t => t.TipoProveedorId);
            
            CreateTable(
                "ALIMENTOSSANTIAGO.TipoProveedors",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Nombre = c.String(),
                        Eliminado = c.Decimal(nullable: false, precision: 1, scale: 0),
                        Deshabilitado = c.Decimal(nullable: false, precision: 1, scale: 0),
                        Creado = c.DateTime(nullable: false),
                        Modificado = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "ALIMENTOSSANTIAGO.Promocions",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                        Descuento = c.Decimal(nullable: false, precision: 10, scale: 0),
                        Eliminado = c.Decimal(nullable: false, precision: 1, scale: 0),
                        Deshabilitado = c.Decimal(nullable: false, precision: 1, scale: 0),
                        Creado = c.DateTime(nullable: false),
                        Modificado = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("ALIMENTOSSANTIAGO.DetallePromocions", "Promocion_Id", "ALIMENTOSSANTIAGO.Promocions");
            DropForeignKey("ALIMENTOSSANTIAGO.Clientes", "UsuarioId", "ALIMENTOSSANTIAGO.Usuarios");
            DropForeignKey("ALIMENTOSSANTIAGO.Proveedors", "UsuarioId", "ALIMENTOSSANTIAGO.Usuarios");
            DropForeignKey("ALIMENTOSSANTIAGO.Proveedors", "TipoProveedorId", "ALIMENTOSSANTIAGO.TipoProveedors");
            DropForeignKey("ALIMENTOSSANTIAGO.Platoes", "ProveedorId", "ALIMENTOSSANTIAGO.Proveedors");
            DropForeignKey("ALIMENTOSSANTIAGO.DetallePromocions", "PlatoId", "ALIMENTOSSANTIAGO.Platoes");
            DropForeignKey("ALIMENTOSSANTIAGO.DetallePedidoes", "PlatoId", "ALIMENTOSSANTIAGO.Platoes");
            DropForeignKey("ALIMENTOSSANTIAGO.TipoPagoes", "Pedido_Id", "ALIMENTOSSANTIAGO.Pedidoes");
            DropForeignKey("ALIMENTOSSANTIAGO.Repartidors", "UsuarioId", "ALIMENTOSSANTIAGO.Usuarios");
            DropForeignKey("ALIMENTOSSANTIAGO.Pedidoes", "Repartidor_UsuarioId", "ALIMENTOSSANTIAGO.Repartidors");
            DropForeignKey("ALIMENTOSSANTIAGO.HistorialPedidoes", "Pedido_Id", "ALIMENTOSSANTIAGO.Pedidoes");
            DropForeignKey("ALIMENTOSSANTIAGO.Pedidoes", "EstadoPedido_Id", "ALIMENTOSSANTIAGO.EstadoPedidoes");
            DropForeignKey("ALIMENTOSSANTIAGO.DetallePedidoes", "PedidoId", "ALIMENTOSSANTIAGO.Pedidoes");
            DropForeignKey("ALIMENTOSSANTIAGO.Pedidoes", "ClienteId", "ALIMENTOSSANTIAGO.Clientes");
            DropForeignKey("ALIMENTOSSANTIAGO.DetalleMenus", "PlatoId", "ALIMENTOSSANTIAGO.Platoes");
            DropForeignKey("ALIMENTOSSANTIAGO.DetalleMenus", "MenuId", "ALIMENTOSSANTIAGO.Menus");
            DropForeignKey("ALIMENTOSSANTIAGO.Menus", "ClienteId", "ALIMENTOSSANTIAGO.Clientes");
            DropForeignKey("ALIMENTOSSANTIAGO.Clientes", "EmpresaId", "ALIMENTOSSANTIAGO.Empresas");
            DropForeignKey("ALIMENTOSSANTIAGO.DireccionClientes", "ClienteId", "ALIMENTOSSANTIAGO.Clientes");
            DropIndex("ALIMENTOSSANTIAGO.Proveedors", new[] { "TipoProveedorId" });
            DropIndex("ALIMENTOSSANTIAGO.Proveedors", new[] { "UsuarioId" });
            DropIndex("ALIMENTOSSANTIAGO.DetallePromocions", new[] { "Promocion_Id" });
            DropIndex("ALIMENTOSSANTIAGO.DetallePromocions", new[] { "PlatoId" });
            DropIndex("ALIMENTOSSANTIAGO.TipoPagoes", new[] { "Pedido_Id" });
            DropIndex("ALIMENTOSSANTIAGO.Repartidors", new[] { "UsuarioId" });
            DropIndex("ALIMENTOSSANTIAGO.HistorialPedidoes", new[] { "Pedido_Id" });
            DropIndex("ALIMENTOSSANTIAGO.Pedidoes", new[] { "Repartidor_UsuarioId" });
            DropIndex("ALIMENTOSSANTIAGO.Pedidoes", new[] { "EstadoPedido_Id" });
            DropIndex("ALIMENTOSSANTIAGO.Pedidoes", new[] { "ClienteId" });
            DropIndex("ALIMENTOSSANTIAGO.DetallePedidoes", new[] { "PlatoId" });
            DropIndex("ALIMENTOSSANTIAGO.DetallePedidoes", new[] { "PedidoId" });
            DropIndex("ALIMENTOSSANTIAGO.Platoes", new[] { "ProveedorId" });
            DropIndex("ALIMENTOSSANTIAGO.DetalleMenus", new[] { "PlatoId" });
            DropIndex("ALIMENTOSSANTIAGO.DetalleMenus", new[] { "MenuId" });
            DropIndex("ALIMENTOSSANTIAGO.Menus", new[] { "ClienteId" });
            DropIndex("ALIMENTOSSANTIAGO.DireccionClientes", new[] { "ClienteId" });
            DropIndex("ALIMENTOSSANTIAGO.Clientes", new[] { "EmpresaId" });
            DropIndex("ALIMENTOSSANTIAGO.Clientes", new[] { "UsuarioId" });
            DropTable("ALIMENTOSSANTIAGO.Promocions");
            DropTable("ALIMENTOSSANTIAGO.TipoProveedors");
            DropTable("ALIMENTOSSANTIAGO.Proveedors");
            DropTable("ALIMENTOSSANTIAGO.DetallePromocions");
            DropTable("ALIMENTOSSANTIAGO.TipoPagoes");
            DropTable("ALIMENTOSSANTIAGO.Usuarios");
            DropTable("ALIMENTOSSANTIAGO.Repartidors");
            DropTable("ALIMENTOSSANTIAGO.HistorialPedidoes");
            DropTable("ALIMENTOSSANTIAGO.EstadoPedidoes");
            DropTable("ALIMENTOSSANTIAGO.Pedidoes");
            DropTable("ALIMENTOSSANTIAGO.DetallePedidoes");
            DropTable("ALIMENTOSSANTIAGO.Platoes");
            DropTable("ALIMENTOSSANTIAGO.DetalleMenus");
            DropTable("ALIMENTOSSANTIAGO.Menus");
            DropTable("ALIMENTOSSANTIAGO.Empresas");
            DropTable("ALIMENTOSSANTIAGO.DireccionClientes");
            DropTable("ALIMENTOSSANTIAGO.Clientes");
        }
    }
}
