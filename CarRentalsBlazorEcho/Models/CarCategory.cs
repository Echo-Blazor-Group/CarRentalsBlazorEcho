using System.ComponentModel.DataAnnotations;

namespace CarRentalsBlazorEcho.Models
{
    public class CarCategory
    {
        public int Id { get; set; }
        [Required]
        public string CategoryName { get; set; }

        public CarCategory()
        {

        }
    }
}
