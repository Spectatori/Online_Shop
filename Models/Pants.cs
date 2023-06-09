using System.ComponentModel.DataAnnotations;

namespace Online_Shop.Models
{
    public class Pants
    {
        [Key]
        public Guid PantsId { get; set; }
        public string? Name { get; set; }
        public string? Color { get; set; }
        public string? Description { get; set; }
        public int Price { get; set; }
    }
}