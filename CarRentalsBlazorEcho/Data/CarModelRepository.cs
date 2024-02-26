using CarRentalsBlazorEcho.Models;
using Microsoft.EntityFrameworkCore;

namespace CarRentalsBlazorEcho.Data
{
    public class CarModelRepository : ICarModel
    {
        private readonly ApplicationDbContext _context;
        public CarModelRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<CarModel>> GetAllAsync()
        {
            return await (Task<IEnumerable<CarModel>>)_context.CarModels.OrderBy(c => c.CarModelId);
        }
        public async Task<CarModel> GetByIdAsync(int id)
        {
            return await _context.CarModels.SingleOrDefaultAsync(s => s.CarModelId == id);
        }
        public async Task AddAsync(CarModel model)
        {
            _context.CarModels.Add(model);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(CarModel model)
        {
            _context.CarModels.Update(model);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(CarModel model)
        {
            _context.CarModels.Remove(model);
            await _context.SaveChangesAsync();
        }
    }
}
