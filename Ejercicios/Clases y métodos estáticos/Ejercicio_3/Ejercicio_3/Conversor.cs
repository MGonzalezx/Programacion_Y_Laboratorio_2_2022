using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    public static class Conversor
    {
        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            string binary = Convert.ToString(numeroEntero,2);

            return binary;
        }

        public static int ConvertirBinarioADecimal(string numeroBinario)
        {
            int numeroDecimal = Convert.ToInt32(numeroBinario, 2);

            return numeroDecimal;
        }
    }
}
