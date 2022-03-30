using System;

namespace Ejercicio_Clase_4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Ejercicio_Clase_4";

            #region PARTE 2
            Cosa objeto = new Cosa();
            Cosa objeto2 = new Cosa("HOLA");
            Cosa objeto3 = new Cosa(20,"CHAU");
            Cosa objeto4 = new Cosa(DateTime.Today,25,"NUNCA");

            Console.WriteLine(Cosa.Mostrar(objeto));
            Console.WriteLine(Cosa.Mostrar(objeto2));
            Console.WriteLine(Cosa.Mostrar(objeto3));
            Console.WriteLine(Cosa.Mostrar(objeto4));
            Console.ReadKey();
            #endregion

            

            //PARTE1
            //objeto.EstablecerValor(5);
            //objeto.EstablecerValor("Juan");
            //objeto.EstablecerValor(DateTime.Now);



            //Console.WriteLine(Cosa.Mostrar(objeto));
        }
    }
}
