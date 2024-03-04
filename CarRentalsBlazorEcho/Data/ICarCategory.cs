using CarRentalsBlazorEcho.Models;

namespace CarRentalsBlazorEcho.Data
{
    public interface ICarCategory
    {
        Task <CarCategory> GetByIdAsync (int id);
        Task <IEnumerable<CarCategory>> GetAllAsync();
        Task AddAsync (CarCategory model);
        Task UpdateAsync (CarCategory model);
        Task DeleteAsync (CarCategory model);
    }
}
