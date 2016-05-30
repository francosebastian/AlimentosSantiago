using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace AlimentosSantiago.Web.WebUtils
{
    public class PaginaBase : System.Web.UI.Page
    {
        /// <summary>
        /// Muestra mensaje en pantalla
        /// </summary>
        /// <param name="mensaje">Mensaje a desplegar</param>
        protected void MostrarMensaje(string mensaje)
        {
            try
            {
                ScriptManager requestSM = ScriptManager.GetCurrent(this);
                if (requestSM != null && requestSM.IsInAsyncPostBack)
                    ScriptManager.RegisterClientScriptBlock(this, typeof(Page), Guid.NewGuid().ToString(), BootstrapModalReference.Default(mensaje).Configurar(), true);
                else
                    ClientScript.RegisterClientScriptBlock(typeof(Page), Guid.NewGuid().ToString(), BootstrapModalReference.Default(mensaje).Configurar(), true);
            }
            catch (Exception)
            {
            }
        }
        /// <summary>
        /// Registra un bloque de codigo Jquery
        /// </summary>
        /// <param name="funcionJquery">funcion Jquery a utilizar</param>
        protected void RegistrarJqueryBloque(string funcionJquery)
        {
            try
            {
                ScriptManager requestSM = ScriptManager.GetCurrent(this);
                if (requestSM != null && requestSM.IsInAsyncPostBack)
                    ScriptManager.RegisterClientScriptBlock(this, typeof(Page), Guid.NewGuid().ToString(), JQueryBuilderHelper.ConfigurarBloqueJquery(funcionJquery), true);
                else
                    ClientScript.RegisterClientScriptBlock(typeof(Page), Guid.NewGuid().ToString(), JQueryBuilderHelper.ConfigurarBloqueJquery(funcionJquery), true);
            }
            catch (Exception)
            {
            }
        }
    }
}