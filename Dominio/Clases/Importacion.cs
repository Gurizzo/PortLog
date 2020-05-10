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

        public decimal Precio { get; set; }

        public Pais Pais { get; set; }

        public bool Almacenado { get; set; }



        public Importacion()
        {
        }

        public Importacion(int id, DateTime fchIngreso, DateTime fchSalida, Producto producto, int cantidad, decimal precio, Pais pais, bool enviado)
        {
            Id = id;
            FchIngreso = fchIngreso;
            FchSalida = fchSalida;
            Producto = producto;
            Cantidad = cantidad;
            Precio = precio;
            Pais = pais;
            Almacenado = enviado;
        }


        public int CalcularDias()
        {
            
                return (this.FchSalida - this.FchIngreso ).Days;
            
        }
            
        

    }
}
