using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Clases
{
    public class Producto
    {


        public int Codigo { get; set; }

        public string Nombre { get; set; }

        public decimal Peso { get; set; }

        public Producto(int codigo, string nombre, decimal peso)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Peso = peso;
        }

    }
}
