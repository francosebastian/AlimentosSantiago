using AlimentosSantiago.Dto;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentosSantiago.Dao
{
    public class OracleDbContext : DbContext
    {
        public OracleDbContext()
            : base("OracleDbContext")
        {
        }
        public DbSet<Cliente> Cliente { set; get; }
        public DbSet<DetallePedido> DetallePedido { set; get; }
        public DbSet<DireccionCliente> DireccionCliente { get; set; }
        public DbSet<Empresa> Empresa { set; get; }
        public DbSet<EstadoPedido> EstadoPedido { set; get; }
        public DbSet<HistorialPedido> HistorialPedido { get; set; }
        public DbSet<Pedido> Pedido { set; get; }
        public DbSet<Plato> Plato { set; get; }
        public DbSet<Promocion> Promocion { set; get; }
        public DbSet<Proveedor> Proveedor { set; get; }
        public DbSet<Repartidor> Repartidor { set; get; }
        public DbSet<TipoPago> TipoPago { set; get; }
        public DbSet<TipoProveedor> TipoProveedor { set; get; }
        public DbSet<Usuario> Usuario { set; get; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("ALIMENTOSSANTIAGO");
        }
    }
}
