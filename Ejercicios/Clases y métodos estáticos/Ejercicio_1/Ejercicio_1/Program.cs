using System;


namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Ejercicio_1";

            int cantidadDeNumero = 10;
            int numeroString;
            float promedio = 0;
            bool booleano;
            int maximo = 0;
            int minimo = 0;

            for (int i = 0; i < cantidadDeNumero; i++)
            {
                Console.Write("Ingrese su numero: ");
                numeroString = Convert.ToInt32(Console.ReadLine());
                booleano = Validador.Validar(numeroString, -100, 100);

                if (booleano)
                {
                    if (numeroString > maximo)
                    {
                        maximo = numeroString;
                    }

                    if (numeroString < minimo)
                    {
                        minimo = numeroString;
                    }

                    promedio = (promedio + numeroString);
                }
                else
                {
                    Console.WriteLine("El numero debe estar entre un rango de -100 y 100");
                    i--;
                }

            }

            promedio = promedio / 5;


            Console.WriteLine("Máximo : {0}", maximo);

            Console.WriteLine("Mínimo : {0}", minimo);
            Console.WriteLine("Promedio: {0:#.00}", promedio);
        }
    }
}
