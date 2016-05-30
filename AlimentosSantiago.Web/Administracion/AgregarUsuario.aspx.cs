using AlimentosSantiago.Dao;
using AlimentosSantiago.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AlimentosSantiago.Web.WebUtils;

namespace AlimentosSantiago.Web.Administracion
{
    public partial class AgregarUsuario : PaginaBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void FvUsuario_InsertItem()
        {
            Usuario usuario = new Usuario();
            usuario.Creado = System.DateTime.Now;
            usuario.Modificado = System.DateTime.Now;
            usuario.Password = "1234";
            TryUpdateModel(usuario);
            if (ModelState.IsValid)
            {
                using (OracleDbContext db = new OracleDbContext())
                {
                   
                    db.Usuario.Add(usuario);
                    db.SaveChanges();
                }
            }
            base.MostrarMensaje("Registro Insertado correctamente");

        }
    }
}