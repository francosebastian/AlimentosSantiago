using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentosSantiago.Dto
{
    public class Promocion : LayerSuperType
    {
        public Promocion()
        {
            DetallePromociones = new List<DetallePromocion>();
        }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public int Descuento { get; set; }

        public virtual ICollection<DetallePromocion> DetallePromociones { get; set; }
    }
}
