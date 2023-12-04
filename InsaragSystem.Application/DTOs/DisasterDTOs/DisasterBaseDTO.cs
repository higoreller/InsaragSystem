using InsaragSystem.Application.DTOs.SectorDTOs;
using InsaragSystem.Application.DTOs.TeamDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Application.DTOs.DisasterDTOs
{
    public enum DisasterTypeDTO
    {
        Wildfire,
        Earthquake,
        Flood,
    }

    public enum DisasterScopeDTO
    {
        National,
        International
    }

    public enum DisasterImpactLevelDTO
    {
        Low,
        Moderate,
        High,
        Severe
    }
    public class DisasterBaseDTO
    {
        public int DisasterId { get; set; }
        public string Name { get; set; }
        public DisasterTypeDTO Type { get; set; }
        public DisasterScopeDTO Scope { get; set; }
        public DateTime DateStarted { get; set; }
        public DateTime DateEnded { get; set; }
        public GpsCoordinatesDTO? Epicenter { get; set; }
        public string Description { get; set; }
        public List<string> AffectedAreas { get; set; }
        public bool IsActive { get; set; }
        public DisasterImpactLevelDTO ImpactLevel { get; set; }
        public string InitiatingEvent { get; set; }
        public List<string> ReliefResources { get; set; }
        public List<string> ImmediateNeeds { get; set; }
        public int EstimatedAffectedPopulation { get; set; }
        public int EstimatedCasualties { get; set; }
        public int EstimatedDisplacedPersons { get; set; }
        public decimal EstimatedEconomicLoss { get; set; }
        public List<TeamDTO> Teams { get; set; }  
        public List<SectorDTO> Sectors { get; set; }

    }
}
