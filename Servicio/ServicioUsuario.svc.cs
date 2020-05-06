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
            

            u = Repo.ValidarLogin(ci,password);
            
                if( u.CI!=null)
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
    }
}
