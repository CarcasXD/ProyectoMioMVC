using Microsoft.AspNetCore.Mvc;

namespace ProyectoMioMVC.Controllers
{
    public class vistaRazorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult bloqueMultiple()
        {
            return View();
        }

        public IActionResult bucle()
        {
            return View();
        }

    }
}
