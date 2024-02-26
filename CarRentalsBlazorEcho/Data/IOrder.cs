using CarRentalsBlazorEcho.Models;

namespace CarRentalsBlazorEcho.Data
{
    public interface IOrder
    {
        Task <Order> GetByIdAsync(int id);
        Task <IEnumerable<Order>> GetAllAsync();
        Task AddAsync (Order order);
        Task UpdateAsync (Order order);
        Task DeleteAsync (Order order);
    }
}
