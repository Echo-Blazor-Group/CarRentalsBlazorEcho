using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CarRentalsBlazorEcho.Models
{
    public class Car
    {
        public int CarId { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public string Model { get; set; }
        public int CarCategoryId { get; set; }
        [Required]
        public int Price { get; set; }
        public bool Available { get; set; }
        public CarCategory CarCategory { get; set; }

        public Car()
        {

        }
    }
}
