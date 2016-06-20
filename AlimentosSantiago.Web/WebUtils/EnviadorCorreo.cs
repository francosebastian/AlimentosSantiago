using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace AlimentosSantiago.Web.WebUtils
{
    public class EnviadorCorreo
    {
        public List<String> Destinatarios { get; set; }
        public List<String> DestinatariosParaConCopia { get; set; }
        public List<String> DestinatariosParaCopiaOculta { get; set; }
        public List<String> RutasArchivosAdjuntos { get; set; }
        public String Mensaje { get; set; }
        public String TituloCorreo { get; set; }
        public String ResultadoEnvio { get; set; }
        public MailMessage Correo { get; set; }
        public EnviadorCorreo()
        {
            this.RutasArchivosAdjuntos = new List<string>();
            this.Destinatarios = new List<string>();
            this.DestinatariosParaConCopia = new List<string>();
            this.DestinatariosParaCopiaOculta = new List<string>();
            this.Correo = new MailMessage();
        }

        public bool IntentarEnviar()
        {
            if (String.IsNullOrEmpty(this.Mensaje)) throw new ActionableException("Debe especificar el mensaje del correo.");
            if (String.IsNullOrEmpty(this.TituloCorreo)) throw new ActionableException("Debe especificar el título del correo.");
            if (Destinatarios.Count == 0) throw new ActionableException("Debe especificar al menos un destinatario para el correo");
            try
            {
                SmtpClient smtp = new SmtpClient(this.SmtpServer());
                //configuracion gmail
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential("alimentossantiago2016@gmail.com", "alimentossantiago");
                verificarDestinatarios();
                this.Destinatarios.Where(t => !String.IsNullOrEmpty(t)).ToList().ForEach(t => Correo.To.Add(new MailAddress(t)));
                if (this.DestinatariosParaConCopia != null)
                    this.DestinatariosParaConCopia.Where(t => !String.IsNullOrEmpty(t)).ToList().ForEach(t => Correo.CC.Add(new MailAddress(t)));
                if (DestinatariosParaCopiaOculta != null)
                    this.DestinatariosParaCopiaOculta.Where(t => !String.IsNullOrEmpty(t)).ToList().ForEach(t => Correo.Bcc.Add(new MailAddress(t)));

                Correo.From = new MailAddress(this.Casilla(), this.NombreCasilla());
                Correo.Subject = this.TituloCorreo;

                if (this.CuerpoConHtmlComleto)
                    configurarMensajeLimpio();
                else
                    configurarMensajeInyectarTagsHtml();

                Correo.Body = this.Mensaje;
                Correo.BodyEncoding = System.Text.Encoding.UTF8;
                Correo.IsBodyHtml = true;

                Correo.DeliveryNotificationOptions = DeliveryNotificationOptions.OnSuccess | DeliveryNotificationOptions.OnFailure | DeliveryNotificationOptions.Delay;
                Correo.Headers.Add("Disposition-Notification-To", this.Casilla());

                foreach (String cadaArchivo in this.RutasArchivosAdjuntos)
                {
                    if (File.Exists(cadaArchivo)) Correo.Attachments.Add(new Attachment(cadaArchivo));
                    else throw new ActionableException("No se ha podido encontrar el archivo especificado para el envío : " + cadaArchivo);
                }
                smtp.Send(Correo);
                return true;
            }
            catch (Exception ex)
            {
                Dictionary<String, Object> parameters = new Dictionary<string, object>();
                parameters.Add("correoDestino", Destinatarios.First());
                parameters.Add("titulo", this.TituloCorreo);
                //LoggerManager.LogError("error al enviar el correo", TiposCategoryLog.LogWEB, ex, parameters);
                this.ResultadoEnvio = ex.Message;
                return false;
            }
        }

        private string innerEx(Exception ex)
        {
            if (ex.InnerException != null)
                return ex.InnerException.ToString();
            else
                return String.Empty;
        }

        private void verificarDestinatarios()
        {
            if (!"PRODUCCION".Equals(ConfigurationManager.AppSettings["ambiente"] as String, StringComparison.OrdinalIgnoreCase))
            {
                List<String> correos = ConfigurationManager.AppSettings["correos_permitidos_prueba"].Split(';').ToList();
                validarLista(correos, this.Destinatarios);
                validarLista(correos, this.DestinatariosParaConCopia);
                validarLista(correos, this.DestinatariosParaCopiaOculta);
            }
        }

        private void validarLista(List<String> correos, List<String> listaDestinatarios)
        {
            if (listaDestinatarios == null || listaDestinatarios.Count < 1) return;
            for (int i = 0; i < listaDestinatarios.Count; i++)
            {
                String cadaCorreo = listaDestinatarios[i];
                if (!correos.Any(t => t.ToUpper() == cadaCorreo.ToUpper()))
                    listaDestinatarios[i] = ConfigurationManager.AppSettings["correo_por_defecto"];
            }
        }

        private void configurarMensajeInyectarTagsHtml()
        {
            string bodyHtml = "<!DOCTYPE html PUBLIC '-//W3C//DTD XHTML 1.0 Transitional//EN' 'http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd'>";
            bodyHtml += "<html><head><meta http-equiv=Content-Type content=\"text/html; charset=iso-8859-1\">";
            bodyHtml += "</head><body> <div><font size=\"2\" face=\"arial\">" + this.Mensaje;
            bodyHtml += "</font></div></body></html>";
            this.Mensaje = bodyHtml;
        }

        private void configurarMensajeLimpio()
        {
            string bodyHtml = "<!DOCTYPE html PUBLIC '-//W3C//DTD XHTML 1.0 Transitional//EN' 'http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd'>";
            bodyHtml += this.Mensaje;
            this.Mensaje = bodyHtml;
        }


        public String CasillaPersonalizada { get; set; }
        public String NombreCasillaPersonalizada { get; set; }
        public bool CuerpoConHtmlComleto { get; set; }


        private string Casilla()
        {
            if (String.IsNullOrEmpty(this.CasillaPersonalizada))
                return ConfigurationManager.AppSettings["Casilla"];
            else
                return this.CasillaPersonalizada;
        }

        private string NombreCasilla()
        {
            if (String.IsNullOrEmpty(this.NombreCasillaPersonalizada))
                return ConfigurationManager.AppSettings["NombreCasilla"];
            else
                return this.NombreCasillaPersonalizada;
        }

        private string SmtpServer()
        {
            return ConfigurationManager.AppSettings["smtpServer"];
        }
    }
}