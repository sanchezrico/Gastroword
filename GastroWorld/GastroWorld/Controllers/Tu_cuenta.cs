using Microsoft.AspNetCore.Mvc;

namespace GastroWorld.Controllers
{
    public class Tu_cuentaController : Controller
    {
        public IActionResult Tu_cuenta()
        {
            return View("Tu_cuenta");
        }
    }
}
