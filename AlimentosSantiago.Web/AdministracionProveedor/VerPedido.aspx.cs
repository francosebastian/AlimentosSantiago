using AlimentosSantiago.Dao;
using AlimentosSantiago.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlimentosSantiago.Web.AdministracionProveedor
{
    public partial class VerPedido : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
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
    }
}