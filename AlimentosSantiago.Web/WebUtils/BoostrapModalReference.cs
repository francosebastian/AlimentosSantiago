using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace AlimentosSantiago.Web.WebUtils
{
     /// <summary>
    /// Clase BootstrapModalReference que contiene las referencias modales de bootstrap
    /// </summary>
    public class BootstrapModalReference
    {
        /// <summary>
        /// variables de clase
        /// </summary>
        private string m_Panel = "bdefaultModalPanel";
        /// <summary>
        /// Solo lectura
        /// </summary>
        private readonly string m_Body = "bdefaultModalBody";
        private readonly string m_Label = "bdefaultModalLabel";
        private readonly string m_BotonConfirmar = "bdefaultBtnConfirmar";
        /// <summary>
        /// Propiedades
        /// </summary>
        public bool MostrarBotonConfirmar { get; set; }
        public bool MostrarBotonXCerrar { get; set; }
        public bool MostrarBotonCancelar { get; set; }
        public bool ConfirmacionPersonalizada { get; set; }
        public String UrlConfirmacion { get; set; }
        public String Titulo { get; set; }
        public String Mensaje { get; set; }
        public String TextoBotonConfirmar { get; set; }
        public bool TargetBlank { get; set; }
        /// <summary>
        /// Le da el titulo a las ventanas modales ademas asigna texto al boton confirmar
        /// </summary>
        /// <param name="mensaje"></param>
        /// <returns></returns>
        public static BootstrapModalReference Default(String mensaje)
        {
            mensaje = HttpUtility.HtmlEncode(mensaje.Replace(@"\", "&#92;"));
            BootstrapModalReference resultado = new BootstrapModalReference();
            resultado.MostrarBotonCancelar = true;
            resultado.MostrarBotonConfirmar = true;
            resultado.MostrarBotonCancelar = true;
            resultado.Titulo = "Alimentos Santiago";
            resultado.TextoBotonConfirmar = "Aceptar";
            resultado.Mensaje = mensaje;
            return resultado;
        }
        /// <summary>
        /// Configura el dialog modal
        /// </summary>
        /// <returns></returns>
        public String Configurar()
        {
            string lineDialog = ConfigurarDialog();
            return JQueryBuilderHelper.ObtenerCodigoJquery(lineDialog);
        }
        /// <summary>
        /// Configura el dialog pro medio del id del panel
        /// </summary>
        /// <param name="panelId">id del panel</param>
        /// <returns>Codigo de configuracion</returns>
        public String Configurar(String panelId)
        {
            this.m_Panel = panelId;
            string lineDialog = ConfigurarDialog();
            return JQueryBuilderHelper.ObtenerCodigoJquery(lineDialog);
        }
        /// <summary>
        /// Configura el dialog 
        /// </summary>
        /// <returns>Codigo javascript configurado</returns>
        private string ConfigurarDialog()
        {
            StringBuilder constructorJavaScript = new StringBuilder();
            if (ConfirmacionPersonalizada && !String.IsNullOrEmpty(this.UrlConfirmacion))
            {
                constructorJavaScript.AppendLine(String.Format("$('#{0}').attr('href', '{1}');", this.m_BotonConfirmar, this.UrlConfirmacion));
                if (TargetBlank)
                    constructorJavaScript.AppendLine(String.Format("$('#{0}').attr('target', '{1}');", this.m_BotonConfirmar, "_blank"));
            }
            constructorJavaScript.AppendLine(" $('#" + this.m_BotonConfirmar + "').html('" + JQueryBuilderHelper.LimpiarHtmlParaMensaje(this.TextoBotonConfirmar) + "');");
            constructorJavaScript.AppendLine(" $('#" + this.m_Label + "').html('" + JQueryBuilderHelper.LimpiarHtmlParaMensaje(this.Titulo) + "');");
            constructorJavaScript.AppendLine(" $('#" + this.m_Body + "').html('" + JQueryBuilderHelper.LimpiarHtmlParaMensaje(this.Mensaje) + "');");
            constructorJavaScript.AppendLine(" $('#" + this.m_Panel + "').modal('show');");
            return constructorJavaScript.ToString();
        }
    }
}