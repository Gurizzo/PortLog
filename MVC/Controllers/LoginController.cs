using Dominio.Clases;
using Servicio;
using Servicio.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MVC.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login(string ci,string password)
        {
            Usuario u = new Usuario();

            if(ci!="" && password != "")
            {
                
                u.CI = ci;
                u.Password = password;
                
            }

            return View(u);
        }

        [HttpPost]
        public ActionResult Login(Usuario u)
        {
            ServicioUsuario usuario = new ServicioUsuario();

            UsuarioDTO usuarioDto = usuario.Validar(u.CI, u.Password);
            if (usuarioDto!=null)
            {//Caso exitoso de login
                
                Session["Rol"] = usuarioDto.Rol;
            }
            //Caso de error al logear.


            return RedirectToAction("prueba");//Redirigir a donde corresponda
        }
    }
}
