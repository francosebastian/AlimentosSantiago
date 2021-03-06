﻿using AlimentosSantiago.Dao;
using AlimentosSantiago.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AlimentosSantiago.Web.WebUtils;
namespace AlimentosSantiago.Web.Administracion
{
    public partial class AgregarTipoPago : PaginaBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void FvTipoPago_InsertItem()
        {
            TipoPago tipoPago = new TipoPago();
            TryUpdateModel(tipoPago);
            if (ModelState.IsValid)
            {
                using (OracleDbContext db = new OracleDbContext())
                {
                    tipoPago.Creado = System.DateTime.Now;
                    tipoPago.Modificado = System.DateTime.Now;
                    db.TipoPago.Add(tipoPago);
                    db.SaveChanges();
                }
            }
            base.MostrarMensaje("Registro Insertado correctamente");
        }
    }
}