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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioProducto" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicioProducto.svc o ServicioProducto.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioProducto : IServicioProducto
    {
        IRepoProducto repo = new RepositorioProducto();

        public bool AltaProducto(ProductoDTO producto)
        {
            throw new NotImplementedException();
        }

        public bool BajaProducto(int productoId)
        {
            throw new NotImplementedException();
        }

        public ProductoDTO BuscarProducto(int productoId)
        {
            throw new NotImplementedException();
        }

        public bool ModificarProducto(ProductoDTO producto)
        {
            throw new NotImplementedException();
        }

        public List<ProductoDTO> TraerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
