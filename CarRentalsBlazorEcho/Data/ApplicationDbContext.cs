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
        public DbSet <CarPicture> CarPictures { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Order>()
        //        .HasOne(r => r.User)
        //        .WithMany(c => c.Orders)
        //        .HasForeignKey(r => r.CustomerId);

        //    modelBuilder.Entity<Order>()
        //        .HasOne(r => r.Car)
        //        .WithMany(c => c.Orders)
        //        .HasForeignKey(r => r.CarId);

        //}
    }
}
