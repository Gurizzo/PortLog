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

        public decimal Precio { get; set; }

        public Pais Pais { get; set; }

        public bool Enviado { get; set; }



        public Importacion()
        {
        }

        public Importacion(int id, DateTime fchIngreso, DateTime fchSalida, Producto producto, int cantidad, int descuento, decimal precio, Pais pais, bool enviado)
        {
            Id = id;
            FchIngreso = fchIngreso;
            FchSalida = fchSalida;
            Producto = producto;
            Cantidad = cantidad;
            Descuento = descuento;
            Precio = precio;
            Pais = pais;
            Enviado = enviado;
        }
    }
}
