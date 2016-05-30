using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentosSantiago.Dto
{
    public class DetallePedidoMenu : LayerSuperType, IEquatable<DetallePedidoMenu>
    {
        public int Cantidad { get; set; }
        public int PrecioUnitario { get; set; }
        public int PedidoMenuId { get; set; }
        [ForeignKey("PedidoMenuId")]
        public virtual PedidoMenu PedidoMenu { get; set; }
        [NotMapped]
        private int _platoId;
        public int PlatoId
        {
            get { return _platoId; }
            set
            {
                // To ensure that the Prod object will be re-created
                _plato = null;
                _platoId = value;
            }
        }
        [ForeignKey("PlatoId")]
        [NotMapped]
        private Plato _plato = null;
        public virtual Plato Plato {
            get
            {
                // Lazy initialization - the object won't be created until it is needed
                if (_plato == null)
                {
                    _plato = new Plato();
                }
                return _plato;
            }
        }

        public bool Equals(DetallePedidoMenu item)
        {
            return item.PlatoId == this.PlatoId; 
        }

       
    }
}
