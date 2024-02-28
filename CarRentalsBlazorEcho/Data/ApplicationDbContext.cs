using CarRentalsBlazorEcho.Models;
using Microsoft.EntityFrameworkCore;

namespace CarRentalsBlazorEcho.Data
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<CarCategory> CarModels { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CarPicture> CarPictures { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>()
                .HasOne(r => r.Customer)
                .WithMany(c => c.Bookings)
                .HasForeignKey(r => r.CustomerId);

            modelBuilder.Entity<Booking>()
                .HasOne(r => r.Car)
                .WithMany(c => c.Bookings)
                .HasForeignKey(r => r.CarId);

        }
    }
}
