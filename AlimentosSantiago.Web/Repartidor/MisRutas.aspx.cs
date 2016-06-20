using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static AlimentosSantiago.Dto.Enumeraciones;

namespace AlimentosSantiago.Web.Repartidor
{
    public partial class MisRutas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            efPedidos.WhereParameters["IdEstadoPedido"].DefaultValue = ((int)EstadosPedido.EnReparto).ToString();
            efPedidos.WhereParameters["IdRepartidor"].DefaultValue = (Session["IdUsuario"]).ToString();
        }
    }
}