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
        public async Task AddAsync(CarCategory model)
        {
            _context.CarCategories.Add(model);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(CarCategory model)
        {
            _context.CarCategories.Update(model);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(CarCategory model)
        {
            _context.CarCategories.Remove(model);
            await _context.SaveChangesAsync();
        }
    }
}
