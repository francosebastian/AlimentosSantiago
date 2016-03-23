using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Required]
        public String Nombre { get; set; }
    }
}
