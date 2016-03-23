using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentosSantiago.Dto
{
    public class TipoProveedor : LayerSuperType 
    {
        public TipoProveedor()
        {
             Proveedores = new List<Proveedor>();
        }

        public String Nombre { get; set; }

        public virtual ICollection<Proveedor> Proveedores { get; set; }


    }
}
