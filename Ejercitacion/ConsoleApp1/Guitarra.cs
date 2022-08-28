using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Guitarra
    {
        //
        //ATRIBUTOS
        public string marca;
        public int precio;
        public string material;
        public bool estaAfinada;
        public int cantidadCuerdas;
        // COMPORTAMIENTOS

        public Guitarra(string marca)
        {
            this.marca = marca;
    


        }


        public bool Afinar()
        {
            estaAfinada = true;
            return estaAfinada;
        }

        public void SubirDePrecio()
        {
            material = "ROBLE";
            precio *= 2;
        }
    }
}
