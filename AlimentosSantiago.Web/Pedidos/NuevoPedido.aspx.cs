using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AlimentosSantiago.Dto;
using static AlimentosSantiago.Dto.Enumeraciones;
using AlimentosSantiago.Web.WebUtils;
using AlimentosSantiago.Dao;
namespace AlimentosSantiago.Web.Pedidos
{
    public partial class NuevoPedido : PaginaBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            gvShoppingCart.DataSource = CarritoCompras.Instance.Items;
            gvShoppingCart.DataBind();
        }

        protected void btnUpdateCart_Click(object sender, EventArgs e)
        {

        }

        protected void gvShoppingCart_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }

        protected void gvShoppingCart_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }
        protected void btnPedido_Click(object sender, EventArgs e)
        {
            PedidoMenu pedido = new PedidoMenu();
            pedido.ClienteId = (int)Session["IdUsuario"];
            pedido.Fecha = System.DateTime.Now;
            pedido.TipoPagoId = ddlTipoPago.SelectedIndex;
            pedido.DireccionUsuarioId = ddlDireccionUsuario.SelectedIndex;
            pedido.DetallesPedidoMenu = CarritoCompras.Instance.Items;

            List<LogPedidoMenu> logs= new List<LogPedidoMenu>();
            LogPedidoMenu log = new LogPedidoMenu();
            log.EstadoPedidoId = (int)EstadosPedido.Realizado;
            log.Creado = System.DateTime.Now;
            log.Modificado = System.DateTime.Now;
            log.Log = "Pedido Creado";
            logs.Add(log);

            pedido.LogsPedidoMenu = logs;
            pedido.EstadoPedidoId = (int)EstadosPedido.Realizado;
            using (OracleDbContext db= new OracleDbContext())
            {
                pedido.Creado = System.DateTime.Now;
                pedido.Modificado = System.DateTime.Now;
                db.PedidoMenu.Add(pedido);
                db.SaveChanges();
            }

            //vacia el carrito
            CarritoCompras.Instance.ClearItems();
            MostrarMensaje("Pedido creado");
        }
    }
}