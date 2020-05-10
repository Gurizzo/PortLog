using Dominio;
using Dominio.Clases;
using Dominio.Interfaces;
using Dominio.Repositorio;
using Servicio.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Servicio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioPais" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicioPais.svc o ServicioPais.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioPais : IServicioPais
    {
        RepositorioPais Repo = new RepositorioPais();

        public PaisDTO BuscarPais(int paisId)
        {
            throw new NotImplementedException();
        }

        public List<PaisDTO> TraerTodos()
        {
            List<PaisDTO> dTOs = new List<PaisDTO>();
            var list=Repo.Todos();

            foreach (Pais p in list)
            {
                PaisDTO dTO = new PaisDTO()
                {
                    CodPais=p.CodPais,
                    IdPais=p.Id,
                    NombrePais=p.Nombre
                };
                dTOs.Add(dTO);
            }
            return dTOs;
        }
    }
}
