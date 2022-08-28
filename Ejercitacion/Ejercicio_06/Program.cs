/*
 *  Escribir un programa que determine si un año es bisiesto.
    Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, salvo si ellos también son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto pero 1900 no.
    Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.
 */

using System;

namespace Ejercicio_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroInicioIngresado;
            string numeroFinIngresado;
            int añoDeInicio;
            int añoDeFin;

            Console.WriteLine("Ingresar año de inicio del rango:");
            numeroInicioIngresado = Console.ReadLine();
            while(!int.TryParse(numeroInicioIngresado, out añoDeInicio))
            {
                Console.WriteLine("Ingresar año de inicio correcto:");
                numeroInicioIngresado = Console.ReadLine();
            }

            Console.WriteLine("Ingresar año de Fin del rango:");
            numeroFinIngresado = Console.ReadLine();
            while(!int.TryParse(numeroFinIngresado, out añoDeFin))
            {
                Console.WriteLine("Ingresar año de Fin del rango:");
                numeroFinIngresado = Console.ReadLine();
            }
            Console.WriteLine(Environment.NewLine);
            for (int i = añoDeInicio; i++ < añoDeFin; i++)
            {
                if ((i % 4 == 0) || (i % 100 == 0 && i % 400 == 0))
                {
                    Console.WriteLine(i + " es un año bisiesto.");
                }
            }

        }
    }
}
