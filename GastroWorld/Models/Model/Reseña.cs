using Gastroworld.Models.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GastroWorld.Models.Model
{
    public class Reseña
    {
        [Key]
        public int Id { get; set; }

        [Required, ForeignKey("Usuario")]
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        [Required, ForeignKey("Restaurante")]
        public int RestauranteId { get; set; }
        public Restaurante Restaurante { get; set; }

        [Required]
        public string Contenido { get; set; }

        public int Puntuacion { get; set; }
    }
}
