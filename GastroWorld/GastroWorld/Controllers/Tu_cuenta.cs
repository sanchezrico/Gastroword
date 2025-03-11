using AspNetCoreGeneratedDocument;
using GastroWorld.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using GastroWorld.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GastroWorld.Controllers
{
    public class Tu_cuentaController : Controller
    {
        public IActionResult Tu_cuenta()
        {
            return View("Tu_cuenta");
        }
  
            private readonly ApplicationDbContext _context;

            public Tu_cuentaController(ApplicationDbContext context)
            {

                _context = context;

            }

            public async Task<IActionResult> Edit(string nombre)
        {
            var usuario = await _context.Usuarios.FindAsync(nombre);
            if(usuario == null)
            {
                return NotFound();
            }
            return View(usuario);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Tucuenta usuario)
        {
            if (!ModelState.IsValid)
            {
                return View(usuario);
                
                
                //SaveChangesAsync

            //    await _context .SaveChangesAsync();
            //    return RedirectToAction("Edit", new { nombre= usuario.nombre });
            //
             }

            var usuarioExistente = await _context.Usuarios.FindAsync(usuario.nombre);
            if(usuarioExistente == null){
                return NotFound();
            }

            usuarioExistente.nombre = usuario.nombre;

            _context.Update(usuarioExistente);
            await _context.SaveChangesAsync();

            return RedirectToAction("Edit", new { Nombre = usuario.nombre });

        }
        
    }
}
