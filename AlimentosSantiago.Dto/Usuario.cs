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
    /// Clase Usuario que contiene las propiedades de la entidad
    /// </summary>
    public class Usuario : LayerSuperType
    {
        public Usuario(){   DireccionUsuarios = new List<DireccionUsuario>();
                            LogsSaldo = new List<LogSaldo>();
                            PedidosMenusCliente = new List<PedidoMenu>();
                            PedidosMenusRepartidor = new List<PedidoMenu>();
                            PlatosProveedor = new List<Plato>(); }
        [Required]
        public string Nombre { get; set; }
        
        public string Apellido { get; set;}
        [Required]
        public string Telefono { get; set; }
        public string Telefono2 { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public int? EmpresaId { get; set; }

        [ForeignKey("EmpresaId")]
        public virtual Empresa Empresa { get; set; }
        public int TipoUsuarioId { get; set; }

        [ForeignKey("TipoUsuarioId")]
        public virtual TipoUsuario TipoUsuario { get; set; }
        public virtual ICollection<DireccionUsuario> DireccionUsuarios { get; set;}
        public virtual ICollection<PedidoMenu> PedidosMenusCliente { get; set; }
        public virtual ICollection<PedidoMenu> PedidosMenusRepartidor { get; set; }
        public virtual ICollection<Plato> PlatosProveedor { get; set; }
        public virtual ICollection<LogSaldo> LogsSaldo { get; set; }
    }
}
