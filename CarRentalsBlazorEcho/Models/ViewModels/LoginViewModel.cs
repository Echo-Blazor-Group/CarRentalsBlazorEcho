using System.ComponentModel.DataAnnotations;

namespace CarRentalsBlazorEcho.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "please enter your Email")]
        public string? Email { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "please enter a password")]
        public string? Password { get; set; }
    }
}
