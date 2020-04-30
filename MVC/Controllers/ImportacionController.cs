using MVC.ViewModels.Importacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC.ServiceReferenceImportacion;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class ImportacionController : Controller
    {
        // GET: Importacion
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Lista()
        {
            List<ViewModelImportacionList> vm = new List<ViewModelImportacionList>();
            List<ImportacionDTO> dto = new List<ImportacionDTO>();
            ServicioImportacionClient proxy = new ServicioImportacionClient();
            proxy.Open();
            
            dto = proxy.TraerTodos().ToList();
            foreach(ImportacionDTO i in dto)
            {
                ViewModelImportacionList v = new ViewModelImportacionList()
                {
                    Cantidad = i.Cantidad,
                    Cliente = i.Producto.Cliente.Nombre,
                    Enviado = i.Enviado,
                    FchIngreso= i.FchIngreso,
                    FchSalida = i.FchSalida,
                    Pais= i.Pais.Nombre,
                    Producto = i.Producto.Nombre
                };
                vm.Add(v);
            }

            return View(vm);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

    }
}
