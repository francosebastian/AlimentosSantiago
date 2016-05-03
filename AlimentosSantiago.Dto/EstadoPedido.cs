using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentosSantiago.Dto
{
    public class EstadoPedido : LayerSuperType
    {
        public EstadoPedido() { LogsPedidoMenu = new List<LogPedidoMenu>(); }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Descripcion { get; set; }
        public virtual ICollection<LogPedidoMenu> LogsPedidoMenu {get; set;}
    }
}
