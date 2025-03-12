using Gastroworld.Models.Model;
using GastroWorld.Repositories;

namespace GastroWorld.Models.IModel
{
    public interface IUsuarioRepository : IGenericRepository<Usuario>
    {
        Task<Usuario> GetByCredential(string usuario, string password);

    }
}
