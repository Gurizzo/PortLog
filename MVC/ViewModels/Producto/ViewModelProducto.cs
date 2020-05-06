using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.ViewModels.Producto
{
    public class ViewModelProducto
    {

        [Display(Name = "Codigo"), Required]
        public int Codigo { get; set; }

        [Display(Name = "Nombre del producto"), Required]
        public string Nombre { get; set; }

        [Display(Name = "Cantidad en deposito"), Required]
        public int Stock { get; set; }
    }
}