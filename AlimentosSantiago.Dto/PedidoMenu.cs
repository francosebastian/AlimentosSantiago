using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentosSantiago.Dto
{
    public class PedidoMenu : LayerSuperType
    {
        public PedidoMenu() { DetallesPedidoMenu = new List<DetallePedidoMenu>();
                                LogsPedidoMenu = new List<LogPedidoMenu>();}
        [Required]
        public DateTime Fecha { get; set; }
        public int TipoPagoId { get; set; }
        [ForeignKey("TipoPagoId")]
        public virtual TipoPago TipoPago { get; set; }
        public virtual ICollection<DetallePedidoMenu> DetallesPedidoMenu { get; set; } 
        public int ClienteId { get; set; }
        [ForeignKey("ClienteId")]
        public virtual Usuario Cliente { get; set; }
        public int? EstadoPedidoId { get; set; }
        [ForeignKey("EstadoPedidoId")]
        public virtual EstadoPedido EstadoPedido { get; set; }
        public int? RepartidorId { get; set; }
        [ForeignKey("RepartidorId")]
        public virtual Usuario Repartidor { get; set; }
        public int DireccionUsuarioId { get; set; }
        [ForeignKey("DireccionUsuarioId")]
        public virtual DireccionUsuario DireccionUsuario { get; set; }
        public virtual ICollection<LogPedidoMenu> LogsPedidoMenu { get; set; }
    }
}
