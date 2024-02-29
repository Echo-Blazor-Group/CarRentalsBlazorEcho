using System.ComponentModel.DataAnnotations;

namespace CarRentalsBlazorEcho.Models
{
    public class Car
    {
        [Key]
        public int CarId { get; set; }

        [Required]
        public string Brand { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public int Price { get; set; }

        public List<CarModel> CarModels { get; set; }
        public List<Order> Orders { get; set; }

    }
}
