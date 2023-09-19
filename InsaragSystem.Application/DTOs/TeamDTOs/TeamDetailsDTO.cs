using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Application.DTOs.TeamDTOs
{
    public class TeamDetailsDTO : TeamBaseDTO
    {
        public string OlympicCountryCode { get; set; }
        public string Name { get; set; }
        public string CountryOfOrigin { get; set; }
        public int TotalDeployedPeople { get; set; }
        public int TotalDeployedDogs { get; set; }
        public string ResponseType { get; set; }
        public string InsaragClassification { get; set; }
        public bool HasTechnicalSearchCapability { get; set; }
        public bool HasCanineSearchCapability { get; set; }
        public bool HasRescueCapability { get; set; }
        public bool HasMedicalCapability { get; set; }
        public bool HasHazardousMaterialDetectionCapability { get; set; }
        public int NumberOfStructuralEngineers { get; set; }
        public bool HasProvisionalOSOCCCapability { get; set; }
        public bool CanSupportUC { get; set; }
        public string OtherCapabilities { get; set; }
        public int DaysOfWaterAutonomy { get; set; }
        public int DaysOfFoodAutonomy { get; set; }
        public DateTime EstimatedArrivalDateTime { get; set; }
        public string ArrivalPoint { get; set; }
        public string AircraftType { get; set; }
    }
}
