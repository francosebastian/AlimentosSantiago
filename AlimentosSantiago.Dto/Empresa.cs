using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentosSantiago.Dto
{
    public class Empresa : LayerSuperType
    {
        public Empresa()
        {
            Usuarios = new List<Usuario>();
        }
        [Required]
        public string Nombre { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
