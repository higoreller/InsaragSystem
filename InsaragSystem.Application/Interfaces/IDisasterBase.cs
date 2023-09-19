using InsaragSystem.Application.DTOs.DisasterDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Application.Interfaces
{
    public interface IDisasterBase
    {
        Task<IEnumerable<DisasterBaseDTO>> GetDisasters();
        Task<DisasterBaseDTO> GetDisasterById(int id);
        Task<DisasterBaseDTO> AddDisaster(DisasterBaseDTO disasterDto);
        Task UpdateDisaster(DisasterBaseDTO disasterDto);
        Task RemoveDisaster(int id);

        // Other relevant methods
        Task<IEnumerable<DisasterBaseDTO>> GetDisastersByImpactLevel(string impactLevel);
        Task<IEnumerable<DisasterBaseDTO>> GetActiveDisasters();
    }
}
