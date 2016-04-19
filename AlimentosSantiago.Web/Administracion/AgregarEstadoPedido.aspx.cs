using AlimentosSantiago.Dao;
using AlimentosSantiago.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlimentosSantiago.Web.Administracion
{
    public partial class AgregarEstadoPedido : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void FvEstadoPedido_InsertItem()
        {
            EstadoPedido estadoPedido = new EstadoPedido();
            TryUpdateModel(estadoPedido);
            if (ModelState.IsValid)
            {
                using (OracleDbContext db = new OracleDbContext())
                {
                    estadoPedido.Creado = System.DateTime.Now;
                    estadoPedido.Modificado = System.DateTime.Now;
                    db.EstadoPedido.Add(estadoPedido);
                    db.SaveChanges();
                }
            }
        }
    }
}