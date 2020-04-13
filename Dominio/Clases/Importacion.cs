using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Clases
{
    public class Importacion
    {


        public int Id { get; set; }

        public DateTime FchIngreso { get; set; }

        public DateTime FchSalida { get; set; }

        public Producto Producto { get; set; }

        public int Cantidad { get; set; }

        public int Descuento { get; set; }

        public Cliente Cliente { get; set; }

        public Pais Pais { get; set; }

        public Importacion(int id, DateTime fchIngreso, DateTime fchSalida, Producto producto, int cantidad, int descuento, Cliente cliente, Pais pais)
        {
            Id = id;
            FchIngreso = fchIngreso;
            FchSalida = fchSalida;
            Producto = producto;
            Cantidad = cantidad;
            Descuento = descuento;
            Cliente = cliente;
            Pais = pais;
        }

        public int CalcularCosto()
        {
            return 0;//Implementar
        }
    }
}
