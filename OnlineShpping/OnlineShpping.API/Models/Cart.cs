using System.ComponentModel.DataAnnotations;

namespace OnlineShopping.API.Model
{
    public class Cart
    {
        [Key]
        [Required]
        public int ProductId { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Length must be under 50")]
        public string Name { get; set; }

        [StringLength(200, ErrorMessage = "Length must be under 200")]
        public string Description { get; set; }

        [Required]
        public string Category { get; set; }

        public int Quantity { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }

        public DateTime ExpiryDate { get; set; }

        // Add other properties or filters/ attributes as required.
        public string UserId { get; set; }
    }

}

