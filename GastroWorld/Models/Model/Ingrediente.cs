using System.ComponentModel.DataAnnotations;

namespace GastroWorld.Models.Model
{
    public class Ingrediente
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Nombre { get; set; }
    }
}
