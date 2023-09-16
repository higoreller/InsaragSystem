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
    public class EarthquakeRepository : IEarthquakeRepository
    {
        private readonly ApplicationDbContext _earthQuakeContext;

        public EarthquakeRepository(ApplicationDbContext context)
        {
            _earthQuakeContext = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<Earthquake> CreateAsync(Earthquake earthquake)
        {
            if (earthquake == null) throw new ArgumentNullException(nameof(earthquake));

            await _earthQuakeContext.Earthquakes.AddAsync(earthquake);
            await _earthQuakeContext.SaveChangesAsync();
            return earthquake;
        }

        public async Task<Earthquake> GetEarthquakeByIdAsync(string id)
        {
            if (string.IsNullOrEmpty(id)) throw new ArgumentNullException(nameof(id));

            return await _earthQuakeContext.Earthquakes.FindAsync(id);
        }

        public async Task<IEnumerable<Earthquake>> GetEarthquakesAsync()
        {
            return await _earthQuakeContext.Earthquakes.ToListAsync();
        }

        public async Task<bool> RemoveAsync(string id)
        {
            var earthquake = await GetEarthquakeByIdAsync(id);
            if (earthquake == null) return false;

            _earthQuakeContext.Earthquakes.Remove(earthquake);
            await _earthQuakeContext.SaveChangesAsync();
            return true;
        }

        public async Task<Earthquake> UpdateAsync(Earthquake earthquake)
        {
            if (earthquake == null) throw new ArgumentNullException(nameof(earthquake));

            _earthQuakeContext.Earthquakes.Update(earthquake);
            await _earthQuakeContext.SaveChangesAsync();
            return earthquake;
        }
    }
}
