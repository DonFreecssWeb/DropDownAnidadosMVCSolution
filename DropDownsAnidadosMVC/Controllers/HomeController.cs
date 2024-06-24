using DropDownsAnidadosMVC.Models;
using DropDownsAnidadosMVC.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DropDownsAnidadosMVC.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _contextdb;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext contextdb)
        {
            _logger = logger;
            _contextdb = contextdb;
        }

        public IActionResult Index()
        {
            var sucursales = _contextdb.Sucursal.ToList();

            DropDownsVM vm = new DropDownsVM();
            vm.ListaSucursal = sucursales;
            return View(vm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public JsonResult ObtenerCategorias(int sucursalID)
        {
            var categorias  = _contextdb.Categoria.Where(temp => temp.SucursalID == sucursalID).ToList();
            return Json(categorias);
        }

        [HttpGet]
        public JsonResult ObtenerProductos(int categoriaID)
        {
            var productos = _contextdb.Producto.Where(temp => temp.CategoriaID == categoriaID).ToList();
            return Json(productos);
        }
    }
}
