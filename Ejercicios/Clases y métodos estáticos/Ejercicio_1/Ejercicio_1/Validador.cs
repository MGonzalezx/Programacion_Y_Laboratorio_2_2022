using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    public static class Validador
    {
        public static bool Validar(int valor, int min, int max)
        {
            if(valor >= min & valor <= max)
            {
                return true;
            }
            else
            {
                //Console.WriteLine("El numero debe estar entre un rango de -100 y 100");
                return false;
            }
        }
    }
}
