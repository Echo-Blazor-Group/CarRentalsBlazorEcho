using System.ComponentModel.DataAnnotations;

namespace CarRentalsBlazorEcho.Models
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int CarId { get; set; }
        public virtual Car Car { get; set; }

        [Required]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }
    }
}
