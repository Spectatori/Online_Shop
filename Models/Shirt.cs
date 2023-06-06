using System.ComponentModel.DataAnnotations;

namespace Online_Shop.Models
{
    public class Shirt
    {
        [Key]
        public Guid ShirtId { get; set; }

        public string Color { get; set; }
    }
}