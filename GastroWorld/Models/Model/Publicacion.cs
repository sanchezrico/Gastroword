using Gastroworld.Models.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GastroWorld.Models.Model
{
    public class Publicacion
    {
        [Key]
        public int Id { get; set; }

        [Required, ForeignKey("Usuario")]
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        [Required]
        public string Contenido { get; set; }

        public string Imagen { get; set; }

        public DateTime FechaPublicacion { get; set; } = DateTime.UtcNow;
    }
}
