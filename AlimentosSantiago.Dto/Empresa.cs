using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentosSantiago.Dto
{
    public class Empresa : LayerSuperType
    {
        public Empresa()
        {
            Clientes = new List<Cliente>();
        }
        public virtual ICollection<Cliente> Clientes { get; set; }
        public String Nombre { get; set; }
    }
}
