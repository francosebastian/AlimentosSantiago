using AlimentosSantiago.Dao;
using AlimentosSantiago.Dto;
using AlimentosSantiago.Web.WebUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using static AlimentosSantiago.Dto.Enumeraciones;

namespace AlimentosSantiago.Web.AdministracionEncargadoPedido
{
    public partial class VerPedido : PaginaBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                using (OracleDbContext db = new OracleDbContext())
                {
                    int idPedido = Convert.ToInt32(Request.QueryString["id"]);

                    var pedido = db.PedidoMenu.Include("DetallesPedidoMenu").Include("EstadoPedido").SingleOrDefault(p => p.Id == idPedido);
                    txtFecha.Text = pedido.Fecha.ToString();
                    txtEstadoPedido.Text = pedido.EstadoPedido.Nombre;
                    foreach (DetallePedidoMenu item in pedido.DetallesPedidoMenu)
                    {
                        Plato plato = db.Plato.FirstOrDefault(p => p.Id == item.PlatoId);
                        item.Nombre = plato.Nombre;
                    }
                    RadGridPedidos.DataSource = pedido.DetallesPedidoMenu;
                    RadGridPedidos.DataBind();
                }
            }
            catch (Exception ex)
            {
                base.MostrarMensaje("Error al cargar el pedido, por favor intente mas tarde");
                throw ex;
            }
        }
        protected void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            try
            {
                using (OracleDbContext db = new OracleDbContext())
                {
                    int idPedido = Convert.ToInt32(Request.QueryString["id"]);
                    var pedido = db.PedidoMenu.SingleOrDefault(p => p.Id == idPedido);
                    pedido.EstadoPedidoId = (int)EstadosPedido.Recibido;
                    db.Entry(pedido).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                base.MostrarMensaje("El pedido fue cambiado a estado en preparacion");
            }
            catch (Exception ex)
            {
                base.MostrarMensaje("Ha ocurrido un error, por favor intente mas tarde");
                throw;
            }
        }
    }
}