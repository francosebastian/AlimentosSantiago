using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentosSantiago.Dto
{
    public class Plato : LayerSuperType
    {
        public Plato() { DetallesPedidoMenu = new List<DetallePedidoMenu>(); }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public int Precio { get; set; }
        public int PrecioPromocion { get; set; }
        public bool PromocionActiva { get; set; }
        public string RutaImagen { get; set; }
        public int CategoriaPlatoId { get; set; }
        [ForeignKey("CategoriaPlatoId")]
        public virtual CategoriaPlato CategoriaPlato { get; set; }
        public int ProveedorId { get; set; }
        [ForeignKey("ProveedorId")]
        public virtual Usuario Proveedor { get; set; }
        public virtual ICollection<DetallePedidoMenu> DetallesPedidoMenu { get; set; }

    }
}
