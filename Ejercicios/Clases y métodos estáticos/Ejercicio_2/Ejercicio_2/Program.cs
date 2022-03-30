using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_1";

           
            int numeroString;
            float sumador = 0;
            char respuesta;
            bool booleano = true;


            do
            {
                Console.Write("Ingrese su numero: ");
                numeroString = Convert.ToInt32(Console.ReadLine());
  
                sumador = sumador + numeroString;
                
                Console.Write("¿Desea continuar? (S/N): ");
                respuesta = Convert.ToChar(Console.ReadLine());
                booleano = Validador.ValidarRespuesta(respuesta);

            } while (booleano);

           
            
          
          Console.WriteLine("Suma: {0}", sumador);

        }
    }
}
