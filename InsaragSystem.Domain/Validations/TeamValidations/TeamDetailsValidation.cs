using InsaragSystem.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Domain.Validations.TeamValidations
{
    public static class TeamDetailsValidation
    {
        public const int MaxNameLength = 100;
        public const int MaxCountryCodeLength = 3;

        public static void ValidateId(int id)
        {
            DomainExceptionValidation.When(id < 0, "Id cannot be negative.");
        }

        public static void ValidateName(string name)
        {
            DomainExceptionValidation.When(string.IsNullOrWhiteSpace(name), "Name cannot be null or whitespace.");
            DomainExceptionValidation.When(name.Length > MaxNameLength, $"Name cannot be more than {MaxNameLength} characters.");
        }

        public static void ValidateOlympicCountryCode(string olympicCountryCode)
        {
            DomainExceptionValidation.When(string.IsNullOrWhiteSpace(olympicCountryCode), "Olympic country code cannot be null or whitespace.");
            DomainExceptionValidation.When(olympicCountryCode.Length != MaxCountryCodeLength, $"Olympic country code should be {MaxCountryCodeLength} characters long.");
        }

        public static void ValidateCountryOfOrigin(string countryOfOrigin)
        {
            DomainExceptionValidation.When(string.IsNullOrWhiteSpace(countryOfOrigin), "Country of origin cannot be null or whitespace.");
        }

        public static void ValidateTotalDeployedPeople(int totalDeployedPeople)
        {
            DomainExceptionValidation.When(totalDeployedPeople < 0, "Total deployed people cannot be negative.");
        }

        public static void ValidateTotalDeployedDogs(int totalDeployedDogs)
        {
            DomainExceptionValidation.When(totalDeployedDogs < 0, "Total deployed dogs cannot be negative.");
        }

        public static void ValidateResponseType(string responseType)
        {
            DomainExceptionValidation.When(string.IsNullOrWhiteSpace(responseType), "Response type cannot be null or whitespace.");
        }

        public static void ValidateInsaragClassification(string insaragClassification)
        {
            DomainExceptionValidation.When(string.IsNullOrWhiteSpace(insaragClassification), "Insarag classification cannot be null or whitespace.");
        }

        public static void ValidateNumberOfStructuralEngineers(int numberOfStructuralEngineers)
        {
            DomainExceptionValidation.When(numberOfStructuralEngineers < 0, "Number of structural engineers cannot be negative.");
        }

        public static void ValidateOtherCapabilities(string otherCapabilities)
        {
            DomainExceptionValidation.When(string.IsNullOrWhiteSpace(otherCapabilities), "Other capabilities cannot be null or whitespace.");
        }

        public static void ValidateDaysOfWaterAutonomy(int daysOfWaterAutonomy)
        {
            DomainExceptionValidation.When(daysOfWaterAutonomy < 0, "Days of water autonomy cannot be negative.");
        }

        public static void ValidateDaysOfFoodAutonomy(int daysOfFoodAutonomy)
        {
            DomainExceptionValidation.When(daysOfFoodAutonomy < 0, "Days of food autonomy cannot be negative.");
        }

        public static void ValidateEstimatedArrivalDateTime(DateTime estimatedArrivalDateTime)
        {
            DomainExceptionValidation.When(estimatedArrivalDateTime <= DateTime.Now, "Estimated arrival date time should be a future date.");
        }

        public static void ValidateArrivalPoint(string arrivalPoint)
        {
            DomainExceptionValidation.When(string.IsNullOrWhiteSpace(arrivalPoint), "Arrival point cannot be null or whitespace.");
        }

        public static void ValidateAircraftType(string aircraftType)
        {
            DomainExceptionValidation.When(string.IsNullOrWhiteSpace(aircraftType), "Aircraft type cannot be null or whitespace.");
        }
    }
}
