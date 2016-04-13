using AlimentosSantiago.Dao;
using AlimentosSantiago.Dto;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlimentosSantiago.Web.Administracion
{
    public partial class EliminarUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // El nombre de parámetro del id. debe coincidir con el valor DataKeyNames establecido en el control
        public void FvUsuario_DeleteItem(int id)
        {
            using (OracleDbContext db = new OracleDbContext())
            {
                var item = new Usuario {Id = id };
                db.Entry(item).State = EntityState.Deleted;
                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    ModelState.AddModelError("",
                      String.Format("Item with id {0} no longer exists in the database.", id));
                }
            }
        }

        // El parámetro del id. debe coincidir con el valor DataKeyNames establecido en el control
        // o ser representado con un atributo proveedor de valor, por ejemplo [QueryString]int id
        public AlimentosSantiago.Dto.Usuario FvUsuario_GetItem([QueryString]int id)
        {
            using (OracleDbContext db = new OracleDbContext())
            {
                Usuario usuario = db.Usuario.SingleOrDefault(t => t.Id == id);
                return usuario;
            }
        }
    }
}