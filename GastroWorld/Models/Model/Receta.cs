using Gastroworld.Models.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GastroWorld.Models.Model
{
    public class Receta
    {
        [Key]
        public int Id { get; set; }

        [Required, ForeignKey("Usuario")]
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        [Required, MaxLength(255)]
        public string Titulo { get; set; }

        [MaxLength(500)]
        public string Descripcion { get; set; }

        public DateTime FechaPublicacion { get; set; } = DateTime.UtcNow;

        public ICollection<RecetaIngrediente> RecetaIngredientes { get; set; }
    }
}
