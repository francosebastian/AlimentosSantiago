using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentosSantiago.Dto
{
    /// <summary>
    /// Clase que contiene los estados de los pedidos
    /// </summary>
    public class EstadoPedido : LayerSuperType
    {
        /// <summary>
        /// Nombre del estado del pedido
        /// </summary>
        public EstadoPedido()
        {
            Pedidos = new List<Pedido>();
        }
        [Required]
        public String Nombre { get; set; }


        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}
