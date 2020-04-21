using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.ViewModels.Usuario
{
    public class ViewModelUsuario
    {
        [Display (Name="Cedula"), Required]
        public string CI { get; set; }

        [Display(Name = "Contraseña"), Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Repita Contraseña"), Required]
        [Compare("Password", ErrorMessage = "Las contraseñas deben coincidir")]
        [DataType(DataType.Password)]
        public string Password2 { get; set; }
    }
}