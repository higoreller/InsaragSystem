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
    public class WildfireService : IWildfireService
    {
        private readonly IWildfireRepository _wildfireRepository;
        private readonly IMapper _mapper;

        public WildfireService(IWildfireRepository wildfireRepository, IMapper mapper)
        {
            _wildfireRepository = wildfireRepository ?? throw new ArgumentNullException(nameof(wildfireRepository));
            _mapper = mapper;
        }

        public async Task<WildfireDTO> AddWildfire(WildfireDTO wildfireDto)
        {
            var wildfire = _mapper.Map<Wildfire>(wildfireDto);
            await _wildfireRepository.CreateAsync(wildfire);
            return _mapper.Map<WildfireDTO>(wildfire);
        }

        public async Task<WildfireDTO> GetWildfireById(int id)
        {
            var wildfire = await _wildfireRepository.GetWildfireByIdAsync(id.ToString());
            return _mapper.Map<WildfireDTO>(wildfire);
        }

        public async Task<IEnumerable<WildfireDTO>> GetWildfires()
        {
            var wildfires = await _wildfireRepository.GetWildfiresAsync();
            return _mapper.Map<IEnumerable<WildfireDTO>>(wildfires);
        }

        public async Task RemoveWildfire(int id)
        {
            await _wildfireRepository.RemoveAsync(id.ToString());
        }

        public async Task UpdateWildfire(WildfireDTO wildfireDto)
        {
            var wildfire = await _wildfireRepository.GetWildfireByIdAsync(wildfireDto.DisasterId.ToString());
            if (wildfire != null)
            {
                _mapper.Map(wildfireDto, wildfire);
                await _wildfireRepository.UpdateAsync(wildfire);
            }
        }
    }

}
