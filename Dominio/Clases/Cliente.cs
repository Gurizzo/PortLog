using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Clases
{
    public class Cliente
    {


        public int Id { get; set; }

        public string Rut { get; set; }

        public string Nombre { get; set; }

        public DateTime  Antiguedad { get; set; }

        public List<Producto> Productos { get; set; }




        public Cliente()
        {

        }

        public Cliente(int id, string rut, string nombre, DateTime antiguedad, List<Producto> productos)
        {
            Id = id;
            Rut = rut;
            Nombre = nombre;
            Antiguedad = antiguedad;
            Productos = productos;
        }

        public int Descuento()
        {

            return DateTime.Today.AddTicks(-this.Antiguedad.Ticks).Year - 1;

            
        }

        
    }
}
