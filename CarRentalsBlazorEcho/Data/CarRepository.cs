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
        public async Task<IEnumerable<Car>> GetByCategoryAsync(int categoryId)
        {
            return await _context.Cars.Where(c => c.CarCategoryId == categoryId).ToListAsync();
        }
        public async Task<List<Car>> GetAvailableCarsAsync(DateTime startDate, DateTime endDate)
        {
            var availableCars = await _context.Cars
                .Where(car => car.Available)
                .ToListAsync();

            var ordersWithinTimeSpan = await _context.Orders
                .Where(order => order.StartDate <= endDate && order.EndDate >= startDate)
                .ToListAsync();

            var availableCarIds = ordersWithinTimeSpan.Select(order => order.CarId).ToList();

            return availableCars.Where(car => !availableCarIds.Contains(car.CarId)).ToList();
        }

        public async Task<List<CarCategory>> GetCarCategoriesAsync()
        {
            return await _context.CarCategories.ToListAsync();
        }
    }
}
