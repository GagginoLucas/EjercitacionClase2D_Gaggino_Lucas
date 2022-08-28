/*
Consigna
Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos 
(excluido el mismo) que son divisores del número.

El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.

Escribir una aplicación que encuentre los 4 primeros números perfectos.
*/

using System;

namespace Ejercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroParaAnalizar = 6;
            int sumaDeDivisores = 0;
            int contador = 0;

            do
            {
                for (int j = 1; j < numeroParaAnalizar; j++)
                {
                    if (numeroParaAnalizar % j == 0)
                    {
                        sumaDeDivisores += j;
                    }
                }
                if (sumaDeDivisores == numeroParaAnalizar)
                {
                    contador++;
                    Console.WriteLine($"Numero perfecto {contador}: {numeroParaAnalizar}");
                }
                sumaDeDivisores = 0;
                numeroParaAnalizar++;
            } while (contador < 4);
        }
    }
}

