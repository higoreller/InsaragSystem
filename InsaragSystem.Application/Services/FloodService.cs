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
    public class FloodService : IFloodService
    {
        private readonly IFloodRepository _floodRepository;
        private readonly IMapper _mapper;

        public FloodService(IFloodRepository floodRepository, IMapper mapper)
        {
            _floodRepository = floodRepository ?? throw new ArgumentNullException(nameof(floodRepository)); ;
            _mapper = mapper;
        }

        public async Task<FloodDTO> AddFlood(FloodDTO floodDto)
        {
            var flood = _mapper.Map<Flood>(floodDto);
            await _floodRepository.CreateAsync(flood);
            return _mapper.Map<FloodDTO>(flood);
        }

        public async Task<FloodDTO> GetFloodById(int id)
        {
            var flood = await _floodRepository.GetFloodByIdAsync(id.ToString());
            return _mapper.Map<FloodDTO>(flood);
        }

        public async Task<IEnumerable<FloodDTO>> GetFloods()
        {
            var floods = await _floodRepository.GetFloodsAsync();
            return _mapper.Map<IEnumerable<FloodDTO>>(floods);
        }

        public async Task RemoveFlood(int id)
        {
            await _floodRepository.RemoveAsync(id.ToString());
        }

        public async Task UpdateFlood(FloodDTO floodDto)
        {
            var flood = await _floodRepository.GetFloodByIdAsync(floodDto.DisasterId.ToString());
            if (flood != null)
            {
                _mapper.Map(floodDto, flood);
                await _floodRepository.UpdateAsync(flood);
            }
        }
    }

}
