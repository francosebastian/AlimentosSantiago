namespace AlimentosSantiago.Dao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreacionDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "ALIMENTOSSANTIAGO.CategoriaPlatoes",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Nombre = c.String(nullable: false),
                        Descripcion = c.String(nullable: false),
                        Eliminado = c.Decimal(nullable: false, precision: 1, scale: 0),
                        Deshabilitado = c.Decimal(nullable: false, precision: 1, scale: 0),
                        Creado = c.DateTime(nullable: false),
                        Modificado = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "ALIMENTOSSANTIAGO.Platoes",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Nombre = c.String(nullable: false),
                        Descripcion = c.String(nullable: false),
                        Precio = c.Decimal(nullable: false, precision: 10, scale: 0),
                        PrecioPromocion = c.Decimal(nullable: false, precision: 10, scale: 0),
                        PromocionActiva = c.Decimal(nullable: false, precision: 1, scale: 0),
                        RutaImagen = c.String(),
                        CategoriaPlatoId = c.Decimal(nullable: false, precision: 10, scale: 0),
                        Eliminado = c.Decimal(nullable: false, precision: 1, scale: 0),
                        Deshabilitado = c.Decimal(nullable: false, precision: 1, scale: 0),
                        Creado = c.DateTime(nullable: false),
                        Modificado = c.DateTime(nullable: false),
                        Usuario_Id = c.Decimal(precision: 10, scale: 0),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("ALIMENTOSSANTIAGO.CategoriaPlatoes", t => t.CategoriaPlatoId, cascadeDelete: true)
                .ForeignKey("ALIMENTOSSANTIAGO.Usuarios", t => t.Usuario_Id)
                .Index(t => t.CategoriaPlatoId)
                .Index(t => t.Usuario_Id);
            
            CreateTable(
                "ALIMENTOSSANTIAGO.DetallePedidoMenus",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Cantidad = c.Decimal(nullable: false, precision: 10, scale: 0),
                        PrecioUnitario = c.Decimal(nullable: false, precision: 10, scale: 0),
                        PedidoMenuId = c.Decimal(nullable: false, precision: 10, scale: 0),
                        PlatoId = c.Decimal(nullable: false, precision: 10, scale: 0),
                        Eliminado = c.Decimal(nullable: false, precision: 1, scale: 0),
                        Deshabilitado = c.Decimal(nullable: false, precision: 1, scale: 0),
                        Creado = c.DateTime(nullable: false),
                        Modificado = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("ALIMENTOSSANTIAGO.PedidoMenus", t => t.PedidoMenuId, cascadeDelete: true)
                .ForeignKey("ALIMENTOSSANTIAGO.Platoes", t => t.PlatoId, cascadeDelete: true)
                .Index(t => t.PedidoMenuId)
                .Index(t => t.PlatoId);
            
            CreateTable(
                "ALIMENTOSSANTIAGO.PedidoMenus",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Fecha = c.DateTime(nullable: false),
                        TipoPagoId = c.Decimal(nullable: false, precision: 10, scale: 0),
                        ClienteId = c.Decimal(nullable: false, precision: 10, scale: 0),
                        RepartidorId = c.Decimal(nullable: false, precision: 10, scale: 0),
                        DireccionUsuarioId = c.Decimal(nullable: false, precision: 10, scale: 0),
                        Eliminado = c.Decimal(nullable: false, precision: 1, scale: 0),
                        Deshabilitado = c.Decimal(nullable: false, precision: 1, scale: 0),
                        Creado = c.DateTime(nullable: false),
                        Modificado = c.DateTime(nullable: false),
                        Usuario_Id = c.Decimal(precision: 10, scale: 0),
                        Usuario_Id1 = c.Decimal(precision: 10, scale: 0),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("ALIMENTOSSANTIAGO.DireccionUsuarios", t => t.DireccionUsuarioId, cascadeDelete: true)
                .ForeignKey("ALIMENTOSSANTIAGO.Usuarios", t => t.Usuario_Id)
                .ForeignKey("ALIMENTOSSANTIAGO.Usuarios", t => t.Usuario_Id1)
                .ForeignKey("ALIMENTOSSANTIAGO.Usuarios", t => t.ClienteId, cascadeDelete: true)
                .ForeignKey("ALIMENTOSSANTIAGO.Usuarios", t => t.RepartidorId, cascadeDelete: true)
                .ForeignKey("ALIMENTOSSANTIAGO.TipoPagoes", t => t.TipoPagoId, cascadeDelete: true)
                .Index(t => t.TipoPagoId)
                .Index(t => t.ClienteId)
                .Index(t => t.RepartidorId)
                .Index(t => t.DireccionUsuarioId)
                .Index(t => t.Usuario_Id)
                .Index(t => t.Usuario_Id1);
            
            CreateTable(
                "ALIMENTOSSANTIAGO.Usuarios",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Nombre = c.String(nullable: false),
                        Apellido = c.String(nullable: false),
                        Telefono = c.String(nullable: false),
                        Telefono2 = c.String(),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        EmpresaId = c.Decimal(nullable: false, precision: 10, scale: 0),
                        TipoUsuarioId = c.Decimal(nullable: false, precision: 10, scale: 0),
                        Eliminado = c.Decimal(nullable: false, precision: 1, scale: 0),
                        Deshabilitado = c.Decimal(nullable: false, precision: 1, scale: 0),
                        Creado = c.DateTime(nullable: false),
                        Modificado = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("ALIMENTOSSANTIAGO.Empresas", t => t.EmpresaId, cascadeDelete: true)
                .ForeignKey("ALIMENTOSSANTIAGO.TipoUsuarios", t => t.TipoUsuarioId, cascadeDelete: true)
                .Index(t => t.EmpresaId)
                .Index(t => t.TipoUsuarioId);
            
            CreateTable(
                "ALIMENTOSSANTIAGO.DireccionUsuarios",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Direccion = c.String(nullable: false),
                        UsuarioId = c.Decimal(nullable: false, precision: 10, scale: 0),
                        Eliminado = c.Decimal(nullable: false, precision: 1, scale: 0),
                        Deshabilitado = c.Decimal(nullable: false, precision: 1, scale: 0),
                        Creado = c.DateTime(nullable: false),
                        Modificado = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("ALIMENTOSSANTIAGO.Usuarios", t => t.UsuarioId, cascadeDelete: true)
                .Index(t => t.UsuarioId);
            
            CreateTable(
                "ALIMENTOSSANTIAGO.Empresas",
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
                "ALIMENTOSSANTIAGO.LogSaldoes",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Log = c.String(),
                        UsuarioId = c.Decimal(nullable: false, precision: 10, scale: 0),
                        Eliminado = c.Decimal(nullable: false, precision: 1, scale: 0),
                        Deshabilitado = c.Decimal(nullable: false, precision: 1, scale: 0),
                        Creado = c.DateTime(nullable: false),
                        Modificado = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("ALIMENTOSSANTIAGO.Usuarios", t => t.UsuarioId, cascadeDelete: true)
                .Index(t => t.UsuarioId);
            
            CreateTable(
                "ALIMENTOSSANTIAGO.TipoUsuarios",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Nombre = c.String(nullable: false),
                        Descripcion = c.String(nullable: false),
                        Eliminado = c.Decimal(nullable: false, precision: 1, scale: 0),
                        Deshabilitado = c.Decimal(nullable: false, precision: 1, scale: 0),
                        Creado = c.DateTime(nullable: false),
                        Modificado = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "ALIMENTOSSANTIAGO.LogPedidoMenus",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Log = c.String(),
                        PedidoMenuId = c.Decimal(nullable: false, precision: 10, scale: 0),
                        EstadoPedidoId = c.Decimal(nullable: false, precision: 10, scale: 0),
                        Eliminado = c.Decimal(nullable: false, precision: 1, scale: 0),
                        Deshabilitado = c.Decimal(nullable: false, precision: 1, scale: 0),
                        Creado = c.DateTime(nullable: false),
                        Modificado = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("ALIMENTOSSANTIAGO.EstadoPedidoes", t => t.EstadoPedidoId, cascadeDelete: true)
                .ForeignKey("ALIMENTOSSANTIAGO.PedidoMenus", t => t.PedidoMenuId, cascadeDelete: true)
                .Index(t => t.PedidoMenuId)
                .Index(t => t.EstadoPedidoId);
            
            CreateTable(
                "ALIMENTOSSANTIAGO.EstadoPedidoes",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Nombre = c.String(nullable: false),
                        Descripcion = c.String(nullable: false),
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
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("ALIMENTOSSANTIAGO.DetallePedidoMenus", "PlatoId", "ALIMENTOSSANTIAGO.Platoes");
            DropForeignKey("ALIMENTOSSANTIAGO.PedidoMenus", "TipoPagoId", "ALIMENTOSSANTIAGO.TipoPagoes");
            DropForeignKey("ALIMENTOSSANTIAGO.PedidoMenus", "RepartidorId", "ALIMENTOSSANTIAGO.Usuarios");
            DropForeignKey("ALIMENTOSSANTIAGO.LogPedidoMenus", "PedidoMenuId", "ALIMENTOSSANTIAGO.PedidoMenus");
            DropForeignKey("ALIMENTOSSANTIAGO.LogPedidoMenus", "EstadoPedidoId", "ALIMENTOSSANTIAGO.EstadoPedidoes");
            DropForeignKey("ALIMENTOSSANTIAGO.DetallePedidoMenus", "PedidoMenuId", "ALIMENTOSSANTIAGO.PedidoMenus");
            DropForeignKey("ALIMENTOSSANTIAGO.PedidoMenus", "ClienteId", "ALIMENTOSSANTIAGO.Usuarios");
            DropForeignKey("ALIMENTOSSANTIAGO.Usuarios", "TipoUsuarioId", "ALIMENTOSSANTIAGO.TipoUsuarios");
            DropForeignKey("ALIMENTOSSANTIAGO.Platoes", "Usuario_Id", "ALIMENTOSSANTIAGO.Usuarios");
            DropForeignKey("ALIMENTOSSANTIAGO.PedidoMenus", "Usuario_Id1", "ALIMENTOSSANTIAGO.Usuarios");
            DropForeignKey("ALIMENTOSSANTIAGO.PedidoMenus", "Usuario_Id", "ALIMENTOSSANTIAGO.Usuarios");
            DropForeignKey("ALIMENTOSSANTIAGO.LogSaldoes", "UsuarioId", "ALIMENTOSSANTIAGO.Usuarios");
            DropForeignKey("ALIMENTOSSANTIAGO.Usuarios", "EmpresaId", "ALIMENTOSSANTIAGO.Empresas");
            DropForeignKey("ALIMENTOSSANTIAGO.DireccionUsuarios", "UsuarioId", "ALIMENTOSSANTIAGO.Usuarios");
            DropForeignKey("ALIMENTOSSANTIAGO.PedidoMenus", "DireccionUsuarioId", "ALIMENTOSSANTIAGO.DireccionUsuarios");
            DropForeignKey("ALIMENTOSSANTIAGO.Platoes", "CategoriaPlatoId", "ALIMENTOSSANTIAGO.CategoriaPlatoes");
            DropIndex("ALIMENTOSSANTIAGO.LogPedidoMenus", new[] { "EstadoPedidoId" });
            DropIndex("ALIMENTOSSANTIAGO.LogPedidoMenus", new[] { "PedidoMenuId" });
            DropIndex("ALIMENTOSSANTIAGO.LogSaldoes", new[] { "UsuarioId" });
            DropIndex("ALIMENTOSSANTIAGO.DireccionUsuarios", new[] { "UsuarioId" });
            DropIndex("ALIMENTOSSANTIAGO.Usuarios", new[] { "TipoUsuarioId" });
            DropIndex("ALIMENTOSSANTIAGO.Usuarios", new[] { "EmpresaId" });
            DropIndex("ALIMENTOSSANTIAGO.PedidoMenus", new[] { "Usuario_Id1" });
            DropIndex("ALIMENTOSSANTIAGO.PedidoMenus", new[] { "Usuario_Id" });
            DropIndex("ALIMENTOSSANTIAGO.PedidoMenus", new[] { "DireccionUsuarioId" });
            DropIndex("ALIMENTOSSANTIAGO.PedidoMenus", new[] { "RepartidorId" });
            DropIndex("ALIMENTOSSANTIAGO.PedidoMenus", new[] { "ClienteId" });
            DropIndex("ALIMENTOSSANTIAGO.PedidoMenus", new[] { "TipoPagoId" });
            DropIndex("ALIMENTOSSANTIAGO.DetallePedidoMenus", new[] { "PlatoId" });
            DropIndex("ALIMENTOSSANTIAGO.DetallePedidoMenus", new[] { "PedidoMenuId" });
            DropIndex("ALIMENTOSSANTIAGO.Platoes", new[] { "Usuario_Id" });
            DropIndex("ALIMENTOSSANTIAGO.Platoes", new[] { "CategoriaPlatoId" });
            DropTable("ALIMENTOSSANTIAGO.TipoPagoes");
            DropTable("ALIMENTOSSANTIAGO.EstadoPedidoes");
            DropTable("ALIMENTOSSANTIAGO.LogPedidoMenus");
            DropTable("ALIMENTOSSANTIAGO.TipoUsuarios");
            DropTable("ALIMENTOSSANTIAGO.LogSaldoes");
            DropTable("ALIMENTOSSANTIAGO.Empresas");
            DropTable("ALIMENTOSSANTIAGO.DireccionUsuarios");
            DropTable("ALIMENTOSSANTIAGO.Usuarios");
            DropTable("ALIMENTOSSANTIAGO.PedidoMenus");
            DropTable("ALIMENTOSSANTIAGO.DetallePedidoMenus");
            DropTable("ALIMENTOSSANTIAGO.Platoes");
            DropTable("ALIMENTOSSANTIAGO.CategoriaPlatoes");
        }
    }
}
