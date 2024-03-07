using CarRentalsBlazorEcho.Models;

namespace CarRentalsBlazorEcho.Data
{
    public interface ICar
    {
        Task<Car> GetByIdAsync(int id);
        Task<IEnumerable<Car>> GetAllAsync();
        Task AddAsync(Car car);
        Task UpdateAsync(Car car);
        Task DeleteAsync(Car car);
        Task<IEnumerable<Car>> GetByCategoryAsync(int categoryId);
        Task<List<Car>> GetAvailableCarsAsync(DateTime startDate, DateTime endDate);
        Task<List<CarCategory>> GetCarCategoriesAsync();
    }
}
