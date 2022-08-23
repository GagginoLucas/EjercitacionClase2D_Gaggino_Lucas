/*
 Consigna
Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.

Validar que el dato ingresado por el usuario sea un número.

Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".

Si ingresa "salir", cerrar la consola.

Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.

IMPORTANTE
Utilizar sentencias de iteración, selectivas y el operador módulo (%).
*/


using System;

namespace Ejercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cadena;
            int numero;

            Console.WriteLine("ingrese un numero: ");
            cadena = Console.ReadLine();

            while(!int.TryParse(cadena, out numero))
            {
                Console.WriteLine("Ingrese un numero correcto o tipee 'salir'");
                cadena = Console.ReadLine();
                if (cadena == "salir")
                {
                    break;
                }
            }
            for (int i = 0; i < numero; i++)
            {
                if (i%1 == 1)
                {
                    Console.WriteLine(i);
                }
            }


        }
    }
}
