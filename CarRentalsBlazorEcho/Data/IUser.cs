using CarRentalsBlazorEcho.Models;
using IdentityModel;
using System.Linq;


namespace CarRentalsBlazorEcho.Data
{
    public interface IUser
    {
        Task <User> GetByIdAsync(int id);
        Task <IEnumerable<User>> GetAllAsync();
        Task<User> GetByEmailAsync(string email);
        Task AddAsync(User user);
        Task UpdateAsync (User user);
        Task DeleteAsync (User user);


    }
}
