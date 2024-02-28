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
            return await _context.CarModels.OrderBy(c => c.Id).ToListAsync();
        }
        public async Task<CarCategory> GetByIdAsync(int id)
        {
            return await _context.CarModels.SingleOrDefaultAsync(s => s.Id == id);
        }
        public async Task AddAsync(CarCategory model)
        {
            _context.CarModels.Add(model);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(CarCategory model)
        {
            _context.CarModels.Update(model);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(CarCategory model)
        {
            _context.CarModels.Remove(model);
            await _context.SaveChangesAsync();
        }
    }
}
