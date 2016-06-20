using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Xsl;

namespace AlimentosSantiago.Web.WebUtils
{
    /// <summary>
    /// Clase PlantillaCorreoHelper, dedicado a contener métodos que tienen que ver con el manejo de las plantillas para generar e-mail 
    /// </summary>
    public class PlantillaCorreoHelper
    {
        /// <summary>
        /// Método genérico TransformarPlantillaEnHtml
        /// </summary>
        /// <typeparam name="T">Parámetro genérico T</typeparam>
        /// <param name="fuente">Fuente externa de tipo genérica T</param>
        /// <param name="rutaXslt">Cadena de texto con la ruta del archivo xslt</param>
        /// <returns>Retorna la plantilla del correo en formato HTML mediante una cadena de texto</returns>
        public String TransformarPlantillaEnHtml<T>(T source, String rutaXslt) where T : class
        {
            try
            {
                string input = SerializadorObjetosHelper.SerializarObjeto<T>(source); input = input.Substring(1);
                string output;
                using (StringReader sReader = new StringReader(input))
                using (XmlReader xReader = XmlReader.Create(sReader))
                using (StringWriter sWriter = new StringWriter())
                using (XmlWriter xWriter = XmlWriter.Create(sWriter))
                {
                    XslCompiledTransform xslt = new XslCompiledTransform();
                    xslt.Load(rutaXslt);
                    xslt.Transform(xReader, xWriter);
                    output = sWriter.ToString();
                }
                return output;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}