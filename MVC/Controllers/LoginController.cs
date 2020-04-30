using Dominio.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC.ServiceReferenceUsuario;
using MVC.ViewModels.Usuario;
using System.Web.Mvc;
using System.Web.WebPages.Html;
using SelectListItem = System.Web.WebPages.Html.SelectListItem;

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

            ServicioUsuarioClient usuario = new ServicioUsuarioClient();
            usuario.Open();
            UsuarioDTO usuarioDto = usuario.Logear(u.CI, u.Password);
            
            usuario.Close();
            if (usuarioDto != null)
            {//Caso exitoso de login
                Session["Rol"] = usuarioDto.Rol;
                if (usuarioDto.Rol == "admin")
                {
                    return RedirectToAction("admin");//Redirigir a donde corresponda admin
                }
                return RedirectToAction("Almacen");//Redirigir a donde corresponda almacen

            }
            //Caso de error al logear.


            return View(u);//Redirigir a donde corresponda
        }

        [HttpGet]
        public ActionResult Create()
        {
            //Dibujo la vista
            ViewModelUsuario u = new ViewModelUsuario();

            
            ViewBag.Roles = Roles();



            return View(u);
        }

        private List<string> Roles()//Precargar roles
        {
            List<string> roles = new List<string>
            {
                "Almacen",
                "Admin"
            };

            return roles;
        }

        [HttpPost]
        public ActionResult Create(ViewModelUsuario u)
        {
            ViewModelUsuario model = new ViewModelUsuario();
            try
            {
                if (u.Password == u.Password2)
                {//Contraseña escrita bien 2 veces.
                    if(u.Password.Contains("#") || u.CI.Contains("#"))
                    {
                        TempData["Fail"] = "No se permite el uso del caracter #";
                        return RedirectToAction("Create", "Login");
                    }
                    else
                    {
                        ServicioUsuarioClient proxy = new ServicioUsuarioClient();
                        proxy.Open();
                        Boolean respuesta;

                        respuesta = proxy.Alta(u.CI, u.Password, u.Rol);
                        if (respuesta)
                        {
                            TempData["Alta"] = "Alta exitosa";
                            return RedirectToAction("Create", "Login");
                        }
                        else
                        {
                            TempData["Fail"] = "El usuario ya existe";
                            return RedirectToAction("Create", "Login");
                        }
                    }

                }

            }
            finally
            {
                
                ViewBag.Roles = Roles();
                
            }
            return View(model);

        }
    }
    
}
