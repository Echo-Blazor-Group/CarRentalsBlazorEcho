using CarRentalsBlazorEcho.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CarRentalsBlazorEcho.Data
{
    public class UserRepository : IUser
    {
        private readonly ApplicationDbContext _context;
        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await _context.Users.OrderBy(c => c.UserId).ToListAsync();
        }
        public async Task<User> GetByIdAsync(int id)
        {
            return await _context.Users.SingleOrDefaultAsync(s => s.UserId == id);
        }
        public async Task AddAsync(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(User user)
        {
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }
        public async Task<User> GetByEmailAsync(string email)
        {
            return await _context.Users.SingleOrDefaultAsync(s => s.Email == email);
        }
    }
}
