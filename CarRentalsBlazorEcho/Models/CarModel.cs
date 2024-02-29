using System.ComponentModel.DataAnnotations;

namespace CarRentalsBlazorEcho.Models
{
    public class CarModel
    {
        [Key]
        public int CarModelId { get; set; }

        [Required]
        public string CategoryName { get; set; }
    }
}
