using System.ComponentModel.DataAnnotations;

namespace L01P022022LA605.Models
{
    public class Materias
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string materia { get; set; }

        [Required]
        [Range(1, 10, ErrorMessage = "Las unidades valorativas deben estar entre 1 y 10.")]
        public int unidades_valorativas { get; set; }

        [Required]
        [RegularExpression("[A]", ErrorMessage = "Solo se permite el estado 'A' (Activo)")]
        public char estado { get; set; }
    }
}
