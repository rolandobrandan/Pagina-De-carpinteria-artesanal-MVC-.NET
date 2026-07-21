using System.Diagnostics;
using CarpinteriaArtesanal.Data;
using CarpinteriaArtesanal.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarpinteriaArtesanal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var lista = new ListaProductos();
            var Listas_Productos = lista.GetProductos();
            return View(Listas_Productos);
            
        }
        public IActionResult Contacto()
        {
            return View();
        }
        public IActionResult Nosotros()
        {
            return View();
        }
        //public IActionResult Productos()
        //{
            
        //}
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
