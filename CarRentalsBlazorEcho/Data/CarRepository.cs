using CarRentalsBlazorEcho.Models;
using Microsoft.EntityFrameworkCore;

namespace CarRentalsBlazorEcho.Data
{
    public class CarRepository : ICar
    {
        private readonly ApplicationDbContext _context;
        public CarRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Car>> GetAllAsync()
        {
            return await _context.Cars.OrderBy(c => c.CarId).ToListAsync();
        }
        public async Task<Car> GetByIdAsync(int id)
        {
            return await _context.Cars.SingleOrDefaultAsync(s => s.CarId == id);
        }
        public async Task AddAsync(Car car)
        {
            _context.Cars.Add(car);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(Car car)
        {
            _context.Cars.Update(car);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(Car car)
        {
            _context.Cars.Remove(car);
            await _context.SaveChangesAsync();
        }
    }
}
