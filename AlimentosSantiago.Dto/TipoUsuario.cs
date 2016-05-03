using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentosSantiago.Dto
{
    public class TipoUsuario : LayerSuperType
    {
        public TipoUsuario() { Usuarios = new List<Usuario>(); }
        [Required]
        public String Nombre { get; set; }
        [Required]
        public String Descripcion { get; set; }
        public IList<Usuario> Usuarios { get; set; }
    }
}

