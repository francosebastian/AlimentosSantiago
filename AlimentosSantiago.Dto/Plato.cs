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
        public Plato()
        {
            DetalleMenus = new List<DetalleMenu>();
            DetallePedidos = new List<DetallePedido>();
            DetallePromocion = new List<DetallePromocion>();
        }
        public int ProveedorId { get; set; }

        [ForeignKey("ProveedorId")]
        public virtual Proveedor Proveedor { get; set; }
        [Required]
        public int Precio { get; set; }
        [Required]
        public String Nombre { get; set; }
        [Required]
        public String Descripcion { get; set; }
        [Required]
        public String Codigo { get; set; }
        [Required]
        public int TiempoPreparacion { get; set; }
        public virtual ICollection<DetalleMenu> DetalleMenus { get; set; }
        public virtual ICollection<DetallePedido> DetallePedidos { get; set; }
        public virtual ICollection<DetallePromocion> DetallePromocion { get; set; }
    }
}
