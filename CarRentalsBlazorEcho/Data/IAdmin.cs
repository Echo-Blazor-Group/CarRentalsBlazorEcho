using CarRentalsBlazorEcho.Models;

namespace CarRentalsBlazorEcho.Data
{
    public interface IAdmin
    {
        Task <Admin> GetByIdAsync (int id);
        Task<IEnumerable<Admin>> GetAllAsync();
        Task AddAsync(Admin admin);
        Task UpdateAsync (Admin admin);
        Task DeleteAsync (Admin admin);
    }
}
