using InsaragSystem.Domain.Entities.Sector;
using InsaragSystem.Domain.Interfaces.SectorInterfaces;
using InsaragSystem.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Infra.Data.Repositories
{
    public class SectorRepository : ISectorRepository
    {
        private readonly ApplicationDbContext _sectorContext;

        public SectorRepository(ApplicationDbContext context)
        {
            _sectorContext = context;
        }

        public async Task<Sector> CreateAsync(Sector sector)
        {
            if (sector == null) throw new ArgumentNullException(nameof(sector));

            _sectorContext.Sectors.Add(sector);
            await _sectorContext.SaveChangesAsync();
            return sector;
        }

        public async Task<Sector> GetSectorByIdAsync(int id)
        {
            return await _sectorContext.Sectors.FindAsync(id);
        }

        public async Task<IEnumerable<Sector>> GetSectorsAsync()
        {
            return await _sectorContext.Sectors.ToListAsync();
        }

        public async Task<bool> RemoveAsync(int id)
        {
            var sector = await _sectorContext.Sectors.FindAsync(id);
            if (sector == null) return false;

            _sectorContext.Sectors.Remove(sector);
            await _sectorContext.SaveChangesAsync();
            return true;
        }

        public async Task<Sector> UpdateAsync(Sector sector)
        {
            if (sector == null) throw new ArgumentNullException(nameof(sector));

            _sectorContext.Sectors.Update(sector);
            await _sectorContext.SaveChangesAsync();
            return sector;
        }
    }
}
