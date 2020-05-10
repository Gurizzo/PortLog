using MVC.ViewModels.Importacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC.ServiceReferenceImportacion;
using System.Web.Mvc;
using MVC.ServiceReferencePais;

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
        public ActionResult Create(int codigo)
        {

            
            ServicioImportacionClient proxy = new ServicioImportacionClient();
            proxy.Open();
            var datos = proxy.TraerDatos(codigo);
            ViewModelImportacionAlta viewModel = new ViewModelImportacionAlta()
            {
                Cliente = datos.Cliente.Nombre,
                Nombre = datos.Nombre,
                Codigo = codigo,
                idCliente = datos.Cliente.Id,
                idProducto = datos.Id,
                Peso = datos.Peso,
                Precio = datos.Precio
            };

            ViewBag.Paises = Paises();


            return View(viewModel);
        }

        private List<SelectListItem> Paises()
        {
            List<SelectListItem> paiseslistItems = new List<SelectListItem>();

            ServicioPaisClient proxy = new ServicioPaisClient();
                proxy.Open();
                var paises = proxy.TraerTodos().ToList();

            foreach (PaisDTO pais in paises)
            {
                paiseslistItems.Add(new SelectListItem
                {
                    Text = pais.NombrePais,
                    Value = pais.IdPais.ToString()
                });
            }

            return paiseslistItems;
        }

        [HttpPost]
        public ActionResult Create(ViewModelImportacionAlta vm)
        {
            if (vm.FchSalida <= DateTime.Today)
            {
                //No capo
            }
            else
            {
                ServicioImportacionClient proxy = new ServicioImportacionClient();
                var datos = proxy.TraerDatos(vm.Codigo);
                ImportacionDTO dTO = new ImportacionDTO()
                {
                    Cantidad = vm.Cantidad,
                    Enviado = false,
                    FchIngreso = DateTime.Today,
                    FchSalida = vm.FchSalida,
                    Pais = new Dominio.Clases.Pais
                    {
                        Id = Int32.Parse(vm.Pais)
                    },
                    Producto = new Dominio.Clases.Producto
                    {
                        Id = datos.Id,
                        Peso = datos.Peso,
                        Precio = datos.Precio,
                        Cliente = new Dominio.Clases.Cliente
                        {
                            Id = datos.Cliente.Id
                        }
                    },



                };
                if (proxy.AltaImportacion(dTO))
                {
                    //ENTRO
                    return RedirectToAction("Lista");
                }
                else
                {
                    //PUES NO
                }
            }
            

            return RedirectToAction("Lista");
        }

    }
}
