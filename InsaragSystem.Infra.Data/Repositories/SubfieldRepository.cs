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
    public class SubfieldRepository : ISubfieldRepository
    {
        private readonly ApplicationDbContext _subfieldContext;

        public SubfieldRepository(ApplicationDbContext context)
        {
            _subfieldContext = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<Subfield> CreateAsync(Subfield subfield)
        {
            if (subfield == null) throw new ArgumentNullException(nameof(subfield));

            await _subfieldContext.Subfields.AddAsync(subfield);
            await _subfieldContext.SaveChangesAsync();
            return subfield;
        }

        public async Task<Subfield> GetSubfieldByIdAsync(int id)
        {
            return await _subfieldContext.Subfields.FindAsync(id);
        }

        public async Task<IEnumerable<Subfield>> GetSubfieldsAsync()
        {
            return await _subfieldContext.Subfields.ToListAsync();
        }

        public async Task<bool> RemoveAsync(int id)
        {
            var subfield = await GetSubfieldByIdAsync(id);
            if (subfield == null) return false;

            _subfieldContext.Subfields.Remove(subfield);
            var result = await _subfieldContext.SaveChangesAsync();
            return result > 0;
        }

        public async Task<Subfield> UpdateAsync(Subfield subfield)
        {
            if (subfield == null) throw new ArgumentNullException(nameof(subfield));

            _subfieldContext.Subfields.Update(subfield);
            await _subfieldContext.SaveChangesAsync();
            return subfield;
        }
    }
}
