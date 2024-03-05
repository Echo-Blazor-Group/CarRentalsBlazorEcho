using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CarRentalsBlazorEcho.Models
{
    public class CarPicture
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("Car")]
        public int CarId { get; set; }
        public virtual Car Car { get; set; }

        public string PictureUrl { get; set; }

    }
}
