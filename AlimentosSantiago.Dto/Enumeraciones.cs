using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentosSantiago.Dto
{
    [NotMapped]
    public static class Enumeraciones
    {
        public enum TiposUsuario : int
        {
            Administrador = 1 ,
            EncargadoPedidos = 21,
            EncargadoEmpresaProveedora = 22,
            Cliente = 23,
            EncargadoConvenioEmpresa = 22,
            Repartidor = 25
        };
    }
}
