using InsaragSystem.Domain.Entities.Sector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Domain.Interfaces.SectorInterfaces
{
    public interface ISectorRepository
    {
        Task<IEnumerable<Sector>> GetSectorsAsync();
        Task<Sector> GetSectorByIdAsync(int id);
        Task<Sector> CreateAsync(Sector sector);
        Task<Sector> UpdateAsync(Sector sector);
        Task<bool> RemoveAsync(int id);
    }
}
