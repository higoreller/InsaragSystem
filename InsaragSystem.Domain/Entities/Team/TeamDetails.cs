using InsaragSystem.Domain.Validation;
using InsaragSystem.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InsaragSystem.Domain.Entities.Team
{
    public sealed class TeamDetails : TeamBase
    {
        public string OlympicCountryCode { get; private set; }
        public string Name { get; private set; }
        public string CountryOfOrigin { get; private set; }
        public int TotalDeployedPeople { get; private set; }
        public int TotalDeployedDogs { get; private set; }
        public string ResponseType { get; private set; }
        public string InsaragClassification { get; private set; }
        public bool HasTechnicalSearchCapability { get; private set; }
        public bool HasCanineSearchCapability { get; private set; }
        public bool HasRescueCapability { get; private set; }
        public bool HasMedicalCapability { get; private set; }
        public bool HasHazardousMaterialDetectionCapability { get; private set; }
        public int NumberOfStructuralEngineers { get; private set; }
        public bool HasProvisionalOSOCCCapability { get; private set; }
        public bool CanSupportUC { get; private set; }
        public string OtherCapabilities { get; private set; }
        public int DaysOfWaterAutonomy { get; private set; }
        public int DaysOfFoodAutonomy { get; private set; }
        public DateTime EstimatedArrivalDateTime { get; private set; }
        public string ArrivalPoint { get; private set; }
        public string AircraftType { get; private set; }

        private TeamDetails()
        {

        }

        public void Update(
            int id,
            string olympicCountryCode,
            string name,
            string countryOfOrigin,
            int totalDeployedPeople,
            int totalDeployedDogs,
            string responseType,
            string insaragClassification,
            bool hasTechnicalSearchCapability,
            bool hasCanineSearchCapability,
            bool hasRescueCapability,
            bool hasMedicalCapability,
            bool hasHazardousMaterialDetectionCapability,
            int numberOfStructuralEngineers,
            bool hasProvisionalOSOCCCapability,
            bool canSupportUC,
            string otherCapabilities,
            int daysOfWaterAutonomy,
            int daysOfFoodAutonomy,
            DateTime estimatedArrivalDateTime,
            string arrivalPoint,
            string aircraftType)
        {
            var builder = new Builder()
                .WithId(id)
                .WithOlympicCountryCode(olympicCountryCode)
                .WithName(name)
                .WithCountryOfOrigin(countryOfOrigin)
                .WithTotalDeployedPeople(totalDeployedPeople)
                .WithTotalDeployedDogs(totalDeployedDogs)
                .WithResponseType(responseType)
                .WithInsaragClassification(insaragClassification)
                .WithHasTechnicalSearchCapability(hasTechnicalSearchCapability)
                .WithHasCanineSearchCapability(hasCanineSearchCapability)
                .WithHasRescueCapability(hasRescueCapability)
                .WithHasMedicalCapability(hasMedicalCapability)
                .WithHasHazardousMaterialDetectionCapability(hasHazardousMaterialDetectionCapability)
                .WithNumberOfStructuralEngineers(numberOfStructuralEngineers)
                .WithHasProvisionalOSOCCCapability(hasProvisionalOSOCCCapability)
                .WithCanSupportUC(canSupportUC)
                .WithOtherCapabilities(otherCapabilities)
                .WithDaysOfWaterAutonomy(daysOfWaterAutonomy)
                .WithDaysOfFoodAutonomy(daysOfFoodAutonomy)
                .WithEstimatedArrivalDateTime(estimatedArrivalDateTime)
                .WithArrivalPoint(arrivalPoint)
                .WithAircraftType(aircraftType);

            var updatedDetails = builder.Build();

            Id = updatedDetails.Id;
            OlympicCountryCode = updatedDetails.OlympicCountryCode;
            Name = updatedDetails.Name;
            CountryOfOrigin = updatedDetails.CountryOfOrigin;
            TotalDeployedPeople = updatedDetails.TotalDeployedPeople;
            TotalDeployedDogs = updatedDetails.TotalDeployedDogs;
            ResponseType = updatedDetails.ResponseType;
            InsaragClassification = updatedDetails.InsaragClassification;
            HasTechnicalSearchCapability = updatedDetails.HasTechnicalSearchCapability;
            HasCanineSearchCapability = updatedDetails.HasCanineSearchCapability;
            HasRescueCapability = updatedDetails.HasRescueCapability;
            HasMedicalCapability = updatedDetails.HasMedicalCapability;
            HasHazardousMaterialDetectionCapability = updatedDetails.HasHazardousMaterialDetectionCapability;
            NumberOfStructuralEngineers = updatedDetails.NumberOfStructuralEngineers;
            HasProvisionalOSOCCCapability = updatedDetails.HasProvisionalOSOCCCapability;
            CanSupportUC = updatedDetails.CanSupportUC;
            OtherCapabilities = updatedDetails.OtherCapabilities;
            DaysOfWaterAutonomy = updatedDetails.DaysOfWaterAutonomy;
            DaysOfFoodAutonomy = updatedDetails.DaysOfFoodAutonomy;
            EstimatedArrivalDateTime = updatedDetails.EstimatedArrivalDateTime;
            ArrivalPoint = updatedDetails.ArrivalPoint;
            AircraftType = updatedDetails.AircraftType;
        }


        public class Builder
        {
            private readonly TeamDetails _teamDetails = new();
                     
            public Builder WithId(int id)
            {
                TeamDetailsValidation.ValidateId(id);
                _teamDetails.Id = id;
                return this;
            }

            public Builder WithOlympicCountryCode(string olympicCountryCode)
            {
                TeamDetailsValidation.ValidateOlympicCountryCode(olympicCountryCode);
                _teamDetails.OlympicCountryCode = olympicCountryCode;
                return this;
            }

            public Builder WithName(string name)
            {
                TeamDetailsValidation.ValidateName(name);
                _teamDetails.Name = name;
                return this;
            }

            public Builder WithCountryOfOrigin(string countryOfOrigin)
            {
                TeamDetailsValidation.ValidateCountryOfOrigin(countryOfOrigin);
                _teamDetails.CountryOfOrigin = countryOfOrigin;
                return this;
            }

            public Builder WithTotalDeployedPeople(int totalDeployedPeople)
            {
                TeamDetailsValidation.ValidateTotalDeployedPeople(totalDeployedPeople);
                _teamDetails.TotalDeployedPeople = totalDeployedPeople;
                return this;
            }

            public Builder WithTotalDeployedDogs(int totalDeployedDogs)
            {
                TeamDetailsValidation.ValidateTotalDeployedDogs(totalDeployedDogs);
                _teamDetails.TotalDeployedDogs = totalDeployedDogs;
                return this;
            }

            public Builder WithResponseType(string responseType)
            {
                TeamDetailsValidation.ValidateResponseType(responseType);
                _teamDetails.ResponseType = responseType;
                return this;
            }

            public Builder WithInsaragClassification(string insaragClassification)
            {
                TeamDetailsValidation.ValidateInsaragClassification(insaragClassification);
                _teamDetails.InsaragClassification = insaragClassification;
                return this;
            }

            public Builder WithHasTechnicalSearchCapability(bool hasTechnicalSearchCapability)
            {
                _teamDetails.HasTechnicalSearchCapability = hasTechnicalSearchCapability;
                return this;
            }

            public Builder WithHasCanineSearchCapability(bool hasCanineSearchCapability)
            {
                _teamDetails.HasCanineSearchCapability = hasCanineSearchCapability;
                return this;
            }

            public Builder WithHasRescueCapability(bool hasRescueCapability)
            {
                _teamDetails.HasRescueCapability = hasRescueCapability;
                return this;
            }

            public Builder WithHasMedicalCapability(bool hasMedicalCapability)
            {
                _teamDetails.HasMedicalCapability = hasMedicalCapability;
                return this;
            }
            public Builder WithHasHazardousMaterialDetectionCapability(bool hasHazardousMaterialDetectionCapability)
            {
                _teamDetails.HasHazardousMaterialDetectionCapability = hasHazardousMaterialDetectionCapability;
                return this;
            }
            public Builder WithNumberOfStructuralEngineers(int numberOfStructuralEngineers)
            {
                TeamDetailsValidation.ValidateNumberOfStructuralEngineers(numberOfStructuralEngineers);
                _teamDetails.NumberOfStructuralEngineers = numberOfStructuralEngineers;
                return this;
            }
            public Builder WithHasProvisionalOSOCCCapability(bool hasProvisionalOSOCCCapability)
            {
                _teamDetails.HasProvisionalOSOCCCapability = hasProvisionalOSOCCCapability;
                return this;
            }
            public Builder WithCanSupportUC(bool canSupportUC)
            {
                _teamDetails.CanSupportUC = canSupportUC;
                return this;
            }
            public Builder WithOtherCapabilities(string otherCapabilities)
            {
                TeamDetailsValidation.ValidateOtherCapabilities(otherCapabilities);
                _teamDetails.OtherCapabilities = otherCapabilities;
                return this;
            }
            public Builder WithDaysOfWaterAutonomy(int daysOfWaterAutonomy)
            {
                TeamDetailsValidation.ValidateDaysOfWaterAutonomy(daysOfWaterAutonomy);
                _teamDetails.DaysOfWaterAutonomy = daysOfWaterAutonomy;
                return this;
            }
            public Builder WithDaysOfFoodAutonomy(int daysOfFoodAutonomy)
            {
                TeamDetailsValidation.ValidateDaysOfFoodAutonomy(daysOfFoodAutonomy);
                _teamDetails.DaysOfFoodAutonomy = daysOfFoodAutonomy;
                return this;
            }
            public Builder WithEstimatedArrivalDateTime(DateTime estimatedArrivalDateTime)
            {
                TeamDetailsValidation.ValidateEstimatedArrivalDateTime(estimatedArrivalDateTime);
                _teamDetails.EstimatedArrivalDateTime = estimatedArrivalDateTime;
                return this;
            }
            public Builder WithArrivalPoint(string arrivalPoint)
            {
                TeamDetailsValidation.ValidateArrivalPoint(arrivalPoint);
                _teamDetails.ArrivalPoint = arrivalPoint;
                return this;
            }
            public Builder WithAircraftType(string aircraftType)
            {
                TeamDetailsValidation.ValidateAircraftType(aircraftType);
                _teamDetails.AircraftType = aircraftType;
                return this;
            }

            public TeamDetails Build()
            {
                return _teamDetails;
            }
        }
    }
}
