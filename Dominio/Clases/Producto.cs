using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Clases
{
    public class Producto
    {


        public int Id { get; set; }

        public int Codigo { get; set; }

        public string Nombre { get; set; }

        public decimal Peso { get; set; }

        public Producto(int id, int codigo, string nombre, decimal peso)//SI LOS PRODUCTOS SON PRE CARGADOS BORRAR!!!
        {
            Id = id;
            Codigo = codigo;
            Nombre = nombre;
            Peso = peso;
        }

    }
}
