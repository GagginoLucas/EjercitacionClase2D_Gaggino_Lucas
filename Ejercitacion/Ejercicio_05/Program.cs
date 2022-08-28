/*
 * Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) en dos grupos de números, cuyas sumas son iguales.
    El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y (7; 8) cuyas sumas son ambas iguales a 15.
    El segundo centro numérico es el 35, el cual separa la lista (1 a 49) en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595.
    Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el usuario ingrese por consola.
   */
using System;

namespace Ejercicio_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroIngresado;
            int numeroIngresadoParseado;
            int sumaAntecesores = 0;
            int sumaSucerores = 0;

            Console.WriteLine("Ingrese un numero hasta donde desee calcular los centros numericos: ");
            numeroIngresado = Console.ReadLine();

            if (int.TryParse(numeroIngresado, out numeroIngresadoParseado))
            {
                for (int i = 1; i <= numeroIngresadoParseado; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        sumaAntecesores += j;
                    }
                    for (int k = i + 1; k <= numeroIngresadoParseado; k++)
                    {
                        sumaSucerores += k;
                    }
                    if (sumaSucerores == sumaAntecesores)
                    {
                        Console.WriteLine(i + " es un centro numerico.");
                    }
                    sumaAntecesores = 0;
                    sumaSucerores = 0;
                }
            }
            else
            {
                Console.WriteLine("Numero ingresado incorrecto.");
            }
        }
    }
}
