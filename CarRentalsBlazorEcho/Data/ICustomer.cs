using CarRentalsBlazorEcho.Models;

namespace CarRentalsBlazorEcho.Data
{
    public interface ICustomer
    {
        Task <Customer> GetByIdAsync(int id);
        Task <IEnumerable<Customer>> GetAllAsync();
        Task AddAsync(Customer user);
        Task UpdateAsync (Customer user);
        Task DeleteAsync (Customer user);
    }
}
