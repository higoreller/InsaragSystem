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

    public abstract class DisasterBase
    {
        public string DisasterId { get; set; } 
        public string Name { get; set; } 
        public DisasterType Type { get; set; } 
        public DisasterScope Scope { get; set; } 
        public DateTime DateStarted { get; set; } 
        public DateTime? DateEnded { get; set; } 
        public GpsCoordinates Epicenter { get; set; } 
        public string Description { get; set; } 
        public List<string> AffectedAreas { get; set; } 
        public bool IsActive { get; set; } 
        public List<string> InvolvedTeams { get; set; }
        public DisasterImpactLevel ImpactLevel { get; set; } // Level of impact of the disaster
        public string InitiatingEvent { get; set; } // The event that led to the disaster, if known
        public List<string> ReliefResources { get; set; } // List of resources available for relief efforts
        public List<string> ImmediateNeeds { get; set; } // List of immediate needs for affected areas
        public int EstimatedAffectedPopulation { get; set; } // Estimated number of people affected
        public int EstimatedCasualties { get; set; } // Estimated number of casualties
        public int EstimatedDisplacedPersons { get; set; } // Estimated number of displaced persons
        public decimal EstimatedEconomicLoss { get; set; } // Estimated economic loss in dollars

        public void AddAffectedArea(string area)
        {
            AffectedAreas.Add(area);
        }

        public void RemoveAffectedArea(string area)
        {
            AffectedAreas.Remove(area);
        }

        public void AssignTeam(string teamName)
        {
            InvolvedTeams.Add(teamName);
        }

        public void UnassignTeam(string teamName)
        {
            InvolvedTeams.Remove(teamName);
        }

        public void SetEpicenter(double latitude, double longitude)
        {
            Epicenter = new GpsCoordinates(latitude, longitude);
        }

        public void ChangeScope(DisasterScope newScope)
        {
            Scope = newScope;
        }

        public void EndDisaster()
        {
            DateEnded = DateTime.Now;
            IsActive = false;
        }

        public void UpdateImpactLevel(DisasterImpactLevel level)
        {
            ImpactLevel = level;
        }

        public void AddReliefResource(string resource)
        {
            ReliefResources.Add(resource);
        }

        public void RemoveReliefResource(string resource)
        {
            ReliefResources.Remove(resource);
        }

        public void AddImmediateNeed(string need)
        {
            ImmediateNeeds.Add(need);
        }

        public void RemoveImmediateNeed(string need)
        {
            ImmediateNeeds.Remove(need);
        }

        public void UpdateEstimatedAffectedPopulation(int count)
        {
            EstimatedAffectedPopulation = count;
        }

        public void UpdateEstimatedCasualties(int count)
        {
            EstimatedCasualties = count;
        }

        public void UpdateEstimatedDisplacedPersons(int count)
        {
            EstimatedDisplacedPersons = count;
        }

        public void UpdateEstimatedEconomicLoss(decimal amount)
        {
            EstimatedEconomicLoss = amount;
        }

        public override string ToString()
        {
            return $"{Name} ({Type}) - Started on {DateStarted.ToShortDateString()}";
        }
    }
}
