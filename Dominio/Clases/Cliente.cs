using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Clases
{
    public class Cliente
    {
        public string rut { get; set; }

        public string nombre { get; set; }

        public Cliente(string rut, string nombre)
        {
            this.rut = rut;
            this.nombre = nombre;
        }
    }
}
