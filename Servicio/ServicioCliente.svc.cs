using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Dominio.Interfaces;
using Dominio.Repositorio;
using Servicio.DTO;

namespace Servicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioCliente" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicioCliente.svc o ServicioCliente.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioCliente : IServicioCliente
    {
        IRepoCliente repo = new RepositorioCliente();

        public bool AltaCliente(ClienteDTO cliente)
        {
            throw new NotImplementedException();
        }

        public bool BajaCliente(int clienteId)
        {
            throw new NotImplementedException();
        }

        public ClienteDTO BuscarCliente(int clienteId)
        {
            throw new NotImplementedException();
        }

        public bool ModificarCliente(ClienteDTO cliente)
        {
            throw new NotImplementedException();
        }

        public List<ClienteDTO> TraerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
