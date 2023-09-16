using InsaragSystem.Domain.Entities.Sector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Domain.Interfaces.SectorInterfaces
{
    public interface ISubfieldRepository
    {
        Task<IEnumerable<Subfield>> GetSubfieldsAsync();
        Task<Subfield> GetSubfieldByIdAsync(int id);
        Task<Subfield> CreateAsync(Subfield subfield);
        Task<Subfield> UpdateAsync(Subfield subfield);
        Task<bool> RemoveAsync(int id);
    }
}
