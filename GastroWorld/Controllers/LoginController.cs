using GastroWorld.Models.Repositories;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using GastroWorld.Models.NewFolder;


namespace GastroWorld.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View("Login");
        }
    }

    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly UsuarioRepository _usuarioRepository;

        public AuthController(UsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserLoginRequest model)
        {
            var user = await _usuarioRepository.GetByCredential(model.Usuario, model.Password);

            if (user == null)
                return Unauthorized(new { message = "Credenciales inválidas" });

            return Ok(new
            {
                message = "Inicio de sesión exitoso",
                user = new { user.Id, user.LUsuario, user.Email }
            });
        }
    }


}
