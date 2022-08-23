using System;

namespace Mi_primer_proyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] nombres = new string[3];

            nombres[0] = "Mauro";
            nombres[1] = "Fede";
            nombres[2] = "Maria";


            for (int i = 0; i < nombres.Length; i++) 
            {

                Console.WriteLine(nombres[i]);
            }


            string[] paises = { "Argentina", "Peru", "Chile" };

            for (int i = 0; i < paises.Length; i++)
            {
                Console.WriteLine(paises[i]);

            }


        }
    }
}
