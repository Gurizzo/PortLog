using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Clases
{
    public class Cliente
    {
        public string Rut { get; set; }

        public string Nombre { get; set; }

        public Cliente(string rut, string nombre)
        {
            this.Rut = rut;
            this.Nombre = nombre;
        }
    }
}
