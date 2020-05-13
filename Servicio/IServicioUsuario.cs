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
        Boolean Alta(string cedula, string password, string rol);

        [OperationContract]
        UsuarioDTO Logear(string ci,string password);

        [OperationContract]
        List<ImportacionDTO> DatosImportacion();

        [OperationContract]
        List<ProductoDTO> DatosProductos();

        [OperationContract]
        List<ClienteDTO> DatosClientes();

        [OperationContract]
        List<UsuarioDTO> DatosUsuarios();

        [OperationContract]
        List<string> DatosDescuentos();



    }
}
