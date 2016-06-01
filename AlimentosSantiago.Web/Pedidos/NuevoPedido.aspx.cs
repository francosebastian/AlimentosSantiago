using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AlimentosSantiago.Dto;
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
            
            using (OracleDbContext db= new OracleDbContext())
            {
                pedido.Creado = System.DateTime.Now;
                pedido.Modificado = System.DateTime.Now;
                db.PedidoMenu.Add(pedido);
                db.SaveChanges();
            }
        }
    }
}