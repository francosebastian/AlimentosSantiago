using AlimentosSantiago.Dao;
using AlimentosSantiago.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AlimentosSantiago.Web.WebUtils;
using AlimentosSantiago.BusinessLogic;
using AlimentosSantiago.BusinessLogic.Encriptador;
namespace AlimentosSantiago.Web.Administracion
{
    public partial class AgregarUsuario : PaginaBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void FvUsuario_InsertItem()
        {
            EncriptadorSHA256 encriptador = new EncriptadorSHA256();
            Usuario usuario = new Usuario();
            usuario.Creado = System.DateTime.Now;
            usuario.Modificado = System.DateTime.Now;
            usuario.Password = encriptador.SHA256Encrypt("1234");
            TryUpdateModel(usuario);
            if (ModelState.IsValid)
            {
                using (OracleDbContext db = new OracleDbContext())
                {
                   
                    db.Usuario.Add(usuario);
                    db.SaveChanges();
                }
            }
        }

        protected void FvUsuario_ItemInserting(object sender, FormViewInsertEventArgs e)
        {
            TextBox txtEmail = (TextBox)FvUsuario.FindControl("txtEmail");
            TextBox txtEmail2 = (TextBox)FvUsuario.FindControl("txtEmail2");

            if (!txtEmail.Text.Equals(txtEmail2.Text))
            {
                e.Cancel = true;
                base.MostrarMensaje("El correo electronico debe coincidir");
            }
            if (ValidadorCorreo.ValidarCorreo(txtEmail.Text))
            {
                e.Cancel = true;
                base.MostrarMensaje("El correo electronico ya posee un usuario registrado");
            }
        }
    }
}