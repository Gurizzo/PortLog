using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC.ViewModels.Cliente
{
    public class ViewModelClienteList
    {
        [Display(Name = "RUT")]
        public string Rut { get; set; }

        [Display(Name ="Nombre del cliente")]
        public string Nombre { get; set; }

        [Display(Name ="Antiguedad")]
        [DataType(DataType.Date)]   /*Le da formato a la fecha y no usa la hora :D */
        public DateTime Antiguedad { get; set; }
    }
}