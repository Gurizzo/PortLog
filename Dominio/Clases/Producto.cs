using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Clases
{
    public class Producto
    {


        public int codigo { get; set; }

        public string nombre { get; set; }

        public decimal peso { get; set; }

        public Producto(int codigo, string nombre, decimal peso)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.peso = peso;
        }

    }
}
