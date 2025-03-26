using System.ComponentModel.DataAnnotations;

namespace L01P022022LA605.Models
{
    public class Alumnos
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string Apellidos { get; set; }

        [Required]
        public int Dui { get; set; }

        [Required]
        public int Estado { get; set; }
    }
}
