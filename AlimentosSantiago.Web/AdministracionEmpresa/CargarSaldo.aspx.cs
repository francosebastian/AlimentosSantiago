using AlimentosSantiago.Dao;
using AlimentosSantiago.Dto;
using static AlimentosSantiago.Dto.Enumeraciones;
using AlimentosSantiago.Web.WebUtils;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlimentosSantiago.Web.AdministracionEmpresa
{
    public partial class CargarSaldo : PaginaBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
        }

        protected void btnCargaMasiva_Click(object sender, EventArgs e)
        {
            try
            {
                if (AsyncUpload1.UploadedFiles.Count > 0)
                {
                    Telerik.Web.UI.UploadedFile archivo = AsyncUpload1.UploadedFiles[0];
                    String path = Server.MapPath("~/Bandeja/");
                    var epochDate = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                    long fechaUnix = Convert.ToInt64((DateTime.Now - epochDate).TotalSeconds);
                    String fileName = String.Format("{0}_{1}_{2}{3}", "Carga_Masiva", Session["IdUsuario"], fechaUnix.ToString(), archivo.GetExtension());
                    archivo.SaveAs(Path.Combine(path, fileName));
                    String pathCompleto = (Path.Combine(path, fileName));
                    List<CargaMasiva> listaCargaMasiva = AbrirExcel(pathCompleto);
                    List<LogSaldo> listaParaCargar = GenerarNotaVentaParaClienteWeb(listaCargaMasiva);
                    using (OracleDbContext db = new OracleDbContext())
                    {
                        foreach (LogSaldo item in listaParaCargar)
                        {
                            
                        }
                    }
                    base.MostrarMensaje("Registros cargados correctamente");
                }
                else
                {
                    base.MostrarMensaje("Debe seleccionar un archivo para cargar");

                }
            }
            catch (Exception ex)
            {
                String exep = ex.Message.ToString();
                exep = exep.Replace("Value cannot be null.\r\nParameter name: ", "Ha ocurrido un problema.\nUn valor dentro de ");
                String mensaje = String.Format("{0}", exep);
                base.MostrarMensaje(mensaje);
            }
        }

        /// <summary>
        /// Metodo que abre el excel y lo retorna en una lista para cargar registros de forma masiva
        /// </summary>
        /// <param name="pathArchivo">Path del archivo</param>
        /// <returns>Lista de archivos para carga masiva</returns>
        protected List<CargaMasiva> AbrirExcel(String pathArchivo)
        {
            try
            {
                List<CargaMasiva> cargaMasivas = new List<CargaMasiva>();
                ExcelReader excelReader = new ExcelReader(pathArchivo, true);
                DataTable data = excelReader.ObtenerDataTable("Hoja1");
                foreach (DataRow row in data.Rows)
                {
                    CargaMasiva cargaMasiva = new CargaMasiva();
                    foreach (DataColumn col in data.Columns)
                    {
                        switch (col.Ordinal + 1)
                        {
                            case (int)ColumnasExcel.Correo:
                                cargaMasiva.Correo = Convert.ToString(data.Rows[data.Rows.IndexOf(row)][col.Ordinal]);
                                break;
                            case (int)ColumnasExcel.Saldo:
                                cargaMasiva.Saldo = Convert.ToInt16(data.Rows[data.Rows.IndexOf(row)][col.Ordinal]);
                                break;
                        }
                    }
                    cargaMasivas.Add(cargaMasiva);
                }
                cargaMasivas.OrderByDescending(x => x.Correo).ToList();
                excelReader.Dispose();
                return cargaMasivas;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
   
        /// <summary>
        /// Metodo recibe una lista de cargas masivas donde se ordena para ser cargado como nota venta de net vitamina
        /// </summary>
        /// <param name="cargaMasiva">Lista de registros para carga masiva</param>
        /// <returns>Lista de notas venta con detalles ordenados</returns>
        protected List<LogSaldo> GenerarNotaVentaParaClienteWeb(List<CargaMasiva> cargaMasiva)
        {
            try
            {
                List<LogSaldo> logSaldo = new List<LogSaldo>();
                foreach (CargaMasiva cadaItem in cargaMasiva)
                {
                    if (logSaldo.Any(x => x.Usuario.Email == cadaItem.Correo))
                    {
                        var nvCorreo = logSaldo.Single(x => x.Usuario.Email == cadaItem.Correo);
                        nvCorreo.SaldoCargado = nvCorreo.SaldoCargado + cadaItem.Saldo;
                    }
                    else
                    {
                        logSaldo.Add(new LogSaldo
                        {
                            Log = "",
                            Creado = System.DateTime.Now,
                            Modificado = System.DateTime.Now,
                            SaldoCargado = cadaItem.Saldo,
                            Deshabilitado = false,
                            Eliminado = false,
                            UsuarioId = 1,
                        });
                    }
                }
                return logSaldo;
            }
            catch (Exception ex)
            {
                MostrarMensaje("Por favor compruebe que los registros en la hoja Excel");
                throw ex;
            }
        }
    }
}