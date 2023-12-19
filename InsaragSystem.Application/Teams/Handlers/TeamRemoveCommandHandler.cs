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
    public class TeamRemoveCommandHandler : IRequestHandler<TeamRemoveCommand, Team>
    {
        private readonly ITeamRepository _teamRepository;
        public TeamRemoveCommandHandler(ITeamRepository teamRepository)
        {
            _teamRepository = teamRepository ?? throw new
                ArgumentNullException(nameof(teamRepository));
        }

        public async Task<Team> Handle(TeamRemoveCommand request,
            CancellationToken cancellationToken)
        {
            var team = await _teamRepository.GetByIdAsync(request.Id);

            if (team == null)
            {
                throw new ApplicationException($"Entity could not be found.");
            }
            else
            {
                var result = await _teamRepository.RemoveAsync(team);
                return result;
            }
        }
    }
}