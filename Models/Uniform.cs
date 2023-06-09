using System.ComponentModel.DataAnnotations;

namespace Online_Shop.Models
{
    public class Uniform
    {
        [Key]
        public string? SelectProductType { get; set; }
        public Guid ShirtId { get; set; }
        public Guid PantsId { get; set; }
        public Shirt Shirt { get; set; }
        public Pants Pants { get; set; }
        public string? Path { get; set; }
    }
}