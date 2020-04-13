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

        public List<Producto> Productos { get; set; }

        public Cliente(int id, string rut, string nombre)
        {
            Id = id;
            Rut = rut;
            Nombre = nombre;
        }

        public Cliente()
        {

        }

    }
}
