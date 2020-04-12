using Servicio.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Servicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioUsuario" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioUsuario
    {
        [OperationContract]
        bool AltaUsuario(UsuarioDTO usuario);

        [OperationContract]
        bool BajaUsuario(int usuarioId);

        [OperationContract]
        bool ModificarUsuario(UsuarioDTO usuario);

        [OperationContract]
        List<UsuarioDTO> TraerTodos();

        [OperationContract]
        UsuarioDTO BuscarUsuario(int usuarioId);
    }
}
