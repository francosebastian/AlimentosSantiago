using AlimentosSantiago.Dto;
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
using AlimentosSantiago.Web.WebUtils;
using AlimentosSantiago.Dao;
namespace AlimentosSantiago.Web.MiCuenta
{
    public partial class MisDirecciones : PaginaBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            efDirecciones.WhereParameters["IdUsuario"].DefaultValue = Session["IdUsuario"].ToString().Trim();
        }

      
    }
}