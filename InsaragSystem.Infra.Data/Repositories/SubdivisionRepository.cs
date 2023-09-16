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
    public class SubdivisionRepository : ISubdivisionRepository
    {
        private readonly ApplicationDbContext _subdivisionContext;

        public SubdivisionRepository(ApplicationDbContext context)
        {
            _subdivisionContext = context;
        }

        public async Task<Subdivision> CreateAsync(Subdivision subdivision)
        {
            if (subdivision == null) throw new ArgumentNullException(nameof(subdivision));

            _subdivisionContext.Subdivisions.Add(subdivision);
            await _subdivisionContext.SaveChangesAsync();
            return subdivision;
        }

        public async Task<Subdivision> GetSubdivisionByIdAsync(int id)
        {
            return await _subdivisionContext.Subdivisions.FindAsync(id);
        }

        public async Task<IEnumerable<Subdivision>> GetSubdivisionsAsync()
        {
            return await _subdivisionContext.Subdivisions.ToListAsync();
        }

        public async Task<bool> RemoveAsync(int id)
        {
            var subdivision = await _subdivisionContext.Subdivisions.FindAsync(id);
            if (subdivision == null) return false;

            _subdivisionContext.Subdivisions.Remove(subdivision);
            await _subdivisionContext.SaveChangesAsync();
            return true;
        }

        public async Task<Subdivision> UpdateAsync(Subdivision subdivision)
        {
            if (subdivision == null) throw new ArgumentNullException(nameof(subdivision));

            _subdivisionContext.Subdivisions.Update(subdivision);
            await _subdivisionContext.SaveChangesAsync();
            return subdivision;
        }
    }
}
