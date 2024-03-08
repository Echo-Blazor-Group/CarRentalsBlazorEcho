using CarRentalsBlazorEcho.Models;
using Microsoft.EntityFrameworkCore;

namespace CarRentalsBlazorEcho.Data
{
    public class CarCategoryRepository : ICarCategory
    {
        private readonly ApplicationDbContext _context;
        public CarCategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<CarCategory>> GetAllAsync()
        {
            return await _context.CarCategories.OrderBy(x => x.Id).ToListAsync();
        }
        public async Task<CarCategory> GetByIdAsync(int id)
        {
            return await _context.CarCategories.SingleOrDefaultAsync(s => s.Id == id);
        }
        public async Task AddAsync(CarCategory category)
        {
            _context.CarCategories.Add(category);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(CarCategory category)
        {
            _context.CarCategories.Update(category);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(CarCategory category)
        {
            _context.CarCategories.Remove(category);
            await _context.SaveChangesAsync();
        }
    }
}
