using AutoMapper;
using InsaragSystem.Application.DTOs.TeamDTOs;
using InsaragSystem.Application.Interfaces;
using InsaragSystem.Domain.Entities.Team;
using InsaragSystem.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Application.Services
{
    public class TeamService : ITeamService
    {
        private readonly IMapper _mapper;
        private ITeamRepository _teamRepository;
        public TeamService(ITeamRepository teamRepository, IMapper mapper)
        {
            _teamRepository = teamRepository ?? throw new ArgumentNullException(nameof(teamRepository));
            _mapper = mapper;
        }

        public async Task AddTeam(TeamDTO teamDto)
        {
            var team = _mapper.Map<Team>(teamDto);
            await _teamRepository.CreateAsync(team);
        }

        public async Task<TeamDTO> GetTeamById(int id)
        {
            var team = await _teamRepository.GetByIdAsync(id);
            return _mapper.Map<TeamDTO>(team);
        }

        public async Task<IEnumerable<TeamDTO>> GetTeams()
        {
            var teams = await _teamRepository.GetTeamsAsync();
            return _mapper.Map<IEnumerable<TeamDTO>>(teams);
        }

        public async Task RemoveTeam(int? id)
        {
            var team = await _teamRepository.GetByIdAsync(id);
            if (team != null)
            {
                await _teamRepository.RemoveAsync(team);
            }
        }

        public async Task UpdateTeam(TeamDTO teamDto)
        {
            var team = await _teamRepository.GetByIdAsync(teamDto.Id);
            if (team != null)
            {
                _mapper.Map(teamDto, team);
                await _teamRepository.UpdateAsync(team);
            }
        }
    }
}
