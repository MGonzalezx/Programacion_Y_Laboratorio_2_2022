using System;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
          //  Se debe pedir el ingreso por teclado del valor hora, el nombre, la antigüedad(en años) y la cantidad de horas trabajadas en el mes de N cantidad de empleados de una fábrica.

          //  Se pide calcular el importe a cobrar teniendo en cuenta que el total(que resulta de multiplicar el valor hora por la cantidad de horas trabajadas),

          //  hay que sumarle la cantidad de años trabajados multiplicados por $150, y al total de todas esas operaciones restarle el 13 % en concepto de descuentos.

          //Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en bruto y el total a cobrar neto de todos los empleados ingresados.


            Console.Title = "Ejercicio_7";
            int totalEmpleadoALeer = 3;

            string nombre;
            string valorHora;
            string antiguedad;
            string horas;
            int auxAntiguedad;
            int auxHoras;
            int auxValorHora;
            double importe;
            double importeNeto;

            for (int i = 0; i < totalEmpleadoALeer; i++)
            { 
               
                Console.Write("Ingrese el nombre del empleado:");
                nombre = Console.ReadLine();
                Console.Write("Ingrese el valor hora del empleado:");
                valorHora = Console.ReadLine();
                Console.Write("Ingrese la antiguedad del empleado:");
                antiguedad = Console.ReadLine();
                Console.Write("Ingrese las horas trabajadas del empleado:");
                horas = Console.ReadLine();

                if (int.TryParse(antiguedad, out auxAntiguedad) && int.TryParse(horas,out auxHoras) && int.TryParse(valorHora,out auxValorHora))
                {
                    importe = (auxValorHora * auxHoras) + (150* auxAntiguedad);
                    importeNeto = importe - importe * 0.13;

                    Console.WriteLine("Nombre: {0}, Antiguedad: {1}, Valor hora: {2}, Total Bruto: {3}, Total Neto: {4}", nombre, auxAntiguedad, auxValorHora, importe, importeNeto);


                }
                else
                {
                    Console.WriteLine("Ingrese una hora o antiguedad correcta");
                }

                
            }
        }
    }
}
