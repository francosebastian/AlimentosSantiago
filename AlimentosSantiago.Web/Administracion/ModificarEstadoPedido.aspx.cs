using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlimentosSantiago.Web.Administracion
{
    public partial class ModificarEstadoPedido : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // El nombre de parámetro del id. debe coincidir con el valor DataKeyNames establecido en el control
        public void FvEstadoPedido_UpdateItem(int id)
        {
            AlimentosSantiago.Dto.EstadoPedido item = null;
            // Cargar el elemento aquí, por ejemplo item = MyDataLayer.Find(id);
            if (item == null)
            {
                // No se encontró el elemento
                ModelState.AddModelError("", String.Format("No se encontró el elemento con id. {0}", id));
                return;
            }
            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                // Guarde los cambios aquí, por ejemplo MyDataLayer.SaveChanges();

            }
        }

        // El parámetro del id. debe coincidir con el valor DataKeyNames establecido en el control
        // o ser representado con un atributo proveedor de valor, por ejemplo [QueryString]int id
        public AlimentosSantiago.Dto.EstadoPedido FvEstadoPedido_GetItem(int id)
        {
            return null;
        }
    }
}