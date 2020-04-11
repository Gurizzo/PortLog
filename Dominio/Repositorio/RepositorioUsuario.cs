using Dominio.Clases;
using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Repositorio
{
    public class RepositorioUsuario : IRepoUsuario
    {
        public bool Alta(Usuario obj)
        {
            throw new NotImplementedException();
        } 

        public bool Baja(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public Usuario BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public bool Modificar(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> Todos()
        {
            throw new NotImplementedException();
        }
    }
}
