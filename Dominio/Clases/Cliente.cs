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

        public bool Descuento()
        {
            if(this.Antiguedad.Year< DateTime.Now.Year)
            {
                if (this.Antiguedad.Month >= DateTime.Now.Month)
                {
                    if (this.Antiguedad.Month == DateTime.Now.Month && this.Antiguedad.Day >= DateTime.Now.Day)
                    {
                        if(DateTime.Now.Year - this.Antiguedad.Year >= 5)
                        {
                            return true;
                        }
                    }
                }
            }
            
            return false;//Devuelve si corresponde o no descuento.
        }

        
    }
}
