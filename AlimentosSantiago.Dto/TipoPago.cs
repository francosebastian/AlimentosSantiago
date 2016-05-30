using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentosSantiago.Dto
{
    public class TipoPago : LayerSuperType
    {
        public TipoPago() { PedidosMenus = new List<PedidoMenu>(); }
        [Required]
        [StringLength(100)]
        public String Nombre { get; set; }
        [Required]
        [StringLength(100)]
        public String Descripcion { get; set; }
        public virtual ICollection<PedidoMenu> PedidosMenus { get; set; }
    }
}
