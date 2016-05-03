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
        public DbSet<CategoriaPlato> CategoriaPlato { get; set; }
        public DbSet<DetallePedidoMenu> DetallePedidoMenu { get; set; }
        public DbSet<DireccionUsuario> DireccionUsuario { get; set; }
        public DbSet<Empresa> Empresa { set; get; }
        public DbSet<EstadoPedido> EstadoPedido { set; get; }
        public DbSet<LogPedidoMenu> LogPedidoMenu { set; get; }
        public DbSet<LogSaldo> LogSaldo { set; get; }
        public DbSet<PedidoMenu> PedidoMenu { set; get; }
        public DbSet<Plato> Plato { set; get; }
        public DbSet<TipoPago> TipoPago { set; get; }
        public DbSet<TipoUsuario> TipoUsuario { set; get; }
        public DbSet<Usuario> Usuario { set; get; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("ALIMENTOSSANTIAGO");
        }
    }
}
