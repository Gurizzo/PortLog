using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.ViewModels.Importacion
{
    public class ViewModelImportacionAlta
    {
        public int idProducto { get; set; }
        public int idCliente { get; set; }

        [Display(Name = "Codigo"), Required]
        public int Codigo { get; set; }

        [Display(Name = "Nombre del producto"), Required]
        public string Nombre { get; set; }

        [Display(Name = "Peso"), Required]
        public decimal Peso { get; set; }

        [Display(Name = "Cliente"), Required]
        public string Cliente { get; set; }

        [Display(Name = "Precio"), Required]
        public decimal Precio { get; set; }

        [Display(Name = "Cantidad"), Required]
        public int Cantidad { get; set; }

        [Display(Name = "Fecha salida estimada"), Required]
        [DataType(DataType.Date)]
        public DateTime FchSalida { get; set; }

        [Display(Name = "Paise destino"), Required]
        public string Pais { get; set; }

    }
}