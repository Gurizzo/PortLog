using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Clases
{
    class Usuario
    {


        public string ci { get; set; }

        public string password { get; set; }

        public string rol { get; set; }

        public Usuario(string ci, string password, string rol)
        {
            this.ci = ci;
            this.password = password;
            this.rol = rol;
        }

    }
}
