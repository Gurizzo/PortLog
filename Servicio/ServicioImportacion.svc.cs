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

            Importacion i = new Importacion()
            {
                Cantidad = importacion.Cantidad,
                Almacenado =true,
                Precio = importacion.Producto.Precio,
                FchIngreso = DateTime.Today,
                FchSalida = importacion.FchSalida,
                /*Producto = importacion.Producto,
                Pais = importacion.Pais*/
                
                
                
            };
            
            

            return Repo.Alta(i);
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

        public ProductoDTO TraerDatos(int codigo)
        {
            RepositorioProducto Repo = new RepositorioProducto();
            
            var producto = Repo.BuscarPorCodigo(codigo);

            ProductoDTO dTO = new ProductoDTO()
            {
                Cliente = new ClienteDTO
                {
                    Id=producto.Cliente.Id,
                    Nombre=producto.Cliente.Nombre
                },
                Id=producto.Id,
                Nombre=producto.Nombre,
                Peso=producto.Peso,
                Precio=producto.Precio,
                

            };


            return dTO;
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
                        Producto = new ProductoDTO()
                        {
                            Id = i.Producto.Id,
                            Nombre= i.Producto.Nombre,
                            Cliente = new ClienteDTO()
                            {
                                Id= i.Producto.Cliente.Id,
                                Nombre= i.Producto.Cliente.Nombre
                            }
                            
                        },
                        Pais = new PaisDTO()
                        {
                            IdPais= i.Pais.Id,
                            NombrePais= i.Pais.Nombre
                        },
                        Cantidad = i.Cantidad,
                        FchIngreso = i.FchIngreso,
                        FchSalida = i.FchSalida,
                        Enviado = i.Almacenado
                    };
                    importacionDTO.Add(dto);
                }
            }
            return importacionDTO;
            

           
        }


    }
}
