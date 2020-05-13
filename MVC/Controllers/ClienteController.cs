using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.ServiceReferenceCliente;
using MVC.ViewModels.Cliente;

namespace MVC.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            return View();
        }

        // GET: Cliente/Details/5
        public ActionResult Details(int id)
        {
            if (Session["Rol"] == null || Session["Rol"].ToString().ToUpper() != "ADMIN")
            {
                return RedirectToAction("Login", "Login");
            }

            ServicioClienteClient proxy = new ServicioClienteClient();
            ViewModelClienteGanancia vm = new ViewModelClienteGanancia()
            {
                Previcion = proxy.CalcularGanancia(id)
            };
            
            return View(vm);
        }

        public ActionResult List()
        {
            if (Session["Rol"] == null || Session["Rol"].ToString().ToUpper() != "ADMIN")
            {
                return RedirectToAction("Login", "Login");
            }

            List<ViewModelClienteList> vml = new List<ViewModelClienteList>();
            try
            {
                
                ServicioClienteClient proxy = new ServicioClienteClient();
                proxy.Open();
                var dtos = proxy.TraerTodos();

                foreach (ClienteDTO dTO in dtos)
                {
                    ViewModelClienteList obj = new ViewModelClienteList()
                    {
                        Id=dTO.Id,
                        Antiguedad= dTO.Antiguedad,
                        Nombre= dTO.Nombre,
                        Rut=dTO.Rut
                    };
                    vml.Add(obj);
                }


                proxy.Close();
            }
            catch
            {

            }
            finally
            {
                
            }
            

            


            return View(vml);
        }






    }

    
}
