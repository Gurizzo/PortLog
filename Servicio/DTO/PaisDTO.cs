using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Servicio.DTO
{
    [DataContract]
    public class PaisDTO
    {
        [DataMember]
        public int IdPais { get; set; }
        [DataMember]
        public string CodPais { get; set; }
        [DataMember]
        public string NombrePais { get; set; }
    }
}