using CarRentalsBlazorEcho.Models;

namespace CarRentalsBlazorEcho.Data
{
    public interface IUser
    {
        Task <User> GetByIdAsync(int id);
        Task <IEnumerable<User>> GetAllAsync();
        Task AddAsync(User user);
        Task UpdateAsync (User user);
        Task DeleteAsync (User user);
    }
}
