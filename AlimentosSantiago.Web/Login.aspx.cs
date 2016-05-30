using AlimentosSantiago.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AlimentosSantiago.BusinessLogic.Encriptador;
using AlimentosSantiago.Dto;
using static AlimentosSantiago.Dto.Enumeraciones;
using AlimentosSantiago.Web.WebUtils;
namespace AlimentosSantiago.Web
{
    public partial class Login : PaginaBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnEntrar_Click(object sender, EventArgs e)
        {
            Boolean respuesta = ValidarUsuario();
            if (respuesta == true) Response.Redirect("Home.aspx");
        }

        public Boolean ValidarUsuario()
        {
            Usuario usuario = new Usuario();
            EncriptadorSHA256 encriptador = new EncriptadorSHA256();
            using (OracleDbContext db = new OracleDbContext())
            {
                 usuario = db.Usuario.SingleOrDefault(t => t.Email == txtEmail.Text && t.Password == encriptador.SHA256Encrypt(txtPassword.Text));
            }

            if (usuario == null)
            {
                MostrarMensaje("Credenciales no validas");
                return false;
            }
            else if (usuario.Deshabilitado == true)
            {
                MostrarMensaje("Su usuario ha sido desabilitado por favor contacte al administrador");
                return false;
            }
            else
            {
                SetearSession(usuario);
                return true;
            }
        }
        public void SetearSession(Usuario usuario)
        {
            switch (usuario.TipoUsuarioId)
            {
                case (int)TiposUsuario.Administrador:
                    Session["TipoUsuario"] = TiposUsuario.Administrador.ToString();

                break;
                case (int)TiposUsuario.Cliente:
                    Session["TipoUsuario"] = TiposUsuario.Cliente.ToString();
                    Session["IdEmpresa"] = usuario.EmpresaId;

                    break;
                case (int)TiposUsuario.EncargadoConvenioEmpresa:
                    Session["TipoUsuario"] = TiposUsuario.EncargadoConvenioEmpresa.ToString();
                    Session["IdEmpresa"] = usuario.EmpresaId;

                    break;
                case (int)TiposUsuario.EncargadoEmpresaProveedora:
                    Session["TipoUsuario"] = TiposUsuario.EncargadoEmpresaProveedora.ToString();
                    break;
                case (int)TiposUsuario.EncargadoPedidos:
                    Session["TipoUsuario"] = TiposUsuario.EncargadoPedidos.ToString();
                    break;
                case (int)TiposUsuario.Repartidor:
                    Session["TipoUsuario"] = TiposUsuario.Repartidor.ToString();
                    break;
            }
        }
    }
}