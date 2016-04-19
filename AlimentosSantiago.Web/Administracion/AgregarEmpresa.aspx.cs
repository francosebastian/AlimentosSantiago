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
    public partial class AgregarEmpresa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void FvEmpresa_InsertItem()
        {
            Empresa empresa = new Empresa();
            TryUpdateModel(empresa);
            if (ModelState.IsValid)
            {
                using (OracleDbContext db = new OracleDbContext())
                {
                    empresa.Creado = System.DateTime.Now;
                    empresa.Modificado = System.DateTime.Now;
                    db.Empresa.Add(empresa);
                    db.SaveChanges();
                }
            }
        }
    }
}