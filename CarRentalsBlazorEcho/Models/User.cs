﻿using System.ComponentModel.DataAnnotations;

namespace CarRentalsBlazorEcho.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public List<Order> Orders { get; set; }
    }
}
