using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AlimentosSantiago.Web.WebUtils;
using System.Text;
using static AlimentosSantiago.Dto.Enumeraciones;
using AlimentosSantiago.Dto;
using AlimentosSantiago.Dao;

namespace AlimentosSantiago.Web.Wuc
{
    public partial class MenuNavegacion : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SetearCarro();
            if (Session["IdUsuario"] != null)
            {
                SetearMenu();
                lnkLogin.Visible = false;
            }
            else
            {
                lnkLogin.Visible = true;
            }
        }
        protected void SetearCarro()
        {
            totalCarro.Text = Convert.ToString(CarritoCompras.Instance.GetSubTotal());
            int contadorCarrito = 0;
            foreach (DetallePedidoMenu item in CarritoCompras.Instance.Items)
            {
                contadorCarrito += item.Cantidad;

            }
            countCarro.Text = contadorCarrito + " en tu carro";
        }
        protected void SetearMenu()
        {
            int idUsuario = (int)Session["IdUsuario"];
            using (OracleDbContext db = new OracleDbContext())
            {
                Usuario usuario = db.Usuario.Include("TipoUsuario").SingleOrDefault(u => u.Id == idUsuario );
                switch (usuario.TipoUsuario.Nombre)
                {
                    case "Administrador":
                        navAdministracion.Visible = true;
                        lblUserName.Text = usuario.Nombre;
                        lnkUsuario.Visible = true;
                        break;
                    case "Cliente":
                        navCliente.Visible = true;
                        lnkUsuario.Visible = true;
                        lblUserName.Text = usuario.Nombre;
                        break;
                    case "EncargadoConvenioEmpresa":
                        navAdministradorEmpresa.Visible = true;
                        lnkUsuario.Visible = true;
                        lblUserName.Text = usuario.Nombre;
                        break;
                    case "EncargadoEmpresaProveedora":
                        navAdministracionProveedor.Visible = true;
                        lnkUsuario.Visible = true;
                        lblUserName.Text = usuario.Nombre;
                        break;
                    case "EncargadoPedidos":
                        lnkUsuario.Visible = true;
                        lblUserName.Text = usuario.Nombre;
                        break;
                    case "Repartidor":
                        lnkUsuario.Visible = true;
                        lblUserName.Text = usuario.Nombre;
                        break;
                }
            }
        }

    }
}
