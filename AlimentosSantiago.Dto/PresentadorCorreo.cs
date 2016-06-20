using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentosSantiago.Dto
{
    [Serializable]
    public class PresentadorCorreo
    {
        public DateTime Fecha { get; set; }
        public int Id { get; set; }
    }
}
