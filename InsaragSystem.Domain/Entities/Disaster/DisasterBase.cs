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
            Sectors = new List<Sector.Sector>();
        }

    }
}
