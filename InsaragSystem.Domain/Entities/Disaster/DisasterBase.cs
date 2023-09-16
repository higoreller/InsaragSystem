using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Domain.Entities.Disaster
{
    public enum DisasterType
    {
        Wildfire,
        Earthquake,
        Flood,
    }

    public enum DisasterScope
    {
        National,
        International
    }

    public enum DisasterImpactLevel
    {
        Low,
        Moderate,
        High,
        Severe
    }

    public class DisasterBase
    {
        public int DisasterId { get; set; } 
        public string Name { get; set; } 
        public DisasterType Type { get; set; } 
        public DisasterScope Scope { get; set; } 
        public DateTime DateStarted { get; set; } 
        public DateTime DateEnded { get; set; } 
        public GpsCoordinates? Epicenter { get; set; } 
        public string Description { get; set; } 
        public List<string> AffectedAreas { get; set; } 
        public bool IsActive { get; set; } 
        public DisasterImpactLevel ImpactLevel { get; set; } 
        public string InitiatingEvent { get; set; } 
        public List<string> ReliefResources { get; set; } 
        public List<string> ImmediateNeeds { get; set; } 
        public int EstimatedAffectedPopulation { get; set; } 
        public int EstimatedCasualties { get; set; } 
        public int EstimatedDisplacedPersons { get; set; } 
        public decimal EstimatedEconomicLoss { get; set; }
        public virtual ICollection<Team.Team> Teams { get; set; }
        public virtual ICollection<Sector.Sector> Sectors { get; set; }

        protected DisasterBase()
        {
            AffectedAreas = new List<string>();
            ReliefResources = new List<string>();
            ImmediateNeeds = new List<string>();
            Teams = new List<Team.Team>();
        }

        public class Builder
        {
            private readonly DisasterBase _disaster = new();

            public Builder WithDisasterId(int disasterId)
            {
                _disaster.DisasterId = disasterId;
                return this;
            }

            public Builder WithName(string name)
            {
                _disaster.Name = name;
                return this;
            }

            public Builder WithType(DisasterType type)
            {
                _disaster.Type = type;
                return this;
            }

            public Builder WithScope(DisasterScope scope)
            {
                _disaster.Scope = scope;
                return this;
            }

            public Builder WithDateStarted(DateTime dateStarted)
            {
                _disaster.DateStarted = dateStarted;
                return this;
            }

            public Builder WithDateEnded(DateTime dateEnded)
            {
                _disaster.DateEnded = dateEnded;
                return this;
            }

            public Builder WithEpicenter(double latitude, double longitude)
            {
                _disaster.Epicenter = new GpsCoordinates(latitude, longitude);
                return this;
            }

            public Builder WithDescription(string description)
            {
                _disaster.Description = description;
                return this;
            }

            public Builder AddAffectedArea(string area)
            {
                if (_disaster.AffectedAreas == null)
                {
                    _disaster.AffectedAreas = new List<string>();
                }
                _disaster.AffectedAreas.Add(area);
                return this;
            }

            public Builder WithIsActive(bool isActive)
            {
                _disaster.IsActive = isActive;
                return this;
            }

            public Builder WithImpactLevel(DisasterImpactLevel impactLevel)
            {
                _disaster.ImpactLevel = impactLevel;
                return this;
            }

            public Builder WithInitiatingEvent(string initiatingEvent)
            {
                _disaster.InitiatingEvent = initiatingEvent;
                return this;
            }

            public Builder AddReliefResource(string resource)
            {
                if (_disaster.ReliefResources == null)
                {
                    _disaster.ReliefResources = new List<string>();
                }
                _disaster.ReliefResources.Add(resource);
                return this;
            }

            public Builder AddImmediateNeed(string need)
            {
                if (_disaster.ImmediateNeeds == null)
                {
                    _disaster.ImmediateNeeds = new List<string>();
                }
                _disaster.ImmediateNeeds.Add(need);
                return this;
            }

            public Builder WithEstimatedAffectedPopulation(int count)
            {
                _disaster.EstimatedAffectedPopulation = count;
                return this;
            }

            public Builder WithEstimatedCasualties(int count)
            {
                _disaster.EstimatedCasualties = count;
                return this;
            }

            public Builder WithEstimatedDisplacedPersons(int count)
            {
                _disaster.EstimatedDisplacedPersons = count;
                return this;
            }

            public Builder WithEstimatedEconomicLoss(decimal amount)
            {
                _disaster.EstimatedEconomicLoss = amount;
                return this;
            }

            public Builder AddTeam(Team.Team team)
            {
                if (team == null) throw new ArgumentNullException(nameof(team));
                _disaster.Teams.Add(team);
                return this;
            }

            public Builder RemoveTeam(Team.Team team)
            {
                if (team == null) throw new ArgumentNullException(nameof(team));
                _disaster.Teams.Remove(team);
                return this;
            }

            public DisasterBase Build()
            {
                return _disaster;
            }
        }

    }
}
