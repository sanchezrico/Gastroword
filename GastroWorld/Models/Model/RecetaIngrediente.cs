using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GastroWorld.Models.Model
{
    public class RecetaIngrediente
    {
        [Key]
        public int Id { get; set; }

        [Required, ForeignKey("Receta")]
        public int RecetaId { get; set; }
        public Receta Receta { get; set; }

        [Required, ForeignKey("Ingrediente")]
        public int IngredienteId { get; set; }
        public Ingrediente Ingrediente { get; set; }

        [Required, MaxLength(50)]
        public string Cantidad { get; set; }
    }
}
