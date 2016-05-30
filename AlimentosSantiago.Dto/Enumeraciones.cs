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
        public enum TiposUsuario 
        {
            Administrador = 2 ,
            EncargadoPedidos = 4,
            EncargadoEmpresaProveedora = 3,
            Cliente = 1,
            EncargadoConvenioEmpresa = 6,
            Repartidor = 5
        };
        public enum EstadosPedido
        {
            Realizado = 1,
            Recibido = 2,
            EnPreparacion = 3,
            EnReparto = 4,
            Finalizado = 5,
            Repartidor = 6
        };
    }
}
