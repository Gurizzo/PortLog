using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Clases
{
    public class Pais
    {
        

        public string CodPais { get; set; }

        public string Nombre { get; set; }

        public Pais(string codPais, string nombre)
        {
            this.CodPais = codPais;
            this.Nombre = nombre;
        }
    }
}
