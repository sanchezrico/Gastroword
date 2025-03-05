using Microsoft.AspNetCore.Mvc;

namespace GastroWorld.Controllers
{
    public class PerfilUSController : Controller
    {
        public IActionResult perfil()
        {
            return View("perfil");
        }
    }
}
