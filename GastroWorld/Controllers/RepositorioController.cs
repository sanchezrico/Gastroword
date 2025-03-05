using Microsoft.AspNetCore.Mvc;

namespace GastroWorld.Controllers
{
    public class RepositorioController : Controller
    {
        public IActionResult Repositorio()
        {
            return View("Repositorio");
        }
    }
}
