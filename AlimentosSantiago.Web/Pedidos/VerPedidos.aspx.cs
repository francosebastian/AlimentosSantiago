using AlimentosSantiago.Dto;
using AlimentosSantiago.BusinessLogic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;

namespace AlimentosSantiago.Web.Pedidos
{
    public partial class VerPedidos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            efPedidos.WhereParameters["IdCliente"].DefaultValue = Session["IdUsuario"].ToString().Trim();
        }

     
    }
}