using Microsoft.AspNetCore.Components;

namespace CarRentalsBlazorEcho.Models
{
    public class CurrentUser
    {
        public static User? User { get; set; } 
        public static string Email { get; set; } = string.Empty;
        public static bool IsAdmin { get; set; } = false;
        public static int LastCarLookedAtId { get; set; }
        public static bool IsLoggedIn { get; set; } = false;
        public static bool RedirectedFromBooking { get; set; } = false;

        public static void Reset()
        {
            User = null;
            Email = string.Empty;
            IsAdmin = false;
            IsLoggedIn = false;
            RedirectedFromBooking = false;

        }
    }
}
