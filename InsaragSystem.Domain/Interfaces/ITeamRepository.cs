using InsaragSystem.Domain.Entities.Team;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Domain.Interfaces
{
    public interface ITeamRepository
    {
        Task<IEnumerable<Team>> GetTeamsAsync();
        Task<Team> GetByIdAsync(int? id);
        Task<Team> GetTeamDisasterAsync(int? id);
        Task<Team> CreateAsync(Team team);
        Task<Team> UpdateAsync(Team team);
        Task<Team> RemoveAsync(Team team);
    }
}
