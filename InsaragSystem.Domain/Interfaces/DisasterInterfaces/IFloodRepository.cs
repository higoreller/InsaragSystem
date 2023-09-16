using InsaragSystem.Domain.Entities.Disaster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Domain.Interfaces.DisasterInterfaces
{
    public interface IFloodRepository
    {
        Task<IEnumerable<Flood>> GetFloodsAsync();
        Task<Flood> GetFloodByIdAsync(string id);
        Task<Flood> CreateAsync(Flood flood);
        Task<Flood> UpdateAsync(Flood flood);
        Task<bool> RemoveAsync(string id);
    }
}
