using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string nombre = "Lautaro";
            int horasTrabajadas = 8;
            int precioPorHora = 100;
            int costoTrabajo = horasTrabajadas * precioPorHora;

            Console.WriteLine("{0} trabajó {1} horas. El costo por el trabajo es de ${2}.", nombre, horasTrabajadas, costoTrabajo);*/

            //const decimal IVA = 0.21M;

            //decimal precioBruto = 100M;
            //decimal precioNeto = precioBruto + precioBruto * IVA;

            //Console.WriteLine("El precio bruto es {0} y aplicando IVA queda en {1}.", precioBruto, precioNeto);

            //Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.

            Console.Title = "Ejercicio_1";

            int auxiliar;
            int maximo = 0;
            int minimo = 0;
            string numeroString;
            float promedio =0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese su numero: ");
                numeroString = Console.ReadLine();
                //auxiliar = int.Parse(numeroString);

                if (int.TryParse(numeroString,out auxiliar))
                {
                    if (auxiliar > maximo)
                    {
                        maximo = auxiliar;
                    }

                    if (auxiliar < minimo)
                    {
                        minimo = auxiliar;
                    }

                    promedio = (promedio + auxiliar);
                }
                else
                {
                    Console.WriteLine("Error, ingrese un número valido: ");
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
