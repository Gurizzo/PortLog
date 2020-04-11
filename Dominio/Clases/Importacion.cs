using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Clases
{
    public class Importacion
    {


        public DateTime fchIngreso { get; set; }

        public DateTime fchSalida { get; set; }

        public Producto producto { get; set; }

        public int cantidad { get; set; }

        public int descuento { get; set; }

        public Cliente cliente { get; set; }

        public Pais pais { get; set; }

        public Importacion(DateTime fchIngreso, DateTime fchSalida, Producto producto, int cantidad, int descuento, Cliente cliente, Pais pais)
        {
            this.fchIngreso = fchIngreso;
            this.fchSalida = fchSalida;
            this.producto = producto;
            this.cantidad = cantidad;
            this.descuento = descuento;
            this.cliente = cliente;
            this.pais = pais;
        }

        public int CalcularCosto()
        {
            return 0;//Implementar
        }
    }
}
