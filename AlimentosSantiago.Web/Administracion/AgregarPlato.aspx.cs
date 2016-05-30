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
using AlimentosSantiago.Web.WebUtils;
namespace AlimentosSantiago.Web.Administracion
{
    public partial class AgregarPlato : PaginaBase
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
                    plato = IntentarSubirFoto(this.radUpload.UploadedFiles[0],plato);
                    plato.Creado = System.DateTime.Now;
                    plato.Modificado = System.DateTime.Now;
                    db.Plato.Add(plato);
                    db.SaveChanges();
                }
            }
            base.MostrarMensaje("Registro Insertado correctamente");
        }

        private Plato IntentarSubirFoto(UploadedFile uploadFile, Plato plato)
        {
            String _nombreUnicoArchivo = DateTime.Now.Ticks.ToString() + uploadFile.FileName;
            plato.RutaFisicaImagen = WebConfigurationManager.AppSettings["RutaBandeja"] + @"\" + _nombreUnicoArchivo;
            uploadFile.SaveAs(Path.Combine(WebConfigurationManager.AppSettings["RutaBandeja"], _nombreUnicoArchivo));
            plato.RutaVirtualImagen = "../Bandeja/" + _nombreUnicoArchivo;
            return plato;
        }

       
    }
}