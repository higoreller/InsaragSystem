using InsaragSystem.Application.Teams.Queries;
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
    public class GetTeamsQueryHandler : IRequestHandler<GetTeamsQuery, IEnumerable<Team>>
    {
        private readonly ITeamRepository _teamRepository;

        public GetTeamsQueryHandler(ITeamRepository teamRepository)
        {
            _teamRepository = teamRepository;
        }
        public async Task<IEnumerable<Team>> Handle(GetTeamsQuery request, CancellationToken cancellationToken)
        {
            return await _teamRepository.GetTeamsAsync();
        }


    }
}