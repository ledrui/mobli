using System.ComponentModel.DataAnnotations;

namespace vega.Models
{
    public class Model
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLengthAttribute(255)]
        public string Name { get; set; }

        public Make Make { get; set; }
        public int MakeID { get; set; }
    }
}