using System.ComponentModel.DataAnnotations;

namespace CarRentalsBlazorEcho.Models
{
    public class CarPicture
    {
        [Key]
        public int Id { get; set; }

        public int CarId { get; set; }
        public virtual Car Car { get; set; }

        public string PictureUrl { get; set; }

    }
}
