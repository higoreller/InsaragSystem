using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Domain.Entities.Disaster.Builder
{
    public class DisasterBuilder<T> where T : DisasterBase, new()
    {
        protected T _disaster = new();

        public DisasterBuilder<T> WithDisasterId(int disasterId)
        {
            _disaster.DisasterId = disasterId;
            return this;
        }

        public DisasterBuilder<T> WithName(string name)
        {
            _disaster.Name = name;
            return this;
        }

        public DisasterBuilder<T> WithType(DisasterType type)
        {
            _disaster.Type = type;
            return this;
        }

        public DisasterBuilder<T> WithScope(DisasterScope scope)
        {
            _disaster.Scope = scope;
            return this;
        }

        public DisasterBuilder<T> WithDateStarted(DateTime dateStarted)
        {
            _disaster.DateStarted = dateStarted;
            return this;
        }

        public DisasterBuilder<T> WithDateEnded(DateTime dateEnded)
        {
            _disaster.DateEnded = dateEnded;
            return this;
        }

        public DisasterBuilder<T> WithEpicenter(double latitude, double longitude)
        {
            _disaster.Epicenter = new GpsCoordinates(latitude, longitude);
            return this;
        }

        public DisasterBuilder<T> WithDescription(string description)
        {
            _disaster.Description = description;
            return this;
        }

        public DisasterBuilder<T> AddAffectedArea(string area)
        {
            if (_disaster.AffectedAreas == null)
            {
                _disaster.AffectedAreas = new List<string>();
            }
            _disaster.AffectedAreas.Add(area);
            return this;
        }

        public DisasterBuilder<T> WithIsActive(bool isActive)
        {
            _disaster.IsActive = isActive;
            return this;
        }

        public DisasterBuilder<T> WithImpactLevel(DisasterImpactLevel impactLevel)
        {
            _disaster.ImpactLevel = impactLevel;
            return this;
        }

        public DisasterBuilder<T> WithInitiatingEvent(string initiatingEvent)
        {
            _disaster.InitiatingEvent = initiatingEvent;
            return this;
        }

        public DisasterBuilder<T> AddReliefResource(string resource)
        {
            if (_disaster.ReliefResources == null)
            {
                _disaster.ReliefResources = new List<string>();
            }
            _disaster.ReliefResources.Add(resource);
            return this;
        }

        public DisasterBuilder<T> AddImmediateNeed(string need)
        {
            if (_disaster.ImmediateNeeds == null)
            {
                _disaster.ImmediateNeeds = new List<string>();
            }
            _disaster.ImmediateNeeds.Add(need);
            return this;
        }

        public DisasterBuilder<T> WithEstimatedAffectedPopulation(int count)
        {
            _disaster.EstimatedAffectedPopulation = count;
            return this;
        }

        public DisasterBuilder<T> WithEstimatedCasualties(int count)
        {
            _disaster.EstimatedCasualties = count;
            return this;
        }

        public DisasterBuilder<T> WithEstimatedDisplacedPersons(int count)
        {
            _disaster.EstimatedDisplacedPersons = count;
            return this;
        }

        public DisasterBuilder<T> WithEstimatedEconomicLoss(decimal amount)
        {
            _disaster.EstimatedEconomicLoss = amount;
            return this;
        }

        public DisasterBuilder<T> AddTeam(Team.Team team)
        {
            if (team == null) throw new ArgumentNullException(nameof(team));
            if (_disaster.Teams == null)
            {
                _disaster.Teams = new List<Team.Team>();
            }
            _disaster.Teams.Add(team);
            return this;
        }

        public DisasterBuilder<T> RemoveTeam(Team.Team team)
        {
            if (team == null) throw new ArgumentNullException(nameof(team));
            if (_disaster.Teams != null)
            {
                _disaster.Teams.Remove(team);
            }
            return this;
        }

        public T Build()
        {
            return _disaster;
        }
    }
}
