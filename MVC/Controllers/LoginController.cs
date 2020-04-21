using Dominio.Clases;
using Servicio;
using Servicio.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC.ViewModels.Usuario;
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
        public ActionResult Login()
        {
            //Dibujo la vista
            
            ViewModelLogin u = new ViewModelLogin();


            return View(u);
        }

        [HttpPost]
        public ActionResult Login(ViewModelLogin u)
        {

            ServicioUsuario usuario = new ServicioUsuario();

            UsuarioDTO usuarioDto = usuario.Logear(u.CI, u.Password);
            if (usuarioDto != null)
            {//Caso exitoso de login

                Session["Rol"] = usuarioDto.Rol;
            }
            //Caso de error al logear.


            return RedirectToAction("prueba");//Redirigir a donde corresponda
        }

        [HttpGet]
        public ActionResult Create()
        {
            //Dibujo la vista
            ViewModelUsuario u = new ViewModelUsuario();
            return View(u);
        }

        [HttpPost]
        public ActionResult Create(ViewModelUsuario u)
        {
            if (u.Password == u.Password2)
            {
                //Contraseña escrita bien 2 veces.

            }
            return View();
        }
    }
    
}
