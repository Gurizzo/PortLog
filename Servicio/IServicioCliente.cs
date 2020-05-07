using Servicio.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Servicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioCliente" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioCliente
    {
        [OperationContract]
        bool AltaCliente(ClienteDTO cliente);

        [OperationContract]
        bool BajaCliente(int clienteId);

        [OperationContract]
        bool ModificarCliente(ClienteDTO cliente);

        [OperationContract]
        List<ClienteDTO> TraerTodos();

        [OperationContract]
        ClienteDTO BuscarCliente(int clienteId);

        [OperationContract]
        decimal CalcularGanancia(int id);
    }
}
