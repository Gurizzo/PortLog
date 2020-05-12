using Dominio.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Servicio.DTO
{
    [DataContract]
    public class ImportacionDTO
    {
        [DataMember]
        public DateTime FchIngreso { get; set; }

        [DataMember]
        public DateTime FchSalida { get; set; }

        [DataMember]
        public ProductoDTO Producto { get; set; }

        [DataMember]
        public int Cantidad { get; set; }


        [DataMember]
        public PaisDTO Pais { get; set; }

        [DataMember]
        public bool Enviado { get; set; }
    }
}