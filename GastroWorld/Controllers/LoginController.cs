using Microsoft.AspNetCore.Mvc;

namespace GastroWorld.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View("Login");
        }
    }
}
