using Gastroworld.Models.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GastroWorld.Models.Model
{
    public class Interaccion
    {
        [Key]
        public int Id { get; set; }

        [Required, ForeignKey("Usuario")]
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        [Required, ForeignKey("Publicacion")]
        public int PublicacionId { get; set; }
        public Publicacion Publicacion { get; set; }

        public string Tipo { get; set; } // Like, Dislike, etc.
    }
}
