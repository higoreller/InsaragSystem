using AutoMapper;
using InsaragSystem.Application.DTOs.TeamDTOs;
using InsaragSystem.Application.Interfaces;
using InsaragSystem.Application.Teams.Commands;
using InsaragSystem.Application.Teams.Queries;
using InsaragSystem.Domain.Entities.Team;
using InsaragSystem.Domain.Interfaces;
using MediatR;
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
        private readonly IMediator _mediator;

        public TeamService(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        public async Task AddTeam(TeamDTO teamDto)
        {
            var createCommand = _mapper.Map<TeamCreateCommand>(teamDto);
            await _mediator.Send(createCommand);
        }

        public async Task<TeamDTO> GetTeamById(int id)
        {
            var teamQuery = new GetTeamByIdQuery(id);
            var team = await _mediator.Send(teamQuery);
            return _mapper.Map<TeamDTO>(team);
        }

        public async Task<IEnumerable<TeamDTO>> GetTeams()
        {
            var teamsQuery = new GetTeamsQuery();
            var teams = await _mediator.Send(teamsQuery);
            return _mapper.Map<IEnumerable<TeamDTO>>(teams);
        }

        public async Task RemoveTeam(int? id)
        {
            var deleteCommand = new TeamRemoveCommand(id.Value);
            if(deleteCommand == null)
            {
                throw new Exception($"Entity could not be removed.");
            } else
            {
                await _mediator.Send(deleteCommand);

            }
        }

        public async Task UpdateTeam(TeamDTO teamDto)
        {
            var updateCommand = _mapper.Map<TeamUpdateCommand>(teamDto);
            await _mediator.Send(updateCommand);
        }
    }
}
