using AlimentosSantiago.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using AlimentosSantiago.Web.WebUtils;
using AlimentosSantiago.Dto;

namespace AlimentosSantiago.Web.Productos
{
    public partial class Producto : PaginaBase
    {
        public int ViewStateIdProducto { get { return (int)ViewState["ViewStateIdProducto"]; } set { ViewState["ViewStateIdProducto"] = value; } }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // El parámetro del id. debe coincidir con el valor DataKeyNames establecido en el control
        // o ser representado con un atributo proveedor de valor, por ejemplo [QueryString]int id
        public AlimentosSantiago.Dto.Plato FvProducto_GetItem([QueryString]int id)
        {
            using (OracleDbContext db = new OracleDbContext())
            {
                
                Plato plato = db.Plato.SingleOrDefault(t => t.Id == id);
                this.ViewStateIdProducto = plato.Id;
                return plato;
            }
        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            using (OracleDbContext db = new OracleDbContext())
            { 
                Plato plato = db.Plato.SingleOrDefault(t => t.Id == this.ViewStateIdProducto);
                CarritoCompras.Instance.AddItem(plato);

            }
            MostrarMensaje("Producto añadido al carrito de compras");         
        }
    }
}