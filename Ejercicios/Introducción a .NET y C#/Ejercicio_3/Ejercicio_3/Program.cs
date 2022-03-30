using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_3";

            int auxiliar;
            Console.Write("Ingrese un número: ");
            if (int.TryParse(Console.ReadLine(), out auxiliar))
            {
                int j = 0;
                for (int i = 2; i <= auxiliar; i++)
                {
                    for ( j = 2; j < i; j++)
                    {
                        if ((i % j) == 0)
                        {
                           
                            break;
                        }
                    }

                    if(i == j)
                    {
                       Console.WriteLine("El número {0} es primo", i);
                    }
                    
                        
                }
            }


        }
    }
}
