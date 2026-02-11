using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class MasterView : Base
    {
        [Required]
        [StringLength(50)]
        public string Number { get; set; } = string.Empty;
        [Required]
        public DateOnly Date { get; set; }
        [StringLength(100)]
        public string Note { get; set; } = string.Empty;
        public List<DetailView>? Details { get; set; }=new List<DetailView>();
    }
}
