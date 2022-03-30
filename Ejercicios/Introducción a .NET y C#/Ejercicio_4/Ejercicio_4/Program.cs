using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos(excluido el mismo) que son divisores del número.

            //El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.

            //Escribir una aplicación que encuentre los 4 primeros números perfectos.

            Console.Title = "Ejercicio_04";

            int numerosPerfectos = 0;

            //Tiene que ser mayor a 0.
            int numeroActual = 1;


            while (numerosPerfectos < 4)
            {
                int sumador = 0;
                for (int i = 1; i < numeroActual; i++)
                {
                    //Buscamos lo divisores
                    if ((numeroActual % i) == 0)
                    {
                        // Sumo los divisores en busca del número Perfecto
                        sumador += i;

                        if (sumador > numeroActual)
                        {
                            break;
                        }
                            
                    }
                }

                // Si la suma de los divisores es igual al número, es PERFECTO
                if (sumador == numeroActual)
                {
                    numerosPerfectos++;
                    Console.WriteLine("El número {0} es PERFECTO", numeroActual);
                }
                // Incremento el número actual
                numeroActual++;
            }

            
        }
    }
}
