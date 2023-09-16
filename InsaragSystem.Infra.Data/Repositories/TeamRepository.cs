using InsaragSystem.Domain.Entities.Team;
using InsaragSystem.Domain.Interfaces;
using InsaragSystem.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Infra.Data.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        private readonly ApplicationDbContext _teamContext;
        public TeamRepository(ApplicationDbContext context)
        {
            _teamContext = context;
        }
        public async Task<Team> CreateAsync(Team team)
        {
            _teamContext.Add(team);
            await _teamContext.SaveChangesAsync();
            return team;
        }

        public async Task<Team> GetByIdAsync(int? id)
        {
            return await _teamContext.Teams.FindAsync(id);
        }

        public async Task<Team> GetTeamDisasterAsync(int? id)
        {
            if (id == null) return null;

            return await _teamContext.Teams.Include(t => t.Disaster).FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task<IEnumerable<Team>> GetTeamsAsync()
        {
            return await _teamContext.Teams.ToListAsync();
        }

        public async Task<Team> RemoveAsync(Team team)
        {
            if (team == null) throw new ArgumentNullException(nameof(team));

            _teamContext.Teams.Remove(team);
            await _teamContext.SaveChangesAsync();
            return team;
        }

        public async Task<Team> UpdateAsync(Team team)
        {
            if (team == null) throw new ArgumentNullException(nameof(team));

            _teamContext.Teams.Update(team);
            await _teamContext.SaveChangesAsync();
            return team;
        }
    }
}
