using System.ComponentModel.DataAnnotations;

namespace L01P022022LA605.Models
{
    public class Facultades
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string facultad { get; set; }
    }
}
