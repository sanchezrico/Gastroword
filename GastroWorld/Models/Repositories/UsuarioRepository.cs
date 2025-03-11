using Gastroworld.Data;
using GastroWorld.Models;
using Gastroworld.Models.Model;
using GastroWorld.Models.IModel;
using GastroWorld.Repositories;
using Microsoft.EntityFrameworkCore;


namespace GastroWorld.Models.Repositories
{
    public class UsuarioRepository : GenericRepository<Usuario>, IUsuarioRepository
    {

        private readonly ApplicationDbContext context;

        public UsuarioRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }

        public async Task<Usuario> GetByCredential(string usuario, string password)
        {
            return await context.Usuarios.FirstOrDefaultAsync(d => d.LUsuario == usuario && d.Password == password);
        }

    }
}
