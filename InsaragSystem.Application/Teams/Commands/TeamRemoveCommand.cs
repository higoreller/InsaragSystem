using InsaragSystem.Domain.Entities.Team;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Application.Teams.Commands
{
    public class TeamRemoveCommand : IRequest<Team>
    {
        public int TeamId { get; set; }
        public TeamRemoveCommand(int teamId)
        {
            TeamId = teamId;
        }
    }
}
