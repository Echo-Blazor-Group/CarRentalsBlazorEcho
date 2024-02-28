using CarRentalsBlazorEcho.Models;
using Microsoft.EntityFrameworkCore;

namespace CarRentalsBlazorEcho.Data
{
    public class BookingRepository : IBooking
    {
        private readonly ApplicationDbContext _context;
        public BookingRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Booking>> GetAllAsync()
        {
            return await (Task<IEnumerable<Booking>>)_context.Bookings.OrderBy(s => s.Id);
        }
        public async Task <Booking> GetByIdAsync(int id)
        {
            return await _context.Bookings.SingleOrDefaultAsync(c => c.Id == id);
        }
        public async Task AddAsync(Booking order)
        {
            _context.Bookings.Add(order);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(Booking order)
        {
            _context.Bookings.Add(order);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(Booking order)
        {
            _context.Bookings.Remove(order);
            await _context.SaveChangesAsync();
        }
    }
}
