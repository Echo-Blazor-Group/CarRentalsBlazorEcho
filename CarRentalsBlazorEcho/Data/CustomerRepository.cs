using CarRentalsBlazorEcho.Models;
using Microsoft.EntityFrameworkCore;

namespace CarRentalsBlazorEcho.Data
{
    public class CustomerRepository : ICustomer
    {
        private readonly ApplicationDbContext _context;
        public CustomerRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            return await _context.Customers.OrderBy(c => c.Id).ToListAsync();
        }
        public async Task<Customer> GetByIdAsync(int id)
        {
            return await _context.Customers.SingleOrDefaultAsync(s => s.Id == id);
        }
        public async Task AddAsync(Customer user)
        {
            _context.Customers.Add(user);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(Customer user)
        {
            _context.Customers.Update(user);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(Customer user)
        {
            _context.Customers.Remove(user);
            await _context.SaveChangesAsync();
        }
    }
}
