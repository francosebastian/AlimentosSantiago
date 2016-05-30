using AlimentosSantiago.Dao;
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
    public partial class AgregarCategoriaPlato : PaginaBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public void FvCategoriaPlato_InsertItem()
        {
            CategoriaPlato categoriaPlato = new CategoriaPlato();
            TryUpdateModel(categoriaPlato);
            if (ModelState.IsValid)
            {
                using (OracleDbContext db = new OracleDbContext())
                {
                    categoriaPlato.Creado = System.DateTime.Now;
                    categoriaPlato.Modificado = System.DateTime.Now;
                    db.CategoriaPlato.Add(categoriaPlato);
                    db.SaveChanges();

                }
            }
            base.MostrarMensaje("Registro Insertado correctamente");
          
        }

        protected void wucModalConfirmarAceptarFlujo_Confirmar(object sender, EventArgs e)
        {
        }

        protected void FvCategoriaPlato_ItemInserting(object sender, FormViewInsertEventArgs e)
        {
            wucModalConfirmarAceptarFlujo.Mostrar("¿Está seguro que desea agregar Categoria de plato?", base.RegistrarJqueryBloque);
        }
    }
}