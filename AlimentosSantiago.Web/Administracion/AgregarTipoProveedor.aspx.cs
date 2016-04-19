﻿using AlimentosSantiago.Dao;
using AlimentosSantiago.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlimentosSantiago.Web.Administracion
{
    public partial class AgregarTipoProveedor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void FvTipoProveedor_InsertItem()
        {
            TipoProveedor tipoProveedor = new TipoProveedor();
            TryUpdateModel(tipoProveedor);
            if (ModelState.IsValid)
            {
                using (OracleDbContext db = new OracleDbContext())
                {
                    tipoProveedor.Creado = System.DateTime.Now;
                    tipoProveedor.Modificado = System.DateTime.Now;
                    db.TipoProveedor.Add(tipoProveedor);
                    db.SaveChanges();
                }
            }
        }
    }
}