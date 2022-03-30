using System;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribir un programa que determine si un año es bisiesto.

            //Un año es bisiesto si es múltiplo de 4.Los años múltiplos de 100 no son bisiestos, salvo si ellos también son múltiplos de 400.Por ejemplo: el año 2000 es bisiesto pero 1900 no.

            //Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.

            Console.Title = "Ejercicio_6";

            string anioDeInicio;
            int auxiliarDeInicio;
            string anioDeFin;
            int auxiliarDeFin;
           
            Console.Write("Ingrese año de inicio: ");
            anioDeInicio = Console.ReadLine();
            Console.Write("Ingrese año de fin: ");
            anioDeFin = Console.ReadLine();

           
            
               
                if (int.TryParse(anioDeInicio, out auxiliarDeInicio) && int.TryParse(anioDeFin, out auxiliarDeFin))
                {
                    
                        for (int i = auxiliarDeInicio; i <= auxiliarDeFin; i++)
                        {
                            if ((i % 4) == 0 || (i % 400) == 0)
                            {
                                Console.WriteLine("{0} es un año bisiesto", i);
                            
                            }

                        }
                   
                   


                }
                else
                {
                    Console.WriteLine("Numeros ingresados incorrectos");
                }
               
            
            
        }
    }
}
