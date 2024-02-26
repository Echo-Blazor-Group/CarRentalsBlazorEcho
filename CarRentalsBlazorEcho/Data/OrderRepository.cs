using CarRentalsBlazorEcho.Models;
using Microsoft.EntityFrameworkCore;

namespace CarRentalsBlazorEcho.Data
{
    public class OrderRepository : IOrder
    {
        private readonly ApplicationDbContext _context;
        public OrderRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Order>> GetAllAsync()
        {
            return await (Task<IEnumerable<Order>>)_context.Orders.OrderBy(s => s.OrderId);
        }
        public async Task <Order> GetByIdAsync(int id)
        {
            return await _context.Orders.SingleOrDefaultAsync(c => c.OrderId == id);
        }
        public async Task AddAsync(Order order)
        {
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(Order order)
        {
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(Order order)
        {
            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();
        }
    }
}
