using AlimentosSantiago.Dao;
using AlimentosSantiago.Dto;
using AlimentosSantiago.Web.WebUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AlimentosSantiago.BusinessLogic.Encriptador;
namespace AlimentosSantiago.Web.MiCuenta
{
    public partial class CambiarPassword : PaginaBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCambiarPassword_Click(object sender, EventArgs e)
        {
            int idUsuario = Convert.ToInt32(Session["IdUsuario"]);
            if (Validar())
            {
                using (OracleDbContext db= new OracleDbContext())
                {
                    Usuario usuario = db.Usuario.SingleOrDefault(u => u.Id == idUsuario );
                    EncriptadorSHA256 encriptador = new EncriptadorSHA256();
                    String passwordAntiguo = encriptador.SHA256Encrypt(txtPasswordActual.Text);
                    if (passwordAntiguo.Equals(usuario.Password))
                    {
                        usuario.Password = encriptador.SHA256Encrypt(txtPasswordNuevo.Text);
                        db.Entry(usuario).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        MostrarMensaje("Su password ha sido actualizado correctamente");
                    }
                    else
                    {
                        MostrarMensaje("El password ingresado no corresponde al actual");
                    }
                }
            }
        }
        private Boolean Validar()
        {
            if (!txtPasswordNuevo.Text.Equals(txtpasswordNuevo2.Text))
            {
                MostrarMensaje("Los password deben coincidir");
                return false;
            }
            return true;
        }
    }
}