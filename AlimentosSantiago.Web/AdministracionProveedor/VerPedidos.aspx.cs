using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static AlimentosSantiago.Dto.Enumeraciones;

namespace AlimentosSantiago.Web.AdministracionProveedor
{
    public partial class VerPedidos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            efPedidos.WhereParameters["IdEstadoPedido"].DefaultValue = ((int)EstadosPedido.Recibido).ToString();
        }
    }
}