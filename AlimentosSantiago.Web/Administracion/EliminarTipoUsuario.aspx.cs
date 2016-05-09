﻿using AlimentosSantiago.Dao;
using AlimentosSantiago.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlimentosSantiago.Web.Administracion
{
    public partial class EliminarTipoUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // El parámetro del id. debe coincidir con el valor DataKeyNames establecido en el control
        // o ser representado con un atributo proveedor de valor, por ejemplo [QueryString]int id
        public AlimentosSantiago.Dto.TipoUsuario FvTipoUsuario_GetItem([QueryString] int id)
        {
            using (OracleDbContext db = new OracleDbContext())
            {
                return db.TipoUsuario.SingleOrDefault(t => t.Id == id);
            }
        }

        // El nombre de parámetro del id. debe coincidir con el valor DataKeyNames establecido en el control
        public void FvTipoUsuario_DeleteItem(int id)
        {
            using (OracleDbContext db = new OracleDbContext())
            {
                TipoUsuario item = db.TipoUsuario.SingleOrDefault(t => t.Id == id);
                item.Eliminado = true;
                TryUpdateModel(item);
                if (ModelState.IsValid)
                {
                    db.SaveChanges();
                }
            }
        }
    }
}