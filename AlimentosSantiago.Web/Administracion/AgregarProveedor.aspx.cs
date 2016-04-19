using AlimentosSantiago.Dao;
using AlimentosSantiago.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlimentosSantiago.Web.Administracion
{
    public partial class AgregarProveedor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void FvProveedor_InsertItem()
        {
            Proveedor proveedor = new Proveedor();
            TryUpdateModel(proveedor);
            if (ModelState.IsValid)
            {
                using (OracleDbContext db = new OracleDbContext())
                {
                    proveedor.Creado = System.DateTime.Now;
                    proveedor.Modificado = System.DateTime.Now;
                    db.Proveedor.Add(proveedor);
                    db.SaveChanges();
                }
            }
        }
    }
}