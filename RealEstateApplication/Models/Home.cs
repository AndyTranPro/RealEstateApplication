using System.ComponentModel.DataAnnotations;

namespace RealEstateApplication.Models
{
    public class Home
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "This address field is required")]
        public string Address { get; set; }

        [Required(ErrorMessage = "The price field is required")]
        [Range(1, double.MaxValue, ErrorMessage = "The price must be a positive value")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "The area field is required")]
        [Range(1, double.MaxValue, ErrorMessage = "The area must be a positive value")]
        public int Area { get; set; }
        public string? ImageUrl { get; set; }
    }
}
