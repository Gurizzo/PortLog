using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Dominio.Clases;
using Dominio.Repositorio;
using Servicio.DTO;

namespace Servicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioImportacion" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicioImportacion.svc o ServicioImportacion.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioImportacion : IServicioImportacion
    {
        RepositorioImportacion Repo = new RepositorioImportacion();

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
            List<ImportacionDTO> importacionDTO = new List<ImportacionDTO>();
            List<Importacion> impo = new List<Importacion>();
            impo = Repo.Todos();
            if (impo!=null)
            {
                foreach (Importacion i in impo)
                {
                    ImportacionDTO dto = new ImportacionDTO()
                    {
                        Producto = i.Producto,
                        Cantidad = i.Cantidad,
                        Cliente = i.Producto.Cliente,
                        FchIngreso = i.FchIngreso,
                        FchSalida = i.FchSalida,
                        Pais = i.Pais,
                        Enviado = i.Enviado
                    };
                    importacionDTO.Add(dto);
                }
            }
            return importacionDTO;
            

           
        }
    }
}
