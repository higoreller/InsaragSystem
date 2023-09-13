using InsaragSystem.Domain.Entities.Disaster;
using InsaragSystem.Domain.Entities.Team;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Domain.Entities.Sector
{
    public enum SectorCode
    {
        A, B, C, D, E, F, G, H, I, J, K, L, M,
        N, O, P, Q, R, S, T, U, V, W, X, Y, Z
    }
    public sealed class Sector
    {
        public int Id { get; set; }
        public SectorCode Code { get; set; }
        public List<Team.Team> AssignedTeams { get; set; }
        public List<Subdivision> Subdivisions { get; set; }

        public Sector()
        {
            AssignedTeams = new List<Team.Team>();
            Subdivisions = new List<Subdivision>();
        }

        public void AssignTeam(Team.Team team)
        {
            if (team == null)
            {
                throw new ArgumentNullException(nameof(team));
            }

            if (!AssignedTeams.Contains(team))
            {
                AssignedTeams.Add(team);
            }
        }

        public void RemoveTeam(Team.Team team)
        {
            if (team == null)
            {
                throw new ArgumentNullException(nameof(team));
            }

            if (AssignedTeams.Contains(team))
            {
                AssignedTeams.Remove(team);
            }
        }

        public void AddSubdivision(Subdivision subdivision)
        {
            if (subdivision == null)
                throw new ArgumentNullException(nameof(subdivision));

            if (!Subdivisions.Contains(subdivision))
                Subdivisions.Add(subdivision);
        }

        public void RemoveSubdivision(Subdivision subdivision)
        {
            if (subdivision == null)
                throw new ArgumentNullException(nameof(subdivision));

            if (Subdivisions.Contains(subdivision))
                Subdivisions.Remove(subdivision);
        }

        public class Builder
        {
            private readonly Sector _sector = new();

            public Builder WithCode(SectorCode code)
            {
                _sector.Code = code;
                return this;
            }


            public Sector Build()
            {
                return _sector;
            }

            public string DisasterId { get; set; }
            public DisasterBase Disaster { get; set; }

        }
    }
}