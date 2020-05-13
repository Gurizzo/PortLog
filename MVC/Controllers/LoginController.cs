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
using System.IO;

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
                if (usuarioDto.Rol.ToUpper() == "ADMIN")
                {
                    
                    Session["Rol"] = usuarioDto.Rol.ToUpper();
                    return RedirectToAction("Create","Login");//Redirigir a donde corresponda admin 
                }
                else
                {
                    Session["Rol"] = usuarioDto.Rol.ToUpper();
                    return RedirectToAction("Productos","Producto");//Redirigir a donde corresponda almacen
                }
                

            }
            //Caso de error al logear.
            TempData["Fail"] = "Error al conectar, verifique los datos ingresados";

            return View(u);//Redirigir a donde corresponda
        }

        [HttpGet]
        public ActionResult Create()
        {
            if (Session["Rol"] == null || Session["Rol"].ToString().ToUpper() != "ADMIN")
            {
                return RedirectToAction("Login", "Login");
            }
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
                "Admin",
                
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

                        proxy.Close();
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

        public ActionResult LogOut()
        {
            Session["Rol"] = null;
            return RedirectToAction("Login");
        }

        public ActionResult Archivos()
        {
            ServicioUsuarioClient proxy = new ServicioUsuarioClient();
            proxy.Open();
            var Clientes = proxy.DatosClientes();
            var Usuario = proxy.DatosUsuarios();
            var Importaciones = proxy.DatosImportacion();
            var Productos = proxy.DatosProductos();
            proxy.Close();

            crearArchivoCliente(Clientes);
            crearArchivoUsuario(Usuario);
            crearArchivoImportacion(Importaciones);
            crearArchivoProducto(Productos);



            return RedirectToAction("List","Cliente");
        }

        #region 

        private void crearArchivoProducto(ProductoDTO[] productos)
        {
            var ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Archivos", "Productos.txt");
            //Directorio raiz               //Carpeta //Nombre del archivo


            using (StreamWriter sw = new StreamWriter(ruta, true)) //el true es para que agregue al final. Si el archivo no existe lo crea.
            {
                foreach (ProductoDTO p in productos)
                {
                    string datos = p.Codigo + "#" + p.Nombre + "#" + p.Precio + "#" + p.Peso + "#" + p.Cliente.Id;
                    sw.WriteLine(datos);
                }

            }
        }

        private void crearArchivoImportacion(ImportacionDTO[] importaciones)
        {
            var ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Archivos", "Importaciones.txt");
            //Directorio raiz               //Carpeta //Nombre del archivo


            using (StreamWriter sw = new StreamWriter(ruta, true)) //el true es para que agregue al final. Si el archivo no existe lo crea.
            {
                foreach (ImportacionDTO i in importaciones)
                {
                    string datos = i.FchIngreso.ToShortDateString() + "#" + i.FchSalida.ToShortDateString() + "#" + i.Producto.Id + "#" + i.Producto.Precio + "#" + i.Cantidad + "#" + i.Pais.IdPais + "#" + i.Enviado;
                    sw.WriteLine(datos);
                }

            }
        }

        private void crearArchivoUsuario(UsuarioDTO[] usuario)
        {
            var ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Archivos", "Usuario.txt");
            //Directorio raiz               //Carpeta //Nombre del archivo


            using (StreamWriter sw = new StreamWriter(ruta, true)) //el true es para que agregue al final. Si el archivo no existe lo crea.
            {
                foreach (UsuarioDTO u in usuario)
                {
                    string datos = u.CI + "#" + u.Password + "#" + u.Rol;
                    sw.WriteLine(datos);
                }

            }


        }

        private void crearArchivoCliente(ClienteDTO[] clientes)
        {
            var ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Archivos", "Cliente.txt");
            //Directorio raiz               //Carpeta //Nombre del archivo


            using (StreamWriter sw = new StreamWriter(ruta, true)) //el true es para que agregue al final. Si el archivo no existe lo crea.
            {
                foreach (ClienteDTO c in clientes)
                {
                    string datos = c.Rut + "#" + c.Nombre + "#" + c.Antiguedad.ToShortDateString();
                    sw.WriteLine(datos);
                }

            }


        }

        #endregion//Archivos
    }


}
