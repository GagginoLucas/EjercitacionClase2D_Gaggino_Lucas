/*
Consigna
Ingresar un número y mostrar el cuadrado y el cubo del mismo.
Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
*/
using System;

namespace Ejercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            bool numeroIngresado;
            double numeroAlCubo;
            double numeroAlCuadrado;

            Console.WriteLine("Ingrese un numero: ");
            numeroIngresado = int.TryParse(Console.ReadLine(), out numero);
            do
            {
                numeroAlCubo = Math.Pow(numero, 3);
                numeroAlCuadrado = Math.Pow(numero, 2);
                Console.WriteLine($"Numero al cuadrado : {numeroAlCuadrado} Numero al cubo: {numeroAlCubo}");
            } while (numeroIngresado != true);


        }
    }
}
