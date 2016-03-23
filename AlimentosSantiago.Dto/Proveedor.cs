using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentosSantiago.Dto
{
    public class Proveedor 
    {
      
        public Proveedor()
        {
            Platos = new List<Plato>();
        }
        [Required]
        public String Nombre { get; set; }
        [Required]
        public String Direccion { get; set; }
        [Required]
        public String Telefono { get; set; }
        public virtual ICollection<Plato> Platos { get; set; }

        public int TipoProveedorId { get; set; }

        [ForeignKey("TipoProveedorId")]
        public virtual TipoProveedor TipoProveedor { get; set; }
        /// <summary>
        /// Asignamos el foreingKey
        /// </summary>
        [Key, ForeignKey("Usuario")]
        public int UsuarioId { get; set; }
        /// <summary>
        /// Relacionamos el foreingKey
        /// </summary>
        public virtual Usuario Usuario { get; set; }

    }
}
