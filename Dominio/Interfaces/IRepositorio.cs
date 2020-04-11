using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces
{
    public interface IRepositorio<T>
    {
        bool Alta(T obj);
        bool Baja(T obj);
        bool Modificar(T obj);
        List<T> Todos();
        T BuscarPorId(int id);
    }
}
