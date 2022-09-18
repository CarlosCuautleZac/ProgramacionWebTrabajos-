using Microsoft.AspNetCore.Mvc;
using Unidad1Act2.Models;

namespace Unidad1Act2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(Calificacion calificacion)
        {
           

            if (calificacion.Materia1 >= 0 && calificacion.Materia1 <= 100 &&
                calificacion.Materia2 >= 0 && calificacion.Materia2 <= 100 &&
                calificacion.Materia3 >= 0 && calificacion.Materia3 <= 100)

                calificacion.Promedio = (calificacion.Materia1 + calificacion.Materia2 + calificacion.Materia3) / 3;
            else
                calificacion.Materia1 = calificacion.Materia2 = calificacion.Materia3 = 0;

            return View(calificacion);
        }
    }
}
