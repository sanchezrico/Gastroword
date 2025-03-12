using Microsoft.AspNetCore.Mvc;

namespace GastroWorld.Controllers
{
    public class PgprincipalController : Controller
    {
        public IActionResult cargarView()
        {
            return View("cargarView");
        }
    }
}