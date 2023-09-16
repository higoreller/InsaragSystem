using InsaragSystem.Domain.Entities.Sector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Domain.Interfaces.SectorInterfaces
{
    public interface ISubdivisionRepository
    {
        Task<IEnumerable<Subdivision>> GetSubdivisionsAsync();
        Task<Subdivision> GetSubdivisionByIdAsync(int id);
        Task<Subdivision> CreateAsync(Subdivision subdivision);
        Task<Subdivision> UpdateAsync(Subdivision subdivision);
        Task<bool> RemoveAsync(int id);
    }
}
