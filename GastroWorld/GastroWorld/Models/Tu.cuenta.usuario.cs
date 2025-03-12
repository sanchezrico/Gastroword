using System.ComponentModel.DataAnnotations;

namespace GastroWorld.Models
{
    public class Tucuenta
    {



        //definir propiedades
        [Required(ErrorMessage = "tu receta es obligatoria")]
        public string nombre{ get; set;}
        //[Required]
        //public string apellido { get; set;}
        [Required]
        public string contraseña { get; set; }




    }
}
