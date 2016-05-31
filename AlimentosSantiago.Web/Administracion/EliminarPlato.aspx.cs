using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AlimentosSantiago.Web.WebUtils;
using AlimentosSantiago.Dao;
using AlimentosSantiago.Dto;

namespace AlimentosSantiago.Web.Administracion
{
    public partial class EliminarPlato : PaginaBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //cambiar delate
          public void FvPlato_DeleteItem(int id)
        {
            using (OracleDbContext db = new OracleDbContext())
            {
                Plato item = db.Plato.SingleOrDefault(t => t.Id == id);
                item.Eliminado = true;
                TryUpdateModel(item);
                if (ModelState.IsValid)
                {
                    db.SaveChanges();
                }
           
            }
            base.MostrarMensaje("Eliminado  correctamente");
        }
    }
}