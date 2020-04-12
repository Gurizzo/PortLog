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
        public string Rut { get; set; }

        [DataMember]
        public string Nombre { get; set; }
    }
}