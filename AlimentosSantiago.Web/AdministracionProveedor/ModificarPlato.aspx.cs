using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using AlimentosSantiago.Dao;
using AlimentosSantiago.Dto;
using AlimentosSantiago.Web.WebUtils;

namespace AlimentosSantiago.Web.AdministracionProveedor
{
    public partial class ModificarPlato : PaginaBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // El parámetro del id. debe coincidir con el valor DataKeyNames establecido en el control
        // o ser representado con un atributo proveedor de valor, por ejemplo [QueryString]int id
        public AlimentosSantiago.Dto.Plato FvPlato_GetItem([QueryString]int id)
        {
            using(OracleDbContext db= new OracleDbContext())
            {
                return db.Plato.FirstOrDefault(p => p.Id == id);
            }
        }

        // El nombre de parámetro del id. debe coincidir con el valor DataKeyNames establecido en el control
        public void FvPlato_UpdateItem(int id)
        {
            using (OracleDbContext db = new OracleDbContext())
            {
                Plato item = db.Plato.SingleOrDefault(t => t.Id == id);
                TryUpdateModel(item);
                if (ModelState.IsValid)
                {
                    db.SaveChanges();
                }
            }
            base.MostrarMensaje("Modificado correctamente");
        }
    }
}