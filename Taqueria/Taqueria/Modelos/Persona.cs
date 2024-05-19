using System.ComponentModel.DataAnnotations;

namespace Taqueria.Modelos
{
    public class Persona
    {
        public int Id { get; set; }
        public int PlatilloId { get; set; }
        public virtual Platillo? Platillo { get; set; }
        [Required(ErrorMessage ="El nombre es obligatorio")]
        [StringLength(100, ErrorMessage ="Maximo 100 caracteres")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage ="El telefono es obligatorio")]
        [StringLength(10, ErrorMessage ="Maximo 10 caracteres")]
        public string? Telefono { get; set; }
        [Required(ErrorMessage ="La direccion es requerido")]
        [StringLength(100, ErrorMessage ="Maximo 100 caracteres")]
        public string? Dirección { get; set; }
        virtual public ICollection<Pedido>? Pedidos { get; set; }
    }
}
