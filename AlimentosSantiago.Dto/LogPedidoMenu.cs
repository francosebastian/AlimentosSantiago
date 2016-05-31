using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentosSantiago.Dto
{
    public class LogPedidoMenu : LayerSuperType
    {
        public LogPedidoMenu() { }
        [StringLength(100)]
        public string Log { get; set; }
        public int PedidoMenuId { get; set; }
        [ForeignKey("PedidoMenuId")]
        public virtual PedidoMenu PedidoMenu { get; set; }
        public int EstadoPedidoId { get; set; }
        [ForeignKey("EstadoPedidoId")]
        public virtual EstadoPedido EstadoPedido { get; set; }
    }
}
