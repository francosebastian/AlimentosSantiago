using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlimentosSantiago.Web.Wuc
{
    public partial class ModalConfirmacion : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public event EventHandler Confirmar;
       
        public void Mostrar(String mensaje, Action<string> registrarJqueryBloque)
        {
            registrarJqueryBloque("$('#" + this.panelConfirmacion.ClientID + "').modal('show');" + " $('#" + this.lblMensaje.ClientID + "').html('" + mensaje + "');");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Confirmar != null)
                Confirmar(sender, e);
        }
    }
}