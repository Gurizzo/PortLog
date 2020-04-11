using Dominio.Clases;
using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Repositorio
{
    public class RepositorioProducto : IRepoProducto
    {
        public bool Alta(Producto obj)
        {
            throw new NotImplementedException();
        }

        public bool Baja(Producto obj)
        {
            throw new NotImplementedException();
        }

        public Producto BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public bool Modificar(Producto obj)
        {
            throw new NotImplementedException();
        }

        public List<Producto> Todos()
        {
            throw new NotImplementedException();
        }
    }
}
