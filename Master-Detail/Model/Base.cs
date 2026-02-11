using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public abstract class Base
    {
        [Required]
        [Column(TypeName = "int")]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Sum { get; set; }
    }
}
