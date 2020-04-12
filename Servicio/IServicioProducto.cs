using Servicio.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Servicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioProducto" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioProducto
    {
        [OperationContract]
        bool AltaProducto(ProductoDTO producto);

        [OperationContract]
        bool BajaProducto(int productoId);

        [OperationContract]
        bool ModificarProducto(ProductoDTO producto);

        [OperationContract]
        List<ProductoDTO> TraerTodos();

        [OperationContract]
        ProductoDTO BuscarProducto(int productoId);
    }
}
