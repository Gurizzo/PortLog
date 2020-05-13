using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

using System.Web;
using System.Web.WebPages.Html;

namespace MVC.ViewModels.Usuario
{
    public class ViewModelUsuario
    {
        [Display(Name = "Cedula"), Required]
        [MaxLength(8, ErrorMessage = "La cedula debe tener al menos 8 caracteres")]
        [MinLength(7, ErrorMessage = "La cedula debe tener al menos 7 caracteres")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "La cedula debe tener de 8 a 9 digitos y sin puntos ni guiones")]
        public string CI { get; set; }

        [Display(Name = "Contraseña"), Required]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "La debe tener al menos 6 caracteres")]
        [RegularExpression(@"^(?=\w*\d)(?=\w*[A-Z])(?=\w*[a-z])\S{6,16}$", ErrorMessage = "La contraseña debe tener al menos 6 caracteres una mayuscula una minuscula y un numero")]
        public string Password { get; set; }

        [Display(Name = "Repita Contraseña"), Required]
        [Compare("Password", ErrorMessage = "Las contraseñas deben coincidir")]
        [DataType(DataType.Password)]
        public string Password2 { get; set; }

        [Required]
        [Display(Name = "Rol")]
        public string Rol { get; set; }


        
    }
}