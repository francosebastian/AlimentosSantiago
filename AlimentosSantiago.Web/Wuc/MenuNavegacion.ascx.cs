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

namespace AlimentosSantiago.Web.Wuc
{
    public partial class MenuNavegacion : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SetearCarro();
            SetearMenu();
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
                String sw = (string)Session["TipoUsuario"];
                switch (sw)
                {
                    case "Administrador":
                        navAdministracion.Visible = true;
                        break;
                    case "Cliente":
                        
                        break;
                    case "EncargadoConvenioEmpresa":
                        navAdministradorEmpresa.Visible = true;
                        break;
                    case "EncargadoEmpresaProveedora":
                        navAdministracionProveedor.Visible = true;
                        break;
                    case "EncargadoPedidos":
                        
                        break;
                    case "Repartidor":
                        
                        break;
                }
            }
        }
    }
