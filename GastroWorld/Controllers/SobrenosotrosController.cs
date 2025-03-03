using Microsoft.AspNetCore.Mvc;

namespace GastroWorld.Controllers
{
    public class SobrenosotrosController : Controller
    {
        public IActionResult Sobrenosotros()
        {
            return View("Sobrenosotros");
        }
    }
}
