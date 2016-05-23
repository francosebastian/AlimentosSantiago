using AlimentosSantiago.Dao;
using AlimentosSantiago.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AlimentosSantiago.BusinessLogic.Encriptador;
using static AlimentosSantiago.Dto.Enumeraciones;

namespace AlimentosSantiago.Web
{
    public partial class RegistroCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void FvUsuario_ItemInserting(object sender, FormViewInsertEventArgs e)
        {
            TextBox txtPassword = (TextBox)FvUsuario.FindControl("txtPassword");
            TextBox txtPassword2 = (TextBox)FvUsuario.FindControl("txtPassword2");
            TextBox txtEmail = (TextBox)FvUsuario.FindControl("txtEmail");
            TextBox txtEmail2 = (TextBox)FvUsuario.FindControl("txtEmail2");
      
            if (!txtPassword.Text.Equals(txtPassword2.Text))
            {
                e.Cancel = true;
                //ACA DEBERIA MANDAR UN MENSAJE
            }

            if (!txtEmail.Text.Equals(txtEmail2.Text))
            {
                e.Cancel = true;
                //ACA DEBERIA MANDAR UN MENSAJE
            }
        }

        public void FvUsuario_InsertItem()
        {
            TextBox txtPassword = (TextBox)FvUsuario.FindControl("txtPassword");
            EncriptadorSHA256 encriptador = new EncriptadorSHA256();

            Usuario usuario = new Usuario();
            usuario.Creado = System.DateTime.Now;
            usuario.Modificado = System.DateTime.Now;
            TryUpdateModel(usuario);
            usuario.Password = encriptador.SHA256Encrypt(txtPassword.Text);
            usuario.TipoUsuarioId = (int) TiposUsuario.Cliente;
            if (ModelState.IsValid)
            {
                using (OracleDbContext db = new OracleDbContext())
                {

                    db.Usuario.Add(usuario);
                    db.SaveChanges();
                }
            }
        }
    }
}