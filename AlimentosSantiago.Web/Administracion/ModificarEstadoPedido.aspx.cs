using AlimentosSantiago.Dao;
using AlimentosSantiago.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using AlimentosSantiago.Web.WebUtils;
namespace AlimentosSantiago.Web.Administracion
{
    public partial class ModificarEstadoPedido : PaginaBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // El nombre de parámetro del id. debe coincidir con el valor DataKeyNames establecido en el control
        public void FvEstadoPedido_UpdateItem(int id)
        {
            using (OracleDbContext db = new OracleDbContext())
            {
                EstadoPedido item = db.EstadoPedido.SingleOrDefault(t => t.Id == id);
                TryUpdateModel(item);
                if (ModelState.IsValid)
                {
                    db.SaveChanges();
                }
              
            }
            base.MostrarMensaje("Modificado correctamente");
        }

        // El parámetro del id. debe coincidir con el valor DataKeyNames establecido en el control
        // o ser representado con un atributo proveedor de valor, por ejemplo [QueryString]int id
        public AlimentosSantiago.Dto.EstadoPedido FvEstadoPedido_GetItem([QueryString] int id)
        {
            using (OracleDbContext db = new OracleDbContext())
            {
                return db.EstadoPedido.SingleOrDefault(t => t.Id == id);
            }
        }
    }
}