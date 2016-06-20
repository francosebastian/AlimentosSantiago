using AlimentosSantiago.Dao;
using AlimentosSantiago.Dto;
using AlimentosSantiago.Web.WebUtils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlimentosSantiago.Web.Repartidor
{
    public partial class VerRuta : PaginaBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SetearMapa();
        }

        private void SetearMapa()
        {
            try
            {
                int idPedido = Convert.ToInt32(Request.QueryString["id"]);
                DataTable dtCoordinates = new DataTable();
                dtCoordinates.Columns.AddRange(new DataColumn[4] { new DataColumn("Id", typeof(int)),
                    new DataColumn("Address", typeof(string)),
                    new DataColumn("Latitude",typeof(string)),
                    new DataColumn("Longitude",typeof(string)) });
                PedidoMenu pedido = new PedidoMenu();
                using (OracleDbContext db = new OracleDbContext())
                {
                    pedido = db.PedidoMenu.Include("DireccionUsuario").SingleOrDefault(p => p.Id == idPedido);
                }
                dtCoordinates.Rows.Add(pedido.DireccionUsuario.Id, pedido.DireccionUsuario.Direccion, pedido.DireccionUsuario.Latitud, pedido.DireccionUsuario.Longitud);
                rptMarkers.DataSource = dtCoordinates;
                rptMarkers.DataBind();
            }
            catch (Exception ex)
            {
                MostrarMensaje("Error al cargar el mapa por favor intente mas tarde");
               
            }
        }
    }
}