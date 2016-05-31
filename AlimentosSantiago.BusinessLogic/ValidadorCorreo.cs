using AlimentosSantiago.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlimentosSantiago.BusinessLogic
{
    public static class ValidadorCorreo
    {
        /// <summary>
        /// Valida que no exista un usuario con el correo repetido 
        /// </summary>
        /// <param name="correo">Correo electronico del usuario</param>
        /// <returns>respuesta del correo electronico</returns>
        public static Boolean ValidarCorreo(String correo)
        {
            Boolean respuesta = false;
            try
            {
                using (OracleDbContext db = new OracleDbContext())
                {
                    respuesta = db.Usuario.Any(u => u.Email == correo);
                }
                return respuesta;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
