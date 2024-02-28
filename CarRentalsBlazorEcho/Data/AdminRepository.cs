using CarRentalsBlazorEcho.Models;
using Microsoft.EntityFrameworkCore;

namespace CarRentalsBlazorEcho.Data
{
    public class AdminRepository : IAdmin
    {
        public readonly ApplicationDbContext _context;
        public AdminRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task <IEnumerable<Admin>> GetAllAsync()
        {
            return await (Task<IEnumerable<Admin>>)_context.Admins.OrderBy(n => n.Id);
        }
        public async Task <Admin> GetByIdAsync(int id)
        {
            return await _context.Admins.SingleOrDefaultAsync(s => s.Id == id);
        }
        public async Task AddAsync(Admin admin)
        {
            _context.Admins.Add(admin);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(Admin admin)
        {
            _context.Admins.Update(admin);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(Admin admin)
        {
            _context.Admins.Remove(admin);
            await _context.SaveChangesAsync();
        }
    }
}
