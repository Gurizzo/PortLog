using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Servicio.DTO
{
    [DataContract]
    public class UsuarioDTO
    {
        [DataMember]
        public string CI { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public string Rol { get; set; }
    }
}