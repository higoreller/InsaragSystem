using InsaragSystem.Domain.Entities.Team;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Application.Teams.Queries
{
    public class GetTeamsQuery : IRequest<IEnumerable<Team>>
    {

    }
}
