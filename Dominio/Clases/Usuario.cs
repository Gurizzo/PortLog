using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Clases
{
    class Usuario
    {
        

        public int Id { get; set; }

        public string CI { get; set; }

        public string Password { get; set; }

        public string Rol { get; set; }

        public Usuario(int id, string cI, string password, string rol)
        {
            Id = id;
            CI = cI;
            Password = password;
            Rol = rol;
        }

    }
}
