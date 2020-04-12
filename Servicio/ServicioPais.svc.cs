using Dominio;
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
        IRepoPais repo = new RepositorioPais();

        public PaisDTO BuscarPais(int paisId)
        {
            throw new NotImplementedException();
        }

        public List<PaisDTO> TraerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
