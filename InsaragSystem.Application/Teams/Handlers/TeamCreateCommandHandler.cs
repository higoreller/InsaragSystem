using InsaragSystem.Application.Teams.Commands;
using InsaragSystem.Domain.Entities.Team;
using InsaragSystem.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Application.Teams.Handlers
{
    public class TeamCreateCommandHandler : IRequestHandler<TeamCreateCommand, Team>
    {
        private ITeamRepository _teamRepository;

        public TeamCreateCommandHandler(ITeamRepository teamRepository)
        {
            _teamRepository = teamRepository;
        }

        public async Task<Team> Handle(TeamCreateCommand request, CancellationToken cancellationToken)
        {
            var team = new Team(request.ContactDetails, request.SupportRequirements, request.TeamDetails)
            {
                DisasterId = request.DisasterId
            };


            if (team == null)
            {
                throw new ApplicationException($"Error creating entity.");
            }
            else
            {
                return await _teamRepository.CreateAsync(team);
            }
        }
    }
}