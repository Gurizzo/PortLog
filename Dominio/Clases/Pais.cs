using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Clases
{
    public class Pais
    {
        

        public string codPais { get; set; }

        public string nombre { get; set; }

        public Pais(string codPais, string nombre)
        {
            this.codPais = codPais;
            this.nombre = nombre;
        }
    }
}
