using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InsaragSystem.Domain.Entities.Disaster;

namespace InsaragSystem.Domain.Entities.Team
{
    public class Team : TeamBase
    {
        public ContactDetails ContactDetails { get; private set; }
        public SupportRequirements SupportRequirements { get; private set; }
        public TeamDetails TeamDetails { get; private set; } 

        private Team() { }

        public Team(ContactDetails contactDetails, SupportRequirements supportRequirements, TeamDetails teamDetails)
        {
            ContactDetails = contactDetails ?? throw new ArgumentNullException(nameof(contactDetails));
            SupportRequirements = supportRequirements ?? throw new ArgumentNullException(nameof(supportRequirements));
            TeamDetails = teamDetails ?? throw new ArgumentNullException(nameof(teamDetails)); 
        }

        public void UpdateContactDetails(ContactDetails newContactDetails)
        {
            ContactDetails.Update(
                newContactDetails.Contact1NameOrTitle,
                newContactDetails.Contact1MobilePhoneNumber,
                newContactDetails.Contact1SatellitePhoneNumber,
                newContactDetails.Contact1Email,
                newContactDetails.Contact2NameOrTitle,
                newContactDetails.Contact2MobilePhoneNumber,
                newContactDetails.Contact2SatellitePhoneNumber,
                newContactDetails.Contact2Email,
                newContactDetails.BaseOperationLocation,
                newContactDetails.RadioFrequencyInMHz,
                newContactDetails.WorkSiteGpsCoordinates
                );         
        }

        public void UpdateSupportRequirements(SupportRequirements newSupportRequirements)
        {
            SupportRequirements.Update(
                newSupportRequirements.Id,
                newSupportRequirements.TotalPeopleToTransport,
                newSupportRequirements.TotalDogsToTransport,
                newSupportRequirements.TotalEquipmentWeightInTons,
                newSupportRequirements.TotalEquipmentVolumeInCubicMeters,
                newSupportRequirements.DailyGasolineRequirementInLiters,
                newSupportRequirements.DailyDieselRequirementInLiters,
                newSupportRequirements.DailyCuttingGasCylindersRequired,
                newSupportRequirements.DailyMedicalOxygenCylindersRequired,
                newSupportRequirements.RequiredBaseOperationSpaceInSquareMeters,
                newSupportRequirements.OtherLogisticRequirements
            );
        }

        public void UpdateTeamDetails(TeamDetails newTeamDetails)
        {
            TeamDetails.Update(
                newTeamDetails.Id,
                newTeamDetails.OlympicCountryCode,
                newTeamDetails.Name,
                newTeamDetails.CountryOfOrigin,
                newTeamDetails.TotalDeployedPeople,
                newTeamDetails.TotalDeployedDogs,
                newTeamDetails.ResponseType,
                newTeamDetails.InsaragClassification,
                newTeamDetails.HasTechnicalSearchCapability,
                newTeamDetails.HasCanineSearchCapability,
                newTeamDetails.HasRescueCapability,
                newTeamDetails.HasMedicalCapability,
                newTeamDetails.HasHazardousMaterialDetectionCapability,
                newTeamDetails.NumberOfStructuralEngineers,
                newTeamDetails.HasProvisionalOSOCCCapability,
                newTeamDetails.CanSupportUC,
                newTeamDetails.OtherCapabilities,
                newTeamDetails.DaysOfWaterAutonomy,
                newTeamDetails.DaysOfFoodAutonomy,
                newTeamDetails.EstimatedArrivalDateTime,
                newTeamDetails.ArrivalPoint,
                newTeamDetails.AircraftType
            );
        }

        public int DisasterId { get; set; }
        public int? AssignedSectorId { get; set; }
        public int? AddressId { get; set; }
        public Address Address { get; set; }
    }
}
