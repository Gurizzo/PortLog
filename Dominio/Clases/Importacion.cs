using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Clases
{
    public class Importacion
    {


        public DateTime FchIngreso { get; set; }

        public DateTime FchSalida { get; set; }

        public Producto Producto { get; set; }

        public int Cantidad { get; set; }

        public int Descuento { get; set; }

        public Cliente Cliente { get; set; }

        public Pais Pais { get; set; }

        public Importacion(DateTime fchIngreso, DateTime fchSalida, Producto producto, int cantidad, int descuento, Cliente cliente, Pais pais)
        {
            this.FchIngreso = fchIngreso;
            this.FchSalida = fchSalida;
            this.Producto = producto;
            this.Cantidad = cantidad;
            this.Descuento = descuento;
            this.Cliente = cliente;
            this.Pais = pais;
        }

        public int CalcularCosto()
        {
            return 0;//Implementar
        }
    }
}
