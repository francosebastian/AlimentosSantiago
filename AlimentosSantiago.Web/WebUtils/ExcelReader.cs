using Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;

namespace AlimentosSantiago.Web.WebUtils
{
    public class ExcelReader : IDisposable
    {
        private readonly string _rutaArchivo;
        private FileStream _stream;
        private IExcelDataReader _excelReader;

        public ExcelReader(string rutaArchivo, bool esPrimeraFilaNombreColumnas = true)
        {
            this._rutaArchivo = rutaArchivo;
            this._stream = File.Open(this._rutaArchivo, FileMode.Open, FileAccess.Read);

            if (!(Path.GetExtension(this._rutaArchivo) ?? string.Empty).Equals(".xlsx"))
            {
                this._excelReader = ExcelReaderFactory.CreateBinaryReader(this._stream);
            }
            else
            {
                this._excelReader = ExcelReaderFactory.CreateOpenXmlReader(this._stream);
            }

            this._excelReader.IsFirstRowAsColumnNames = esPrimeraFilaNombreColumnas;
        }

        public ExcelReader(string rutaArchivo, eTipoPlanillaExcel tipoPlanillaExcel, bool esPrimeraFilaNombreColumnas = true)
        {
            this._rutaArchivo = rutaArchivo;
            this._stream = File.Open(this._rutaArchivo, FileMode.Open, FileAccess.Read);

            if (!tipoPlanillaExcel.Equals(eTipoPlanillaExcel.EXCEL_2007))
            {
                this._excelReader = ExcelReaderFactory.CreateBinaryReader(this._stream);
            }
            else
            {
                this._excelReader = ExcelReaderFactory.CreateBinaryReader(this._stream);
            }

            this._excelReader.IsFirstRowAsColumnNames = esPrimeraFilaNombreColumnas;
        }

        public void Dispose()
        {
            this._excelReader.Close();
        }

        public DataSet ObtenerDataSet()
        {
            return this._excelReader.AsDataSet();
        }

        public DataTable ObtenerDataTable(int index)
        {
            DataSet dataSet = this.ObtenerDataSet();

            if (dataSet.Tables.Count <= index)
            {
                return new DataTable();
            }

            return dataSet.Tables[index];
        }

        public DataTable ObtenerDataTable(string nombre)
        {
            DataSet dataSet = this.ObtenerDataSet();

            if (!dataSet.Tables.Contains(nombre))
            {
                return new DataTable();
            }

            return dataSet.Tables[nombre];
        }
    }
}