using Servicio.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Servicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioImportacion" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioImportacion
    {
        [OperationContract]
        bool AltaImportacion(ImportacionDTO importacion);

        [OperationContract]
        bool BajaImportacion(int importacionId);

        [OperationContract]
        bool ModificarImportacion(ImportacionDTO importacion);

        [OperationContract]
        List<ImportacionDTO> TraerTodos();

        [OperationContract]
        ImportacionDTO BuscarImportacion(int genId);
    }
}
