using Dominio.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Servicio.DTO
{
    [DataContract]
    public class ProductoDTO
    {
        [DataMember]
        public int Codigo { get; set; }

        [DataMember]
        public string Nombre { get; set; }

        [DataMember]
        public int Stock { get; set; }

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public decimal Peso { get; set; }

        [DataMember]
        public Cliente Cliente { get; set; }

        [DataMember]
        public decimal Precio { get; set; }
    }
}