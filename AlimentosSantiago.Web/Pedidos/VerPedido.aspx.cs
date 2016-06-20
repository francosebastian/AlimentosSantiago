﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using AlimentosSantiago.Dao;
using AlimentosSantiago.Dto;
using Telerik.Web.UI;
using static AlimentosSantiago.Dto.Enumeraciones;
using AlimentosSantiago.Web.WebUtils;

namespace AlimentosSantiago.Web.Pedidos
{
    public partial class VerPedido : PaginaBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (OracleDbContext db = new OracleDbContext())
            {
                int idPedido = Convert.ToInt32(Request.QueryString["id"]);

                var pedido = db.PedidoMenu.Include("DetallesPedidoMenu").Include("EstadoPedido").SingleOrDefault(p => p.Id == idPedido);
                if (pedido.EstadoPedidoId == 4)
                    pnlProcesar.Visible = true;
                txtFecha.Text = pedido.Fecha.ToString();
                txtEstadoPedido.Text = pedido.EstadoPedido.Nombre;
                foreach (DetallePedidoMenu item in pedido.DetallesPedidoMenu)
                {
                    Plato plato = db.Plato.FirstOrDefault(p => p.Id == item.PlatoId);
                    item.Nombre = plato.Nombre;
                }
                RadGridPedidos.DataSource = pedido.DetallesPedidoMenu;
                RadGridPedidos.DataBind();
            }
        }

        protected void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            using (OracleDbContext db = new OracleDbContext())
            {
                String mensaje = string.Empty;
                int idPedido = Convert.ToInt32(Request.QueryString["id"]);
                var pedido = db.PedidoMenu.SingleOrDefault(p => p.Id == idPedido);
                if (pedido.EstadoPedidoId == 4)
                {
                    pedido.EstadoPedidoId = (int)EstadosPedido.Finalizado;
                    mensaje = "El pedido fue cambiado a estado finalizado";
                }
                db.Entry(pedido).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                base.MostrarMensaje(mensaje);
            }
        }
    }
}