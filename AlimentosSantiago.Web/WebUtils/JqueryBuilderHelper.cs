using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace AlimentosSantiago.Web.WebUtils
{
    /// <summary>
    /// Clase encargada de manejar codificacion JQUERY
    /// </summary>
    public class JQueryBuilderHelper
    {
        /// <summary>
        /// Obtiene codigo Jquery a ejecutar en conjunto con el javascript 
        /// </summary>
        /// <param name="javaScriptCodigo"></param>
        /// <returns>Codigo jquery con el javascript</returns>
        public static string ObtenerCodigoJquery(string javaScriptCodigo)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("$(document).ready(function() {");
            stringBuilder.AppendLine(javaScriptCodigo);
            stringBuilder.AppendLine(" });");
            return stringBuilder.ToString();
        }
        /// <summary>
        /// Condigura dialogo para mensaje
        /// </summary>
        /// <param name="mensaje">Mensaje</param>
        /// <returns>retorna codigo de panel con mensaje</returns>
        public static string ConfigurarDialogoMensaje(string mensaje)
        {
            string codigo = " $('#ctl00_ContentCotizarBody_panelmensaje').html('" + LimpiarHtmlParaMensaje(mensaje) + "').dialog('open');";
            return codigo;
        }

        /// <summary>
        /// Limpia codigo html el mensaje
        /// </summary>
        /// <param name="mensaje">mensaje con codigo HTML</param>
        /// <returns>mensaje sin codigo HTML</returns>
        public static string LimpiarHtmlParaMensaje(string mensaje)
        {
            mensaje = mensaje.Replace(@"\", "&#92;");
            mensaje = HttpUtility.HtmlDecode(mensaje);
            System.Text.RegularExpressions.Regex regexBR = new System.Text.RegularExpressions.Regex(@"\r");
            mensaje = regexBR.Replace(mensaje, "<br />");
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"(\r\n|\r|\n)+");
            mensaje = regex.Replace(mensaje, "<br />");
            return mensaje;
        }
        /// <summary>
        /// Configura un bloque de codigo JQUERY
        /// </summary>
        /// <param name="jqueryFunction">funcion Jquery en String</param>
        /// <returns>Codigo Jquery en String</returns>
        public static string ConfigurarBloqueJquery(String jqueryFunction)
        {
            return ObtenerCodigoJquery(jqueryFunction);
        }
    }
}