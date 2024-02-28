using System.ComponentModel.DataAnnotations;

namespace CarRentalsBlazorEcho.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Brand { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public int Price { get; set; }

        public List<CarCategory> CarCategory { get; set; }
        public List<Booking> Bookings { get; set; }

    }
}
