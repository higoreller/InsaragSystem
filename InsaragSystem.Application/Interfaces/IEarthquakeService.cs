using InsaragSystem.Application.DTOs.DisasterDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Application.Interfaces
{
    public interface IEarthquakeService
    {
        Task<IEnumerable<EarthquakeDTO>> GetEarthquakes();
        Task<EarthquakeDTO> GetEarthquakeById(int id);
        Task<EarthquakeDTO> AddEarthquake(EarthquakeDTO earthquakeDto);
        Task UpdateEarthquake(EarthquakeDTO earthquakeDto);
        Task RemoveEarthquake(int id);
    }
}
