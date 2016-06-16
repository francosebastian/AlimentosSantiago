using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace AlimentosSantiago.Web.WebUtils
{
    /// <summary>
    /// Clase EnviadorCorreo, encargada de contener lo necesario para el envio de correos
    /// </summary>
    public class EnviadorCorreo
    {
        /// <summary>
        /// Atributos de la clase 
        /// </summary>
        public List<String> Destinatarios { get; set; }
        public List<String> DestinatariosParaConCopia { get; set; }
        public List<String> DestinatariosParaCopiaOculta { get; set; }
        public List<String> RutasArchiosAdjuntos { get; set; }
        public String Mensaje { get; set; }
        public String TituloCorreo { get; set; }
        public String ResultadoEnvio { get; set; }
        public MailMessage Correo { get; set; }
        public String CasillaPersonalizada { get; set; }
        public String NombreCasillaPersonalizada { get; set; }
        public bool CuerpoConHtmlCompleto { get; set; }
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public EnviadorCorreo()
        {
            this.RutasArchiosAdjuntos = new List<string>();
            this.Destinatarios = new List<string>();
            this.DestinatariosParaConCopia = new List<string>();
            this.DestinatariosParaCopiaOculta = new List<string>();
            this.Correo = new MailMessage();
        }

        /// <summary>
        /// Método IntentarEnviar, el cual busca lograr un envio de correo exitoso
        /// </summary>
        /// <returns>Retorna un bool true si es un envio exitoso o un false si no fue realizado</returns>
        public bool IntentarEnviar()
        {
            //Validaciones en caso de que falte algo
            if (String.IsNullOrEmpty(this.Mensaje)) throw new ArgumentException("Debe especificar el mensaje del correo.");
            if (String.IsNullOrEmpty(this.TituloCorreo)) throw new ArgumentException("Debe especificar el título del correo.");
            if (Destinatarios.Count == 0) throw new ArgumentException("Debe especificar al menos un destinatario para el correo");
            try
            {
                //Obtiene el Smtp del servidor de correo
                SmtpClient smtp = new SmtpClient(this.SmtpServer(), this.PuertoSmtp());
                //Por cada destinatario lo agrega a los destinatarios, CC y CCO
                this.Destinatarios.Where(t => !String.IsNullOrEmpty(t)).ToList().ForEach(t => this.Correo.To.Add(new MailAddress(t)));

                this.DestinatariosParaConCopia.Where(t => !String.IsNullOrEmpty(t)).ToList().ForEach(t => this.Correo.CC.Add(new MailAddress(t)));

                this.DestinatariosParaCopiaOculta.Where(t => !String.IsNullOrEmpty(t)).ToList().ForEach(t => this.Correo.Bcc.Add(new MailAddress(t)));
                //Recupera el correo del remitente
                this.Correo.From = new MailAddress(this.Casilla(), this.NombreCasilla());
                //Setea el asunto del correo
                this.Correo.Subject = this.TituloCorreo;
                //Si viene con html configura el mensaje limpio si no le agrega los tags HTML
                if (this.CuerpoConHtmlCompleto)
                    ConfigurarMensajeLimpio();
                else
                    ConfigurarMensajeInyectarTagsHtml();

                this.Correo.Body = this.Mensaje;
                this.Correo.BodyEncoding = System.Text.Encoding.UTF8;
                this.Correo.IsBodyHtml = true;

                this.Correo.DeliveryNotificationOptions = DeliveryNotificationOptions.OnSuccess | DeliveryNotificationOptions.OnFailure | DeliveryNotificationOptions.Delay;
                this.Correo.Headers.Add("Disposition-Notification-To", this.Casilla());

                foreach (String cadaArchivo in this.RutasArchiosAdjuntos)
                {
                    if (File.Exists(cadaArchivo)) Correo.Attachments.Add(new Attachment(cadaArchivo));
                    else throw new ArgumentException("No se ha podido encontrar el archivo especificado para el envío : " + cadaArchivo);
                }
                smtp.Send(Correo);
                return true;
            }
            catch (Exception ex)
            {
                Dictionary<String, Object> parameters = new Dictionary<string, object>();
                parameters.Add("correoDestino", Destinatarios.First());
                parameters.Add("titulo", this.TituloCorreo);
                this.ResultadoEnvio = ex.ToString();
                return false;
            }
        }
        /// <summary>
        /// Método configurarMensajeInyectarTagsHtml, encargado de generar el mensaje del correo concatenando codigo HTML
        /// </summary>
        private void ConfigurarMensajeInyectarTagsHtml()
        {
            string bodyHtml = "<!DOCTYPE html PUBLIC '-//W3C//DTD XHTML 1.0 Transitional//EN' 'http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd'>";
            bodyHtml += "<html><head><meta http-equiv=Content-Type content=\"text/html; charset=iso-8859-1\">";
            bodyHtml += "</head><body> <div><font size=\"2\" face=\"arial\">" + this.Mensaje;
            bodyHtml += "</font></div></body></html>";
            this.Mensaje = bodyHtml;
        }

        /// <summary>
        /// Método configurarMensajeLimpio, encargado de generar el mensaje de correo del correo concatenando codigo HTML directo
        /// </summary>
        private void ConfigurarMensajeLimpio()
        {
            string bodyHtml = "<!DOCTYPE html PUBLIC '-//W3C//DTD XHTML 1.0 Transitional//EN' 'http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd'>";
            bodyHtml += this.Mensaje;
            this.Mensaje = bodyHtml;
        }

        /// <summary>
        /// Método Casilla, encargado de configurar la casilla de correos
        /// </summary>
        /// <returns>Retorna una cadena de texto definiendo la casilla</returns>
        private string Casilla()
        {
            if (String.IsNullOrEmpty(this.CasillaPersonalizada))
                //return VDK.System.Configuration.ConfigHelper.ObtenerKeyWebConfig("Casilla", true);
                return "";
            else
                return this.CasillaPersonalizada;
        }
        /// <summary>
        /// Método NombreCasilla, encargado de configurar el nombre de la casilla que se utilizará
        /// </summary>
        /// <returns>Retorna una cadena de texto definiendo el nombre de la casilla</returns>
        private string NombreCasilla()
        {
            if (String.IsNullOrEmpty(this.NombreCasillaPersonalizada))
                //return VDK.System.Configuration.ConfigHelper.ObtenerKeyWebConfig("NombreCasilla", true);
                return "";
            else
                return this.NombreCasillaPersonalizada;
        }
        /// <summary>
        /// Método SmtpServer, encargado de obtener la configuración del servidor SMTP
        /// </summary>
        /// <returns>Retorna una cadena de texto definiendo la llave de acceso al SMTP definido</returns>
        private string SmtpServer()
        {
            //return VDK.System.Configuration.ConfigHelper.ObtenerKeyWebConfig("smtpServer", true);
            return "";
        }
        /// <summary>
        /// Método PuertoSmtp, encargado de obtener la configuración del puerto SMTP
        /// </summary>
        /// <returns>Retorna una cadena de texto definiendo la llave de acceso al puerto definido</returns>
        private int PuertoSmtp()
        {
            //return Convert.ToInt32(VDK.System.Configuration.ConfigHelper.ObtenerKeyWebConfig("smtpPort", true));
            return 0;
        }
    }
}