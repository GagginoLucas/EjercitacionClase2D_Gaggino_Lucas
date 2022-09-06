using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Máquina_expendedora
{
    internal class Producto
    {
        private int precio;
        private string nombre;

        public Producto(int precio, string nombre)
        {
            this.precio = precio;
            this.nombre = nombre;
        }


        public int Precio
        {
            get { return precio; }
        }

        public string Nombre
        {
            get { return nombre; }
        }

    }

     
}
