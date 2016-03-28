using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentosSantiago.Dto
{
    public class Pedido : LayerSuperType
    {
        public Pedido()
        {
            DetallePedidos = new List<DetallePedido>();
            HistorialPedidos = new List<HistorialPedido>();
            TipoPagos = new List<TipoPago>();
        }
        public virtual ICollection<DetallePedido> DetallePedidos { get; set; }
        public virtual ICollection<HistorialPedido> HistorialPedidos { get; set; }
        public virtual ICollection<TipoPago> TipoPagos { get; set; }


        public virtual EstadoPedido EstadoPedido { get; set; }

        [Required]
        public int Total { get; set; }
        public int ClienteId { get; set; }

        [ForeignKey("ClienteId")]
        public virtual Cliente Cliente { get; set; }

        public virtual Repartidor Repartidor { get; set; }
    }

}

