using Dominio.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces
{
    public interface IRepoUsuario:IRepositorio<Usuario>
    {
        Usuario ValidarLogin(string ci, string password);
    }
}
