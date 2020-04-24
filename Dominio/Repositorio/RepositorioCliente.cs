using Dominio.Clases;
using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Repositorio
{
    public class RepositorioCliente : IRepoCliente
    {
        
        
        public bool Alta(Cliente obj)
        {
            throw new NotImplementedException();
        }

        public bool Baja(Cliente obj)
        {
            throw new NotImplementedException();
        }

        public Cliente BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public bool Modificar(Cliente obj)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> Todos()
        {
            Persistente persistente = new Persistente();
            persistente.ObtenerConexion();


            throw new NotImplementedException();
        }

        public bool Validar(Cliente obj)
        {
            throw new NotImplementedException();
        }
    }
}
