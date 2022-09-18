using Microsoft.AspNetCore.Mvc;

namespace Unidad1Act1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Perfil()
        {
            return View();
        }
    }
}
