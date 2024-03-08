using CarRentalsBlazorEcho.Models;

namespace CarRentalsBlazorEcho.Data
{
    public interface ICarPicture
    {
        Task AddAsync(CarPicture picture);
        Task DeleteAsync(CarPicture picture);
        Task <IEnumerable<CarPicture>> GetAllByCarIdAsync(int id);
    }
}
