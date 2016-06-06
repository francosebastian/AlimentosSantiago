using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlimentosSantiago.Web.AdministracionProveedor
{
    public partial class VerPlatos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            efPlatos.WhereParameters["IdProveedor"].DefaultValue = Session["IdProveedor"].ToString().Trim();
        }
    }
}