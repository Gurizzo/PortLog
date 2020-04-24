using MVC.ViewModels.Importacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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

            return View(vm);
        }

    }
}
