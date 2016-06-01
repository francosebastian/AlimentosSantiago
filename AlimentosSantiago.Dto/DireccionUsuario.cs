using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentosSantiago.Dto
{
    public class DireccionUsuario : LayerSuperType
    {
        public DireccionUsuario() { PedidosUsuario = new List<PedidoMenu>(); }
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }
        [StringLength(100)]
        public string Direccion { get; set; }
        [StringLength(100)]
        public string Latitud { get; set; }
        [StringLength(100)]
        public string Longitud { get; set; }
        public int UsuarioId { get; set; }
        [ForeignKey("UsuarioId")]
        public virtual Usuario Usuario { get; set; }
        public virtual ICollection<PedidoMenu> PedidosUsuario { get; set; }
    }
}

