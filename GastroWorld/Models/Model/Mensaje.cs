using Gastroworld.Models.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GastroWorld.Models.Model
{
    public class Mensaje
    {
        [Key]
        public int Id { get; set; }

        [Required, ForeignKey("UsuarioEmisor")]
        public int UsuarioEmisorId { get; set; }
        public Usuario UsuarioEmisor { get; set; }

        [Required, ForeignKey("UsuarioReceptor")]
        public int UsuarioReceptorId { get; set; }
        public Usuario UsuarioReceptor { get; set; }

        [Required]
        public string Contenido { get; set; }

        public DateTime FechaEnvio { get; set; } = DateTime.UtcNow;
    }
}
