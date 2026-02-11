using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class DetailView : Base
    {
        //[Column(TypeName = "int")]
        public int MasterViewId { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
    }
}
