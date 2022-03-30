using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double cuadrado = 0;
            double cubo = 0;
            string numeroString;
            double auxiliar;
            bool booleano = false;
           

           
            //auxiliar = int.Parse(numeroString);

            while (!booleano)
            { 
                
                Console.Write("Ingrese su numero: ");
                numeroString = Console.ReadLine();
                booleano = double.TryParse(numeroString, out auxiliar);
                if (auxiliar < 0)
                {
                    booleano = !booleano;
                }

                if (!booleano )
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    //Console.WriteLine("Error, ingrese un número valido");
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                    Console.ResetColor();
                }
                else
                {
                    
                    if (auxiliar > 0)
                    {
                        cuadrado = Math.Pow(auxiliar, 2);
                        cubo = Math.Pow(auxiliar, 3);

                        
                    }
                    
                }
            }

            Console.WriteLine("El numero al cuadrado es: {0,-5:#.##}  El numero al cubo es: {1,5:#.##}", cuadrado, cubo);
            
        }
    }
}
