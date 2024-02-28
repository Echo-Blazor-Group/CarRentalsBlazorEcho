using System.ComponentModel.DataAnnotations;

namespace CarRentalsBlazorEcho.Models
{
    public class CarCategory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string CategoryName { get; set; }
    }
}
