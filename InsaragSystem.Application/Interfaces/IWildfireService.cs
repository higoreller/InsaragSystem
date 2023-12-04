using InsaragSystem.Application.DTOs.DisasterDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Application.Interfaces
{
    public interface IWildfireService
    {
        Task<IEnumerable<WildfireDTO>> GetWildfires();
        Task<WildfireDTO> GetWildfireById(int id);
        Task<WildfireDTO> AddWildfire(WildfireDTO wildfireDto);
        Task UpdateWildfire(WildfireDTO wildfireDto);
        Task RemoveWildfire(int id);
    }
}
