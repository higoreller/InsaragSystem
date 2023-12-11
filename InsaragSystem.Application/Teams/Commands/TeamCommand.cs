using InsaragSystem.Domain.Entities.Team;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Application.Teams.Commands
{
    public abstract class TeamCommand : IRequest<Team>
    {
        public int TeamId { get; set; }
        public ContactDetails ContactDetails { get; set; }
        public SupportRequirements SupportRequirements { get; set; }
        public TeamDetails TeamDetails { get; set; }

    }
}
