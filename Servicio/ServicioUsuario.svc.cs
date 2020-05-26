using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Dominio.Clases;
using Dominio.Interfaces;
using Dominio.Repositorio;
using Servicio.DTO;

namespace Servicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioUsuario" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicioUsuario.svc o ServicioUsuario.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioUsuario : IServicioUsuario
    {
        RepositorioUsuario Repo = new RepositorioUsuario();

        public Boolean Alta(string cedula, string password,string rol)
        {
            Boolean respuesta = false;
            if(cedula!=null && password != null && rol != null)
            {
                Usuario u = new Usuario()
                {
                    CI = cedula,
                    Password = password,
                    Rol = rol
                };
                if (u.Validar())
                {
                    respuesta = Repo.Alta(u);
                }
                
            }

            return respuesta;
        }

        public UsuarioDTO Logear(string ci, string password)
        {
            UsuarioDTO usuario = new UsuarioDTO();
            Usuario u = new Usuario()
            {
                CI = ci,
                Password = password
            };


            u = Repo.ValidarLogin(ci, password);

            if (u != null)
            {
                usuario.Id = u.Id;
                usuario.CI = u.CI;
                usuario.Password = u.Password;
                usuario.Rol = u.Rol;
            }
            else
            {
                usuario = null;
            }

            return usuario;


        }



        public List<ClienteDTO> DatosClientes()
        {
            RepositorioCliente Repo = new RepositorioCliente();
            
            List<ClienteDTO> dTOs = new List<ClienteDTO>();
            var clientes = Repo.Todos();

            foreach (Cliente i in clientes)
            {
                ClienteDTO dTO = new ClienteDTO()
                {
                    Antiguedad = i.Antiguedad,
                    Id = i.Id,
                    Nombre = i.Nombre,
                    Rut = i.Rut
                };
                dTOs.Add(dTO);
            }

            return dTOs;
        }

        public List<string> DatosDescuentos()
        {
            //Hay que hacerlo?
            throw new NotImplementedException();
        }

        public List<ImportacionDTO> DatosImportacion()
        {
            RepositorioImportacion repositorio = new RepositorioImportacion();
            List<ImportacionDTO> dTOs = new List<ImportacionDTO>();
            var Importaciones = repositorio.Todos();

            foreach (Importacion i in Importaciones)
            {
                ImportacionDTO dTO = new ImportacionDTO()
                {
                    Cantidad = i.Cantidad,
                    Enviado = i.Almacenado,
                    FchIngreso = i.FchIngreso,
                    FchSalida = i.FchSalida,
                    Pais = new PaisDTO()
                    {
                        IdPais = i.Pais.Id
                    },
                    Producto = new ProductoDTO()
                    {
                        Id = i.Producto.Id
                    }
                };
                dTOs.Add(dTO);
            }

            return dTOs;
        }

        public List<ProductoDTO> DatosProductos()
        {
            RepositorioProducto repoProducto = new RepositorioProducto();
            List<ProductoDTO> dTOs = new List<ProductoDTO>();
            var productos = repoProducto.Todos();// Falta implementar

            foreach (Producto p in productos)
            {
                ProductoDTO dTO = new ProductoDTO()
                {
                    Codigo = p.Codigo,
                    Id = p.Id,
                    Nombre = p.Nombre,
                    Peso = p.Peso,
                    Precio = p.Precio,
                    Cliente = new ClienteDTO()
                    {
                        Id = p.Cliente.Id
                    }
                };
                dTOs.Add(dTO);
            }


            return dTOs;
        }

        public List<UsuarioDTO> DatosUsuarios()
        {
            List<UsuarioDTO> dTOs = new List<UsuarioDTO>();
            var usuarios = Repo.Todos();//IMPLEMENTAR
            foreach (Usuario u in usuarios)
            {
                UsuarioDTO dTO = new UsuarioDTO()
                {
                    CI= u.CI,
                    Password= u.Password,
                    Rol=u.Rol
                };
                dTOs.Add(dTO);
            }




            return dTOs;
        }

        



    }
}
