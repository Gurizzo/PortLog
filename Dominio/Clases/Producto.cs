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

        public Cliente Cliente { get; set; }

        public decimal Precio { get; set; }

        public List<Importacion> Importaciones { get; set; }


        public Producto()
        {

        }

        public Producto(int id, int codigo, string nombre, decimal peso, Cliente cliente, decimal precio, List<Importacion> importaciones)
        {
            Id = id;
            Codigo = codigo;
            Nombre = nombre;
            Peso = peso;
            Cliente = cliente;
            Precio = precio;
            Importaciones = importaciones;
        }
    }
}
