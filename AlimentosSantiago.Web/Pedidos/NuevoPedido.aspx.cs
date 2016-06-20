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
            try
            {
                efDireccionUsuario.WhereParameters["IdUsuario"].DefaultValue = Session["IdUsuario"].ToString().Trim();
                gvShoppingCart.DataSource = CarritoCompras.Instance.Items;
                gvShoppingCart.DataBind();
                if (CarritoCompras.Instance.Items.Count > 0)
                {
                    pnlOrden.Visible = true;
                }
            }
            catch (Exception)
            {
                MostrarMensaje("Error al cargar pagina");
                throw;
            }
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
            try
            {
                if (Validar())
                {
                    PedidoMenu pedido = new PedidoMenu();
                    pedido.ClienteId = (int)Session["IdUsuario"];
                    pedido.Fecha = System.DateTime.Now;
                    pedido.TipoPagoId = ddlTipoPago.SelectedIndex;
                    pedido.DireccionUsuarioId = ddlDireccionUsuario.SelectedIndex;
                    pedido.DetallesPedidoMenu = CarritoCompras.Instance.Items;
                    pedido.Creado = System.DateTime.Now;
                    pedido.Modificado = System.DateTime.Now;
                    List<LogPedidoMenu> logs = new List<LogPedidoMenu>();
                    LogPedidoMenu log = new LogPedidoMenu();
                    log.EstadoPedidoId = (int)EstadosPedido.Realizado;
                    log.Creado = System.DateTime.Now;
                    log.Modificado = System.DateTime.Now;
                    log.Log = "Pedido Creado";
                    logs.Add(log);

                    pedido.LogsPedidoMenu = logs;
                    pedido.EstadoPedidoId = (int)EstadosPedido.Realizado;
                    using (OracleDbContext db = new OracleDbContext())
                    {
                        pedido.Cliente = db.Usuario.FirstOrDefault(u => u.Id == pedido.ClienteId);
                        pedido.Creado = System.DateTime.Now;
                        pedido.Modificado = System.DateTime.Now;
                        db.PedidoMenu.Add(pedido);
                        db.SaveChanges();
                    }

                    //vacia el carrito
                    CarritoCompras.Instance.ClearItems();


                    PresentadorCorreo presentador = new PresentadorCorreo();
                    presentador.Id = pedido.Id;
                    //presentador.DetallesPedidoMenu = pedido.DetallesPedidoMenu.ToList();
                    //presentador.DireccionUsuario = pedido.DireccionUsuario;
                    if (EnviarCorreo(presentador, pedido))
                    {
                        MostrarMensaje("Pedido creado con exito");
                    }
                    else
                    {
                        MostrarMensaje("Ha ocurrido un error en el envio de correo");
                    }
                }
            }
            catch (Exception)
            {
                MostrarMensaje("Ha ocurrido un error inesperado");
                throw;
            }
            
        }
        public bool Validar()
        {
            Boolean respuesta = true;
            if (ddlDireccionUsuario.SelectedValue == "")
            {
                respuesta = false;
                MostrarMensaje("Compruebe la direccion antes de hacer el pedido");
            }
            if (ddlTipoPago.SelectedValue == "")
            {
                respuesta = false;
                MostrarMensaje("Compruebe el tipo de pago antes de hacer el pedido");
            }
            return respuesta;
        }
        public Boolean EnviarCorreo(PresentadorCorreo presentador, PedidoMenu pedido)
        {
            EnviadorCorreo enviadorCorreo = new EnviadorCorreo();
            enviadorCorreo.Destinatarios.Add(pedido.Cliente.Email);
            enviadorCorreo.TituloCorreo = String.Format("Nueva Orden N{0}", pedido.Id);
            enviadorCorreo.Mensaje = new PlantillaCorreoHelper().TransformarPlantillaEnHtml<PresentadorCorreo>(presentador,
                Server.MapPath("~/PlantillasCorreo/NuevaOrden.xslt"));
            return enviadorCorreo.IntentarEnviar();
        }
    }
}