/*
Consigna
Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.
*/
using System;

namespace Ejercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool numeroIngresado;
            int numero;
            int valorMaximo= 0;
            int valorMinimo = 0;
            float promedio = 0;
            int acumulador = 0; 
            bool flag = true;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                numeroIngresado = int.TryParse(Console.ReadLine(), out numero);
                if (numeroIngresado)
                {

                    if (flag)
                    {
                        valorMaximo = numero;
                        valorMinimo = numero;
                        flag = false;
                    }
                    if (numero > valorMaximo)
                    {
                        valorMaximo = numero;
                    }
                    else if (numero < valorMinimo)
                    {
                        valorMinimo = numero;
                    }
                    acumulador += numero;
                    promedio = (float)acumulador / 5;
                }
                else
                {
                 Console.WriteLine("El numero ingresado no es  correcto!!");
                }


            }
            Console.WriteLine($"Valor Maximo: {valorMaximo}, Valor Minimo: {valorMinimo}, promedio: {promedio}");


        }
    }
}
