using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    public static class Validador
    {
        public static bool ValidarRespuesta(char respuesta)
        {
            if (respuesta.Equals('s'))
            {
                return true;
            }
            else
            {
                
                return false;
            }
        }
    }
}
