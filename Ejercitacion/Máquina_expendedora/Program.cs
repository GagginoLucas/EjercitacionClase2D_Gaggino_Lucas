/*
 * 1.Crear e instanciar el Dictionary<TKey,TValue> llamado maquinaExpendedora.
2.Cargar por lo menos 10 elementos en formato clave-valor (clave=numero de posición, valor=nombre del producto)
3.Una vez cargado, desarrollar el flujo del proyecto de consola de modo que:
•Al iniciarse muestre al usuario todos los productos con sus respectivos códigos.
•Pida al usuario elegir el número del producto que quiere
•Al seleccionar número, informar al usuario que recibió ese producto y volver a mostrar todos los productos SIN el producto que ya eligió
•El programa se repetirá indefinidamente hasta que el usuario elija la opción “S”.
BONUS: Refactorizar el programa para que en vez de tener un diccionario INT – STRING, tengamos un diccionario INT – PRODUCTO (que contenga nombre y precio del producto)
 * */


using Biblioteca;
using System;
using System.Collections.Generic;

namespace Máquina_expendedora
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, Producto> maquinaExpendedora = new Dictionary<int, Producto>();
            int opcionElegida;
            string salir;

            maquinaExpendedora.Add(1, new Producto(250, "Cocucha"));
            maquinaExpendedora.Add(2, new Producto(250, "Papitas"));
            maquinaExpendedora.Add(3, new Producto(250, "Alfajorsito"));
            maquinaExpendedora.Add(4, new Producto(250, "Birrita"));
            maquinaExpendedora.Add(5, new Producto(250, "Chipasitos"));
            maquinaExpendedora.Add(6, new Producto(250, "Fernet de litro"));
            maquinaExpendedora.Add(7, new Producto(250, "Chocolate"));
            maquinaExpendedora.Add(8, new Producto(250, "Felicidad"));
            maquinaExpendedora.Add(9, new Producto(250, "Clonazepam"));
            maquinaExpendedora.Add(10, new Producto(250, "Frapanui"));

            do
            {
                foreach (KeyValuePair<int, Producto> item in maquinaExpendedora)
                {
                    Console.WriteLine($"{item.Key} - {item.Value.Nombre} - Precio: {item.Value.Precio} $");
                }
                opcionElegida = Metodos.PedirEnteroEnRango("Seleccione un producto de la máquina expendedora", 1, 10);

                Console.WriteLine($"Elegiste {maquinaExpendedora[opcionElegida].Nombre} - Precio: {maquinaExpendedora[opcionElegida].Precio}");

                maquinaExpendedora.Remove(opcionElegida);

                foreach (KeyValuePair<int, Producto> item in maquinaExpendedora)
                {
                    Console.WriteLine($"{item.Key} - {item.Value.Nombre} - Precio: {item.Value.Precio} $");
                }
                Console.WriteLine("Si desea abandonar la máquina expendedora presione 'S'");
                salir = Console.ReadLine();
                
            } while (salir!= "S");
      
        }
    }
}
