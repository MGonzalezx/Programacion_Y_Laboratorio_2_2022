using System;

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {

            //Escribir un programa que imprima por consola un triángulo como el siguiente:

            //*
            //***
            //*****
            //*******
            //*********
            //El usuario indicará cuál será la altura del triángulo ingresando un número entero positivo.Para el ejemplo anterior, la altura ingresada fue de 5.

           Console.Title = "Ejercicio_8";

            int altura;

           Console.Write("Ingrese altura: ");
            altura = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < altura; i++)
            {
                //Para que salga como una piramide
                for (int j = 1; j <= altura - i; j++)
                {
                    Console.Write(" ");
                }


                for (int j = 1; j <= 2 * i + 1; j++)
                {
                Console.Write("*");
                }
                    
                Console.Write("\n");
            }

        }
    }
}
