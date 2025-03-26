using System.ComponentModel.DataAnnotations;

namespace L01P022022LA605.Models
{
    public class Departamentos
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string departamento { get; set; }
    }
}

