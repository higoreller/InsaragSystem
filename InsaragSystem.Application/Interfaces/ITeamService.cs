using InsaragSystem.Application.DTOs.TeamDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Application.Interfaces
{
    public interface ITeamService
    {
        Task<IEnumerable<TeamDTO>> GetTeams();
        Task<TeamDTO> GetTeamById(int id);
        Task AddTeam(TeamDTO teamDto);
        Task UpdateTeam(TeamDTO teamDto);
        Task RemoveTeam(int? id);
    }
}
