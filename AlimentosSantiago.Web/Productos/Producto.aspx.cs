using AlimentosSantiago.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlimentosSantiago.Web.Productos
{
    public partial class Producto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // El parámetro del id. debe coincidir con el valor DataKeyNames establecido en el control
        // o ser representado con un atributo proveedor de valor, por ejemplo [QueryString]int id
        public AlimentosSantiago.Dto.Plato FvProducto_GetItem([QueryString]int id)
        {
            using (OracleDbContext db = new OracleDbContext())
            {
                return db.Plato.SingleOrDefault(t => t.Id == id);
            }
        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}