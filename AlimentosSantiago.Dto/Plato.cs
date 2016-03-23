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
    }
}
