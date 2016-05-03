using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlimentosSantiago.Web.AdministracionEmpresa
{
    public partial class CargarSaldo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
        }

        protected void btnCargaMasiva_Click(object sender, EventArgs e)
        {

        }
    }
}