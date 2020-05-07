using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.ViewModels.Cliente
{
    public class ViewModelClienteGanancia
    {
        [Display(Name = "Ganancia potencial")]
        public decimal Previcion { get; set; }
    }
}