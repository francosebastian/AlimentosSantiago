using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentosSantiago.Dto
{
    public class DetallePedidoMenu : LayerSuperType
    {
        public int Cantidad { get; set; }
        public int PrecioUnitario { get; set; }
        public int PedidoMenuId { get; set; }
        [ForeignKey("PedidoMenuId")]
        public virtual PedidoMenu PedidoMenu { get; set; }
        public int PlatoId { get; set; }
        [ForeignKey("PlatoId")]
        public virtual Plato Plato { get; set; }
    }
}
