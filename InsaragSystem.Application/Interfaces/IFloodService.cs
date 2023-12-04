using InsaragSystem.Application.DTOs.DisasterDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Application.Interfaces
{
    public interface IFloodService
    {
        Task<IEnumerable<FloodDTO>> GetFloods();
        Task<FloodDTO> GetFloodById(int id);
        Task<FloodDTO> AddFlood(FloodDTO floodDto);
        Task UpdateFlood(FloodDTO floodDto);
        Task RemoveFlood(int id);
    }
}
