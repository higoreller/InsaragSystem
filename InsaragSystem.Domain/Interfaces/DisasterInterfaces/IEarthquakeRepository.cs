using InsaragSystem.Domain.Entities.Disaster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Domain.Interfaces.DisasterInterfaces
{
    public interface IEarthquakeRepository
    {
        Task<IEnumerable<Earthquake>> GetEarthquakesAsync();
        Task<Earthquake> GetEarthquakeByIdAsync(string id);
        Task<Earthquake> CreateAsync(Earthquake earthquake);
        Task<Earthquake> UpdateAsync(Earthquake earthquake);
        Task<bool> RemoveAsync(string id);
    }
}
