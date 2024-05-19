using System;
using System.ComponentModel.DataAnnotations;

namespace Taqueria.Modelos
{
    public class Pedido
    {
        public int Id { get; set; }
        public int PersonaId { get; set; }
        public virtual Persona? Persona { get; set; }
        
        [Required(ErrorMessage = "La fecha es obligatoria")]
        public DateOnly Fecha { get; set; }
        
        [Required(ErrorMessage = "La hora del pedido es obligatoria")]
        public TimeOnly HoraPedido { get; set; }
        
        [Required(ErrorMessage = "El estado del pedido es obligatorio")]
        public string? EstadoPedido { get; set; }    
    }
}