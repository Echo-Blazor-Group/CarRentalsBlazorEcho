using CarRentalsBlazorEcho.Models;
using Microsoft.EntityFrameworkCore;

namespace CarRentalsBlazorEcho.Data
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarCategory> CarCategories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet <User> Users { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
