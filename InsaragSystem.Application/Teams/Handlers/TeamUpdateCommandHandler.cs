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
    public class TeamUpdateCommandHandler : IRequestHandler<TeamUpdateCommand, Team>
    {
        private ITeamRepository _teamRepository;

        public TeamUpdateCommandHandler(ITeamRepository teamRepository)
        {
            _teamRepository = teamRepository ?? throw new ArgumentNullException(nameof(teamRepository));
        }

        public async Task<Team> Handle(TeamUpdateCommand request, CancellationToken cancellationToken)
        {
            var team = await _teamRepository.GetByIdAsync(request.Id);

            if (team == null)
            {
                throw new ApplicationException($"Entity could not be found.");
            }
            else
            {
                team.UpdateContactDetails(request.ContactDetails);
                team.UpdateTeamDetails(request.TeamDetails);
                team.UpdateSupportRequirements(request.SupportRequirements);
                return await _teamRepository.UpdateAsync(team);
            }
        }
    }
}