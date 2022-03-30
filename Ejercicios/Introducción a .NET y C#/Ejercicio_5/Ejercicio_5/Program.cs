using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Un centro numérico es un número que separa una lista de números enteros(comenzando en 1) en dos grupos de números, cuyas sumas son iguales.

            //El primer centro numérico es el 6, el cual separa la lista(1 a 8) en los grupos: (1; 2; 3; 4; 5) y(7; 8) cuyas sumas son ambas iguales a 15.

            //El segundo centro numérico es el 35, el cual separa la lista(1 a 49) en los grupos: (1 a 34) y(36 a 49) cuyas sumas son ambas iguales a 595.

            //Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el usuario ingrese por consola.

            Console.Title = "Ejercicio_5";

            int auxiliar;
            string numero;
            int centro;

            Console.Write("Ingrese su número: ");
            numero = Console.ReadLine();

            if (int.TryParse(numero, out auxiliar))
            {
                //El centro inicia en 1
                for (centro = 1; centro <= auxiliar; centro++)
                {
                    //sumamos los numeros que estan antes del centro
                    int acum = 0;

                    for (int i = 1; i < centro; i++)
                    {
                        acum += i;
                    }

                    // Calculo con números superiores al "centro"
                    int contador = centro + 1;
                    do
                    {
                        acum -= contador;
                        contador++;
                    } while (acum > 0);


                    // Si acum es 0 es porque es un "centro numérico"
                    if (acum == 0)
                    {
                        Console.WriteLine("{0} es centro numérico", centro);
                    }

                    else
                    {
                        Console.WriteLine("{0} no es centro numérico", centro);
                    }
                        

                }
            }
            else
            {
                Console.WriteLine("Lo ingresado no es un número.");
            }
        }
    }
}
