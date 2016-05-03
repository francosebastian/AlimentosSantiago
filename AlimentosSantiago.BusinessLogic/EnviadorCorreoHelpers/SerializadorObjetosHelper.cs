using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace AlimentosSantiago.BusinessLogic.EnviadorCorreoHelpers
{
    /// <summary>
    /// Clase SerializadorObjetosHelper, encargada de codificar objetos
    /// </summary>
    public class SerializadorObjetosHelper
    {
        /// <summary>
        /// Método TransformarStringEnTextReader, encargado de codificar una entrada XML
        /// </summary>
        /// <param name="inputXml">Cadena de texto que define código XML</param>
        /// <returns>Retorna un objeto de tipo XmlTextReader</returns>
        public static XmlTextReader TransformarStringEnTextReader(string inputXml)
        {
            if (inputXml == null || inputXml.Equals(""))
            {
                //throw new ArgumentException(string.Format(PermanenteController.m_StringInvalido), "inputXml");
            }
            return new XmlTextReader(new System.IO.StringReader(inputXml));
        }

        /// <summary>
        /// Método TransformarUTF8ByteArrayEnString, encargado de traspasar un arreglo de carácteres unicode a formato de codificación UTF-8
        /// </summary>
        /// <param name="characters">Parámetro que contiene un arreglo de tipo Byte</param>
        /// <returns>Retorna una cadena de texto con la codificación en UTF-8 completa</returns>
        private static String TransformarUtf8ByteArrayEnString(Byte[] characters)
        {
            if (characters == null)
            {
                //throw new ArgumentException(string.Format(PermanenteController.m_ArregloInvalido), "characters");
                return "";
            }
            UTF8Encoding encoding = new UTF8Encoding();
            String constructedString = encoding.GetString(characters);
            return (constructedString);
        }
        /// <summary>
        /// Método genérico SerializarObjeto, encargado de serializar un objeto cualquiera
        /// </summary>
        /// <typeparam name="T">Parámetro genérico T</typeparam>
        /// <param name="pObject">Objeto de tipo Object</param>
        /// <returns>Retorna una cadena de texto definida como código XML del objeto serializado</returns>
        public static String SerializarObjeto<T>(Object pObject)
        {
            try
            {
                if (pObject == null)
                {
                    //throw new ArgumentException(string.Format(PermanenteController.m_ObjetoInvalido), "pObject");
                    return "";
                }
                String xmlizedString = null;
                MemoryStream memoryStream = new MemoryStream();
                XmlSerializer xs = new XmlSerializer(typeof(T));
                XmlTextWriter xmlTextWriter = new XmlTextWriter(memoryStream, Encoding.UTF8);
                xs.Serialize(xmlTextWriter, pObject);
                memoryStream = (MemoryStream)xmlTextWriter.BaseStream;
                xmlizedString = TransformarUtf8ByteArrayEnString(memoryStream.ToArray());
                return xmlizedString;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        /// <summary>
        /// Método genérico SerializarObjetoEnXmlDocument, encargado de serializar un objeto cualquiera
        /// </summary>
        /// <typeparam name="T">Variable genérica T</typeparam>
        /// <param name="o">Objeto de tipo Object</param>
        /// <returns>Retorna un objeto de tipo XmlDocument</returns>
        public static XmlDocument SerializarObjetoEnXmlDocument<T>(Object o)
        {
            if (o == null)
            {
                //throw new ArgumentException(string.Format(PermanenteController.m_ObjetoInvalido), "o");
                return null;
            }
            XmlSerializer s = new XmlSerializer(typeof(T));

            MemoryStream ms = new MemoryStream();
            XmlTextWriter writer = new XmlTextWriter(ms, new UTF8Encoding());
            writer.Formatting = Formatting.Indented;
            writer.IndentChar = ' ';
            writer.Indentation = 5;
            Exception caught = null;

            try
            {
                s.Serialize(writer, o);
                XmlDocument xml = new XmlDocument();
                string xmlString = ASCIIEncoding.UTF8.GetString(ms.ToArray());
                xml.LoadXml(xmlString);
                return xml;
            }
            catch (Exception e)
            {
                caught = e;
            }
            finally
            {
                writer.Close();
                ms.Close();

                if (caught != null)
                    throw caught;
            }
            return null;
        }

        /// <summary>
        /// Método genérico DeserializarXmlEnObjeto, encargado de deserializar un código xml para codificarlo como un objeto genérico
        /// </summary>
        /// <typeparam name="T">Variable genérica T</typeparam>
        /// <param name="inputXml">Cadena de texto con definición de código XML</param>
        /// <returns>Retorna un objeto genérico T</returns>
        public static T DeserializarXmlEnObjeto<T>(string inputXml)
        {
            if (inputXml == null || inputXml.Equals(""))
            {
                //throw new ArgumentException(string.Format(PermanenteController.m_StringInvalido), "inputXml");
            }
            try
            {
                inputXml = inputXml.Remove(0, 1);
                XmlTextReader xmlReader = TransformarStringEnTextReader(inputXml);
                XmlSerializer xs = new XmlSerializer(typeof(T));
                return (T)xs.Deserialize(xmlReader);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método genérico DeserializarXmlEnObjeto, encargado de deserializar un código xml para codificarlo como un objeto genérico
        /// </summary>
        /// <typeparam name="T">Variable genérica T</typeparam>
        /// <param name="inputXml">Cadena de texto con definición de código XML</param>
        /// <param name="reemplazos">Colección de llaves que reprensenta los reemplazos</param>
        /// <returns>Retorna un objeto genérico T</returns>
        public static T DeserializarXmlEnObjeto<T>(string inputXml, Dictionary<String, String> reemplazos)
        {
            if (inputXml == null || inputXml.Equals(""))
            {
                //throw new ArgumentException(string.Format(PermanenteController.m_StringInvalido), "inputXml");
            }
            if (reemplazos == null)
            {
                //throw new ArgumentException(string.Format(PermanenteController.m_DictionaryInvalido), "reemplazos");
            }
            try
            {
                foreach (KeyValuePair<String, String> cadaTokenRemplazo in reemplazos)
                    inputXml = inputXml.Replace(cadaTokenRemplazo.Key, cadaTokenRemplazo.Value);

                inputXml = inputXml.Remove(0, 1);
                XmlTextReader xmlReader = TransformarStringEnTextReader(inputXml);
                XmlSerializer xs = new XmlSerializer(typeof(T));
                return (T)xs.Deserialize(xmlReader);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
