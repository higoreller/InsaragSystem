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
    public class WildfireRepository : IWildfireRepository
    {
        private readonly ApplicationDbContext _wildfireContext;

        public WildfireRepository(ApplicationDbContext context)
        {
            _wildfireContext = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<Wildfire> CreateAsync(Wildfire wildfire)
        {
            if (wildfire == null) throw new ArgumentNullException(nameof(wildfire));

            await _wildfireContext.Wildfires.AddAsync(wildfire);
            await _wildfireContext.SaveChangesAsync();
            return wildfire;
        }

        public async Task<Wildfire> GetWildfireByIdAsync(string id)
        {
            if (string.IsNullOrEmpty(id)) throw new ArgumentNullException(nameof(id));

            return await _wildfireContext.Wildfires.FindAsync(id);
        }

        public async Task<IEnumerable<Wildfire>> GetWildfiresAsync()
        {
            return await _wildfireContext.Wildfires.ToListAsync();
        }

        public async Task<bool> RemoveAsync(string id)
        {
            var wildfire = await GetWildfireByIdAsync(id);
            if (wildfire == null) return false;

            _wildfireContext.Wildfires.Remove(wildfire);
            await _wildfireContext.SaveChangesAsync();
            return true;
        }

        public async Task<Wildfire> UpdateAsync(Wildfire wildfire)
        {
            if (wildfire == null) throw new ArgumentNullException(nameof(wildfire));

            _wildfireContext.Wildfires.Update(wildfire);
            await _wildfireContext.SaveChangesAsync();
            return wildfire;
        }
    }
}
