using InsaragSystem.Domain.Entities.Disaster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Domain.Interfaces.DisasterInterfaces
{
    public interface IWildfireRepository
    {
        Task<IEnumerable<Wildfire>> GetWildfiresAsync();
        Task<Wildfire> GetWildfireByIdAsync(string id);
        Task<Wildfire> CreateAsync(Wildfire wildfire);
        Task<Wildfire> UpdateAsync(Wildfire wildfire);
        Task<bool> RemoveAsync(string id);
    }
}
