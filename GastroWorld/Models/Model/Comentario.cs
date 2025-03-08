using Gastroworld.Models.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GastroWorld.Models.Model
{
    public class Comentario
    {
        [Key]
        public int Id { get; set; }

        [Required, ForeignKey("Usuario")]
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        [Required]
        public string Contenido { get; set; }

        public DateTime FechaComentario { get; set; } = DateTime.UtcNow;
    }
}
