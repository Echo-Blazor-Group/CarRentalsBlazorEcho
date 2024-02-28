using CarRentalsBlazorEcho.Models;

namespace CarRentalsBlazorEcho.Data
{
    public interface IBooking
    {
        Task <Booking> GetByIdAsync(int id);
        Task <IEnumerable<Booking>> GetAllAsync();
        Task AddAsync (Booking order);
        Task UpdateAsync (Booking order);
        Task DeleteAsync (Booking order);
    }
}
