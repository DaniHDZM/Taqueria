using System.ComponentModel.DataAnnotations;

namespace Taqueria.Modelos
{
    public class Platillo
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="El nombre es obligatorio")]
        [StringLength(100, ErrorMessage = "Maximo 100 caracteres")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "La descripcion es obligatorio")]
        [StringLength(100, ErrorMessage = "Maximo 100 caracteres")]
        public string? Descripcion { get; set; }
        [Required(ErrorMessage = "el precio es obligatorio")]

        public int Precio { get; set; }
        virtual public ICollection<Persona>? Personas { get; set;}

    }
}
