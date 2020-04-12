using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Clases
{
    public class Usuario
    {


        public string CI { get; set; }

        public string Password { get; set; }

        public string Rol { get; set; }

        public Usuario(string ci, string password, string rol)
        {
            this.CI = ci;
            this.Password = password;
            this.Rol = rol;
        }

    }
}
