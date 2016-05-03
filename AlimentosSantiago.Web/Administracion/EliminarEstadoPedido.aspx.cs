using AlimentosSantiago.Dao;
using AlimentosSantiago.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlimentosSantiago.Web.Administracion
{
    public partial class EliminarEstadoPedido : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // El parámetro del id. debe coincidir con el valor DataKeyNames establecido en el control
        // o ser representado con un atributo proveedor de valor, por ejemplo [QueryString]int id
        public AlimentosSantiago.Dto.EstadoPedido FvEstadoPedido_GetItem(int id)
        {
            using (OracleDbContext db = new OracleDbContext())
            {
                return db.EstadoPedido.SingleOrDefault(t => t.Id == id);
            }
        }

        // El nombre de parámetro del id. debe coincidir con el valor DataKeyNames establecido en el control
        public void FvEstadoPedido_DeleteItem([QueryString]int id)
        {
            using (OracleDbContext db = new OracleDbContext())
            {
                EstadoPedido item = db.EstadoPedido.SingleOrDefault(t => t.Id == id);
                item.Eliminado = true;
                TryUpdateModel(item);
                if (ModelState.IsValid)
                {
                    db.SaveChanges();
                }
            }
        }
    }
}
