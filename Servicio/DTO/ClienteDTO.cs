using Dominio.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Servicio.DTO
{
    [DataContract]
    public class ClienteDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Rut { get; set; }

        [DataMember]
        public string Nombre { get; set; }

        [DataMember]
        public DateTime Antiguedad { get; set; }

        [DataMember]
        public List<ProductoDTO> Productos { get; set; }

        
    }
}