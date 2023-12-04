using AutoMapper;
using InsaragSystem.Application.DTOs.DisasterDTOs;
using InsaragSystem.Application.Interfaces;
using InsaragSystem.Domain.Entities.Disaster;
using InsaragSystem.Domain.Interfaces.DisasterInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Application.Services
{
    public class EarthquakeService : IEarthquakeService
    {
        private readonly IEarthquakeRepository _earthquakeRepository;
        private readonly IMapper _mapper;

        public EarthquakeService(IEarthquakeRepository earthquakeRepository, IMapper mapper)
        {
            _earthquakeRepository = earthquakeRepository ?? throw new ArgumentNullException(nameof(earthquakeRepository));
            _mapper = mapper;
        }

        public async Task<EarthquakeDTO> AddEarthquake(EarthquakeDTO earthquakeDto)
        {
            var earthquake = _mapper.Map<Earthquake>(earthquakeDto);
            await _earthquakeRepository.CreateAsync(earthquake);
            return _mapper.Map<EarthquakeDTO>(earthquake);
        }

        public async Task<EarthquakeDTO> GetEarthquakeById(int id)
        {
            var earthquake = await _earthquakeRepository.GetEarthquakeByIdAsync(id.ToString());
            return _mapper.Map<EarthquakeDTO>(earthquake);
        }

        public async Task<IEnumerable<EarthquakeDTO>> GetEarthquakes()
        {
            var earthquakes = await _earthquakeRepository.GetEarthquakesAsync();
            return _mapper.Map<IEnumerable<EarthquakeDTO>>(earthquakes);
        }

        public async Task RemoveEarthquake(int id)
        {
            await _earthquakeRepository.RemoveAsync(id.ToString());
        }

        public async Task UpdateEarthquake(EarthquakeDTO earthquakeDto)
        {
            var earthquake = await _earthquakeRepository.GetEarthquakeByIdAsync(earthquakeDto.DisasterId.ToString());
            if (earthquake != null)
            {
                _mapper.Map(earthquakeDto, earthquake);
                await _earthquakeRepository.UpdateAsync(earthquake);
            }
        }
    }

}
