using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.ServiceReferenceProducto;
using MVC.ViewModels.Producto;

namespace MVC.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Productos()
        {
            List <ViewModelProducto>  vm = new List<ViewModelProducto>();
            List<ProductoDTO> dTOs = new List<ProductoDTO>();
            ServicioProductoClient proxy = new ServicioProductoClient();
            proxy.Open();
            dTOs = proxy.TraerTodosStock().ToList();

            foreach (ProductoDTO d in dTOs)
            {
                ViewModelProducto vmp = new ViewModelProducto()
                {
                    Codigo= d.Codigo,
                    Nombre= d.Nombre,
                    Stock=d.Stock
                };
                vm.Add(vmp);
            }

            return View(vm);
        }
        
    }
}
