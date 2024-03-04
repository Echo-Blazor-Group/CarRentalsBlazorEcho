using CarRentalsBlazorEcho.Models;

namespace CarRentalsBlazorEcho.Data
{
    public interface ICarPicture
    {
        Task <IEnumerable<CarPicture>> GetAllByCarIdAsync(int id);
    }
}
