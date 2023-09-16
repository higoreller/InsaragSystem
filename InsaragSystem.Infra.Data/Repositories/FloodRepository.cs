using InsaragSystem.Domain.Entities.Disaster;
using InsaragSystem.Domain.Interfaces.DisasterInterfaces;
using InsaragSystem.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Infra.Data.Repositories
{
    public class FloodRepository : IFloodRepository
    {
        private readonly ApplicationDbContext _floodContext;

        public FloodRepository(ApplicationDbContext context)
        {
            _floodContext = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<Flood> CreateAsync(Flood flood)
        {
            if (flood == null) throw new ArgumentNullException(nameof(flood));

            await _floodContext.Floods.AddAsync(flood);
            await _floodContext.SaveChangesAsync();
            return flood;
        }

        public async Task<Flood> GetFloodByIdAsync(string id)
        {
            if (string.IsNullOrEmpty(id)) throw new ArgumentNullException(nameof(id));

            return await _floodContext.Floods.FindAsync(id);
        }

        public async Task<IEnumerable<Flood>> GetFloodsAsync()
        {
            return await _floodContext.Floods.ToListAsync();
        }

        public async Task<bool> RemoveAsync(string id)
        {
            var flood = await GetFloodByIdAsync(id);
            if (flood == null) return false;

            _floodContext.Floods.Remove(flood);
            await _floodContext.SaveChangesAsync();
            return true;
        }

        public async Task<Flood> UpdateAsync(Flood flood)
        {
            if (flood == null) throw new ArgumentNullException(nameof(flood));

            _floodContext.Floods.Update(flood);
            await _floodContext.SaveChangesAsync();
            return flood;
        }
    }
}
