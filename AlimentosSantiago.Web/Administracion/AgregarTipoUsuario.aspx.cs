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
    public partial class AgregarTipoUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void FvTipoUsuario_InsertItem()
        {
            TipoUsuario tipoUsuario = new TipoUsuario();
            TryUpdateModel(tipoUsuario);
            if (ModelState.IsValid)
            {
                using (OracleDbContext db = new OracleDbContext())
                {
                    tipoUsuario.Creado = System.DateTime.Now;
                    tipoUsuario.Modificado = System.DateTime.Now;
                    db.TipoUsuario.Add(tipoUsuario);
                    db.SaveChanges();
                }
            }
        }
    }
}