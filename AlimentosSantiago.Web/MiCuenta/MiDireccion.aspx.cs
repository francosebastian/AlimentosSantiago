using AlimentosSantiago.Dao;
using AlimentosSantiago.Dto;
using AlimentosSantiago.Web.WebUtils;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlimentosSantiago.Web.MiCuenta
{
    public partial class MiDireccion : PaginaBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void FindCoordinates(object sender, EventArgs e)
        {
            string url = "http://maps.google.com/maps/api/geocode/xml?address=" + tbDireccion.Text + "&sensor=false";
            WebRequest request = WebRequest.Create(url);
            using (WebResponse response = (HttpWebResponse)request.GetResponse())
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                {
                    DataSet dsResult = new DataSet();
                    dsResult.ReadXml(reader);
                    DataTable dtCoordinates = new DataTable();
                    dtCoordinates.Columns.AddRange(new DataColumn[4] { new DataColumn("Id", typeof(int)),
                    new DataColumn("Address", typeof(string)),
                    new DataColumn("Latitude",typeof(string)),
                    new DataColumn("Longitude",typeof(string)) });
                    foreach (DataRow row in dsResult.Tables["result"].Rows)
                    {
                        string geometry_id = dsResult.Tables["geometry"].Select("result_id = " + row["result_id"].ToString())[0]["geometry_id"].ToString();
                        DataRow location = dsResult.Tables["location"].Select("geometry_id = " + geometry_id)[0];
                        dtCoordinates.Rows.Add(row["result_id"], row["formatted_address"], location["lat"], location["lng"]);
                    }
                    if (dtCoordinates.Rows.Count > 0)
                    {
                        pnlMapa.Visible = true;
                        pnlGuardar.Visible = true;

                        hndLatitud.Value = dtCoordinates.Rows[0]["Latitude"].ToString();
                        hndLongitud.Value = dtCoordinates.Rows[0]["Longitude"].ToString();
                        tbDireccion.Text = dtCoordinates.Rows[0]["Address"].ToString();
                        rptMarkers.DataSource = dtCoordinates;
                        rptMarkers.DataBind();
                    }
                }
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DireccionUsuario direccion = new DireccionUsuario();
                direccion.Latitud = hndLatitud.Value;
                direccion.Longitud = hndLongitud.Value;
                direccion.Nombre = txtNombre.Text;
                direccion.Direccion = tbDireccion.Text;
                direccion.UsuarioId = (int)(Session["IdUsuario"]);

                using (OracleDbContext db = new OracleDbContext())
                {
                    db.DireccionUsuario.Add(direccion);
                    db.SaveChanges();
                }
                MostrarMensaje("Direccion Guardada correctamente-");
            }
            catch (Exception)
            {
                MostrarMensaje("Ha ocurrido un error, vuelva a intentarlo mas tarde.");
                throw;
            }
        }
    }
}
