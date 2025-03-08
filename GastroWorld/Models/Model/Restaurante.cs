using System.ComponentModel.DataAnnotations;

namespace GastroWorld.Models.Model
{
    public class Restaurante
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Nombre { get; set; }

        [MaxLength(255)]
        public string Ubicacion { get; set; }
    }

}
