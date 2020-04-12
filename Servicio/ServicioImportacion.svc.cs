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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioImportacion" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicioImportacion.svc o ServicioImportacion.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioImportacion : IServicioImportacion
    {
        IRepoImportacion repo = new RepositorioImportacion();

        public bool AltaImportacion(ImportacionDTO importacion)
        {
            throw new NotImplementedException();
        }

        public bool BajaImportacion(int importacionId)
        {
            throw new NotImplementedException();
        }

        public ImportacionDTO BuscarImportacion(int genId)
        {
            throw new NotImplementedException();
        }

        public bool ModificarImportacion(ImportacionDTO importacion)
        {
            throw new NotImplementedException();
        }

        public List<ImportacionDTO> TraerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
