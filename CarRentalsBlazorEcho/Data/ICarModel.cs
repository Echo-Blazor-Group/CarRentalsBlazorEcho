using CarRentalsBlazorEcho.Models;

namespace CarRentalsBlazorEcho.Data
{
    public interface ICarModel
    {
        Task <CarModel> GetByIdAsync (int id);
        Task <IEnumerable<CarModel>> GetAllAsync ();
        Task AddAsync (CarModel model);
        Task UpdateAsync (CarModel model);
        Task DeleteAsync (CarModel model);
    }
}
