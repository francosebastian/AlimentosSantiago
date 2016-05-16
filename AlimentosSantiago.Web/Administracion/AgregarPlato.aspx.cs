using AlimentosSantiago.Dao;
using AlimentosSantiago.Dto;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;

namespace AlimentosSantiago.Web.Administracion
{
    public partial class AgregarPlato : System.Web.UI.Page
    {
        private RadAsyncUpload radUpload;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void FvPlato_InsertItem()
        {
            radUpload = (RadAsyncUpload)FvPlato.FindControl("rauFoto");
            Plato plato = new Plato();
            TryUpdateModel(plato);
            if (ModelState.IsValid)
            {
                using (OracleDbContext db = new OracleDbContext())
                {
                    plato.RutaFisicaImagen = IntentarSubirFoto(this.radUpload.UploadedFiles[0]);
                    plato.RutaVirtualImagen = ObtenerRutaRelativa(this.radUpload.UploadedFiles[0]); ;
                    plato.Creado = System.DateTime.Now;
                    plato.Modificado = System.DateTime.Now;
                    db.Plato.Add(plato);
                    db.SaveChanges();
                }
            }
        }

        private String IntentarSubirFoto(UploadedFile uploadFile)
        {
            String _nombreUnicoArchivo = DateTime.Now.Ticks.ToString() + uploadFile.FileName;
            String rutaFisica = WebConfigurationManager.AppSettings["RutaBandeja"] + @"\" + _nombreUnicoArchivo;
            uploadFile.SaveAs(Path.Combine(WebConfigurationManager.AppSettings["RutaBandeja"], _nombreUnicoArchivo));
            return rutaFisica;
        }

        private String ObtenerRutaRelativa(UploadedFile uploadFile)
        {
            String RelativePath = "~/Bandeja/" + uploadFile.FileName;
            return RelativePath;
        }
    }
}