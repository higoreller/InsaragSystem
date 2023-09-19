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

        // Other relevant methods 
        Task<IEnumerable<TeamDTO>> GetTeamsBySectorId(int sectorId); // If teams are linked with sectors
        Task AssignTeamToSector(int teamId, int sectorId);     // Assign a team to a specific sector
        Task RemoveTeamFromSector(int teamId, int sectorId);  // Remove a team from a specific sector
    }
}
