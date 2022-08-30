/*
 * Realizar una clase llamada Validador que posea un método estático llamado Validar con la siguiente firma:

bool Validar(int valor, int min, int max)

valor: dato a validar.
min: mínimo valor incluido.
max: máximo valor incluido.
Pedir al usuario que ingrese 10 números enteros.
Validar con el método desarrollado anteriormente que estén dentro del rango -100 y 100.

Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.
 * ¨*/

using System;
using System.Net.WebSockets;

namespace Ejercicio2_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string datoIngresado;
            int numero;
            int acumulador = 0;
            int minimoIngresado = 0;
            int maximoIngresado = 0;
            float promedio;
            bool flag = true;

            for (int i = 0; i < 10; i++)
            {
             do
                datoIngresado = Console.ReadLine();
                while (!ValidarNumerico(datoIngresado, -100, 100));
                numero = int.Parse(datoIngresado);
                
                if(flag == true)
                {
                    minimoIngresado = numero;
                    maximoIngresado = numero;
                    flag = false;
                }
                if(numero>maximoIngresado)
                {
                    maximoIngresado = numero;
                }
                if(numero<minimoIngresado)
                {
                    minimoIngresado = numero;
                }
                acumulador += numero;
            }
            promedio = acumulador / 10;
            Console.WriteLine($"Número mínimo ingresado: {minimoIngresado}\n Número máximo ingresado: {maximoIngresado}\n Promedio: {promedio}");

        }

        public static bool ValidarNumerico(string valorIngresado, int min, int max)
        {
            int numero = int.Parse(valorIngresado);
            return (ValidarRango(numero, min, max) && EsNumerico(valorIngresado));
        }
        public static bool ValidarRango(int valor, int min, int max)
        {
            return (valor > min && valor < max);
        }
        public static bool EsNumerico(string numero)
        {
            return (int.TryParse(numero, out int rtn));
        }
    }
}
