using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_3";

            string binario;

            int numeroDecimal;

            binario = Conversor.ConvertirDecimalABinario(2);

            numeroDecimal = Conversor.ConvertirBinarioADecimal("1001101");

            Console.WriteLine("Decimal a binario: {0}", binario);

            Console.WriteLine("Binario a decimal: {0}", numeroDecimal);
        }
    }
}
