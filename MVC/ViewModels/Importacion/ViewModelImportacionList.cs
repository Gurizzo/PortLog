﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.ViewModels.Importacion
{
    public class ViewModelImportacionList
    {
        

        [Display(Name = "Ingreso"), Required]
        [DataType(DataType.Date)]
        public DateTime FchIngreso { get; set; }

        [Display(Name = "Salida estimada"), Required]
        [DataType(DataType.Date)]
        public DateTime FchSalida { get; set; }

        [Display(Name = "Producto"), Required]
        public string Producto { get; set; }

        [Display(Name = "Cantidad"), Required]
        public int Cantidad { get; set; }


        [Display(Name = "Cliente"), Required]
        public string Cliente { get; set; }

        [Display(Name = "Pais de destino"), Required]
        public string Pais { get; set; }

        [Display(Name = "Almacenado"), Required]
        public bool Enviado { get; set; }
    }
}