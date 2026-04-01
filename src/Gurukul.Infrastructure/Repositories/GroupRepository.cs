using Gurukul.Core.Entities;
using Gurukul.Core.Interfaces;
using Gurukul.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Gurukul.Infrastructure.Repositories
{
    public class GroupRepository : IGroupRepository
    {
        private readonly GurukulDbContext _context;

        public GroupRepository(GurukulDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Group>> GetAllAsync()
        {
            return await _context.Groups
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<Group?> GetByIdAsync(Guid id)
        {
            return await _context.Groups
                .AsNoTracking()
                .FirstOrDefaultAsync(g => g.Id == id);
        }

        public async Task<Group> CreateAsync(Group group)
        {
            _context.Groups.Add(group);
            await _context.SaveChangesAsync();
            return group;
        }

        public async Task<Group> UpdateAsync(Group group)
        {
            _context.Groups.Update(group);
            await _context.SaveChangesAsync();
            return group;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var group = await _context.Groups.FindAsync(id);
            if (group is null) return false;

            _context.Groups.Remove(group);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> ExistsAsync(Guid id)
        {
            return await _context.Groups.AnyAsync(g => g.Id == id);
        }
    }
}
